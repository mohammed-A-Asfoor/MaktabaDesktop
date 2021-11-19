using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Maktaba_Class_Library;

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
                publisherText.Text = bookItem.Publisher;
                quantitiyNum.Value = Convert.ToInt16(bookItem.Quantity);
                PriceText.Text = bookItem.Book_price;
                //setting condition from the condition list
                int Index = 0;
                while (conditionList.Items.Count > Index)
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
            BooksTable.DataSource = bookList.DataTable ;
        }
        public void setBookValus()
        {
            //seting text feilds for Book infomration
            ISBANText.Text = book.ISBAN;
            titleText.Text = book.Book_Title;
            autherText.Text = book.Book_Auther;
            dateOfRelaseText.Text = book.Date_Of_Release;
            // catagoryText.Text = book.category_id;
            catagory = new Catagory(book.category_id);
            catagoryList.Populate(catagory);
            catagoryText.Text = catagory.catagory_name;
        }
        public void settingValuesForUpdateBtn()
        {
            bookItem.ISBAN = book.ISBAN;
            bookItem.Publisher = publisherText.Text;
            bookItem.Quantity = quantitiyNum.Value.ToString();
            bookItem.Admin_ID = Global.admin.Admin_ID;
            bookItem.Adding_date = DateTime.Now.ToString("yyyy/MM/dd");
            textBox8.Text = DateTime.Now.ToString();
            bookItem.Condition = conditionList.SelectedItem.ToString();
            double bookPrice;
            bool isConvertedD = Double.TryParse(PriceText.Text, out bookPrice);
            if (isConvertedD)
            {
                bookItem.Book_price = bookPrice.ToString();
            }
            else
                MessageBox.Show("Only Numbeer Are Allowed in Price Section");

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (book != null)
            {
                if (bookItem == null)
                {
                    bookItem = new BookItem();
                    settingValuesForUpdateBtn();
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
                        textBox3.Text = bookItem.getErroMessage();
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
    }
}
