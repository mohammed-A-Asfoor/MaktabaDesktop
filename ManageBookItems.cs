using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Azure.Storage.Blobs;
using Maktaba_Class_Library;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;

namespace MaktabaDesktop
{
    
    public partial class ManageBookItems : Form
    {
        BookItemList bookItemList;
        BookItem bookItem;
        Book book;
        BookList bookList;
        CatagoryList catagoryList;
        Catagory catagory;
        OpenFileDialog openFileDialog = new OpenFileDialog();
        string filename;
        public ManageBookItems()
        {
            InitializeComponent();
        }

        private void ManageBookItems_Load(object sender, EventArgs e)
        {
            //creating and populating Catagory classess
            catagoryList = new CatagoryList();
            catagory = new Catagory();
            catagoryList.Populate();

            


            //loading conditions
            conditionList.Items.Add("Like New");
            conditionList.Items.Add("Very Good");
            conditionList.Items.Add("Good");
            conditionList.Items.Add("Fine");
            conditionList.Items.Add("Poor");
            conditionList.SelectedIndex = 0;

           //creating book classes
           bookList = new BookList();

            //poppulating the data 
            bookList.Populate();

            

            //loading the data from the database into the datagrid view
            loadBooksTable();

            //loading columns names for search function
            book = new Book();
            bookList.getColumnName(book);
            columnList.DataSource = bookList.ColumnNames;
            //checking if the user is trying to add new book item or edititing one
            if (Global.BookItem == null)
            {
                HeaderText.Text = "Adding New Book Item By " + Global.admin.Admin_Name;
                updateBtn.Text = "Add new Book Item";
            }
            else
            {
                HeaderText.Text = "Editing Book Item "+Global.BookItem.Book_Itme_id+" By " + Global.admin.Admin_Name;
                updateBtn.Text = "Edit this Book Item";
                //loading the data from bookitme frim the mainForm
                bookItem = Global.BookItem;
                //creating book object to get book information 
                book = new Book(bookItem.ISBAN);
                bookList.Populate(book);

                setBookValus();

                //seting infomration for BookItem

                quantitiyNum.Value = Convert.ToInt16(bookItem.Quantity);
                PriceText.Text = bookItem.Book_price;
                pictureBox1.ImageLocation = bookItem.Image;
                //setting condition from the condition list
                int Index = 0;
                while (conditionList.Items.Count <= Index)
                {
                    if (conditionList.SelectedItem.ToString() == bookItem.Condition)
                    {
                        break;
                    }
                    else
                    {
                       
                            Index++;
                            conditionList.SelectedIndex = Index;
                        
                        
                       
                    }
                        
                        
                }

            }
        }
        public void  loadBooksTable()
        {
            bookList.Populate();
            BooksTable.DataSource = bookList.DataTable ;
        }
        public void setBookValus()
        {
            //seting text feilds for Book infomration
            ISBANText.Text = book.ISBAN;
            titleText.Text = book.Book_Title;
            autherText.Text = book.Book_Auther;
            publisherText.Text = book.Publisher;
            dateOfRelaseText.Text = book.Date_Of_Release;
            // catagoryText.Text = book.category_id;
            catagory = new Catagory(book.category_id);
            catagoryList.Populate(catagory);
            catagoryText.Text = catagory.catagory_name;
            
        }
        public void settingValuesForUpdateBtn()
        {
            bookItem.ISBAN = book.ISBAN;
            bookItem.Quantity = quantitiyNum.Value.ToString();
            bookItem.Admin_ID = Global.admin.Admin_ID;
            bookItem.Adding_date = DateTime.Now.ToString("yyyy/MM/dd");
            valueText.Text = DateTime.Now.ToString();
            bookItem.Condition = conditionList.SelectedItem.ToString();
            pictureBox1.ImageLocation = bookItem.Image;
            double bookPrice;
            bool isConvertedD = Double.TryParse(PriceText.Text, out bookPrice);
            if (isConvertedD)
            {
                bookItem.Book_price = bookPrice.ToString();
            }
            else
                MessageBox.Show("Only Numbeer Are Allowed in Price Section");

        }
        public void uploadImage()
        {
            if (imageLocationText.Text != null)
            {
                string connstring = "DefaultEndpointsProtocol=https;AccountName=maktaba0images;AccountKey=Ghl5+YVechO7PR+7xAwy79sUkEqnczajZSg13Z8EVI6hmTJfjUb2NlJo4C6VJX0tNDF+xGmoLYfigFMV1GIo4A==;EndpointSuffix=core.windows.net";
                string containername = "images";
                //string finlename = "TestUpload.docx";
                var fileBytes = System.IO.File.ReadAllBytes(imageLocationText.Text);

                var cloudstorageAccount = CloudStorageAccount.Parse(connstring);
                var cloudblobClient = cloudstorageAccount.CreateCloudBlobClient();
                var containerObject = cloudblobClient.GetContainerReference(containername);

                //check the container existance
                if (containerObject.CreateIfNotExistsAsync().Result)
                {
                    containerObject.SetPermissionsAsync(new BlobContainerPermissions { PublicAccess = BlobContainerPublicAccessType.Blob });
                }

                var fileobject = containerObject.GetBlockBlobReference(filename);

                //check the file type
                string file_type;
                var provider = new FileExtensionContentTypeProvider();
                if (!provider.TryGetContentType(filename, out file_type))
                {
                    file_type = "application/octet-stream";
                }

                fileobject.Properties.ContentType = file_type;
                fileobject.UploadFromByteArrayAsync(fileBytes, 0, fileBytes.Length);

                string fileuploadURI = fileobject.Uri.AbsoluteUri;
                MessageBox.Show("File has be uploaded successfully.");
                MessageBox.Show("The URL of the Uploaded file is : - \n" + fileuploadURI);
                bookItem.Image = fileuploadURI;
            }
            else
                MessageBox.Show("This book item was saved without image");
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (book != null)
            {
                if (bookItem == null)
                {
                    bookItem = new BookItem();
                    settingValuesForUpdateBtn();
                    uploadImage();
                    bookItemList = new BookItemList();
                    bookItemList.Add(bookItem);

                    if (bookItem.getVaild())
                    {
                        MessageBox.Show("Adding is Sucssfull");
                        bookItem = null;
                        ManageBookItems frm = new ManageBookItems();
                        frm.Close();
                    }
                    else{
                       
                        MessageBox.Show("ERRRO: " + bookItem.getErroMessage());
                    }
                    
                }
                else
                {
                    bookItemList = new BookItemList();
                    settingValuesForUpdateBtn();
                    bookItemList.Update(bookItem);
                    if (bookItem.getVaild())
                    {
                        MessageBox.Show("Adding is Sucssfull");
                        ManageBookItems frm = new ManageBookItems();
                        frm.Close();
                    }
                    else
                    {
                      
                        MessageBox.Show("ERRRO: " + bookItem.getErroMessage());
                    }
                    bookItem = null;
                }
               
            }
            else
                MessageBox.Show("You Need to Select a Book First");
        }

        private void BooksTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string bookID = BooksTable.CurrentRow.Cells[0].Value.ToString();
            book = new Book(bookID);
            bookList.Populate(book);
            setBookValus();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            //check if Value TextBox is Not Empty
            if (!string.IsNullOrWhiteSpace(valueText.Text))
            {
                
                
                if (columnList.SelectedIndex == 4)
                {
                    DateTime date;
                    bool isDate = DateTime.TryParse(valueText.Text, out date);
                    if (isDate)
                    {
                        bookList.Filter(columnList.SelectedItem.ToString(), valueText.Text);
                    }
                    else
                        MessageBox.Show("Wrong Data Type. you should enter Date");
                }else if (columnList.SelectedIndex == 5)
                {
                    int num;
                    bool isInt = int.TryParse(valueText.Text, out num);
                    if (isInt)
                    {
                        bookList.Filter(columnList.SelectedItem.ToString(), valueText.Text);
                    }
                    else
                        MessageBox.Show("the Value should be Number");
                }else
                    bookList.Filter(columnList.SelectedItem.ToString(), valueText.Text);


            }
            else
                MessageBox.Show("Empty Feild");
        }

        private void clearTableBtn_Click(object sender, EventArgs e)
        {
            loadBooksTable();
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
           // string imageLocation = "";
           
            openFileDialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
            if(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imageLocationText.Text = openFileDialog.FileName;
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                filename = Path.GetFileName(openFileDialog.FileName);
            }
        }

        private void uploadImage_Click(object sender, EventArgs e)
        {

            
            
        }
    }
}
