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
    public partial class BookInformationForm : Form
    {
        BookList bookList;
        Book book;
        BookItem bookItem;
        BookItemList bookItemList;
        CatagoryList catagoryList;
        Catagory catagory;
        string ISPAN;
        public BookInformationForm()
        {
            InitializeComponent();
        }

        private void BookInformationForm_Load(object sender, EventArgs e)
        {
            bookList = new BookList();
            book = new Book();
            bookList.getColumnName(book);
            comboBox1.DataSource = bookList.ColumnNames;
            book = null;
            //creating the catagory list
            catagoryList = new CatagoryList();
            catagoryList.Populate();
            catagorycombo.DataSource = catagoryList.List;

            loadDataToTable();
        } //to load data and refresh table after editing it
        public void loadDataToTable()
        {
            try
            {
                bookList = new BookList();
                bookList.Populate();

               
                    BookInformationTable.DataSource = bookList.DataTable;
                    
             
            }catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
            
        }

        private void BookInformationTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (BookInformationTable.RowCount != 0)
                {
                    ISPAN = BookInformationTable.CurrentRow.Cells[0].Value.ToString();
                    book = new Book(ISPAN);

                    bookList.Populate(book);
                    loadDataToTextfields();
                }
                else
                    MessageBox.Show("No Books to show");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }
       
        public void loadDataToTextfields()
        {
            ISNAPtext.Text = book.ISBAN;
            autherText.Text = book.Book_Auther;
            bookTitleText.Text = book.Book_Title;
            publisherText.Text = book.Publisher;
            dateTimePicker1.Value = Convert.ToDateTime(book.Date_Of_Release);
            catagory = new Catagory();
            int index = 0;
            foreach (Catagory catagory1 in catagoryList.List)
            {
                if (catagory1.category_id == book.category_id)
                {
                    catagorycombo.SelectedIndex = index;
                    break;
                }
                else
                    index++;
            }
            
        }
        public void loadDataToObject()
        {
            book.ISBAN = ISNAPtext.Text;
            book.Book_Title = bookTitleText.Text;
            book.Book_Auther = autherText.Text;
            book.Date_Of_Release = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            book.Publisher = publisherText.Text;
            catagory = (Catagory)catagorycombo.SelectedItem;
            book.category_id = catagory.category_id;
            MessageBox.Show("..." + book.category_id);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (book != null)
            {
                MessageBox.Show("Click Clear and try agian");
            }else
            {
                if (!string.IsNullOrEmpty(autherText.Text) && !string.IsNullOrEmpty(bookTitleText.Text) && !string.IsNullOrEmpty(publisherText.Text) && !string.IsNullOrEmpty(ISNAPtext.Text))

                {
                    book = new Book();
                    loadDataToObject();
                    //book.Catagoryid = car
                    try
                    {
                        bookList.Add(book);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    if (book.getErroMessage() != null)
                        MessageBox.Show(book.getErroMessage());
                    else
                    {
                        loadDataToTable();
                        MessageBox.Show("Record Saved");
                        
                    }
                        
                }
                else
                    MessageBox.Show("Empty TextBox");

            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ISNAPtext.Text) && !string.IsNullOrWhiteSpace(autherText.Text) && !string.IsNullOrWhiteSpace(bookTitleText.Text))
            {
                if (book != null)
                {
                    loadDataToObject();
                    try
                    {
                        bookList.Update(book);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    if (book.getErroMessage() != null)
                        MessageBox.Show("ERROR: " + book.getErroMessage());
                    else
                    {
                        loadDataToTable();
                        MessageBox.Show("Record Saved");
                    }
                        
                }
                else
                    MessageBox.Show("You need to Select a Reocrd First");
            }
            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            bookItemList = new BookItemList();

            if (book != null)
            {
                if (bookItemList.CheckChildRecord("ISBAN", book.ISBAN))
                {
                    MessageBox.Show("THis Book is Related to A book item. you shoud Delete the Book items Related to this Book");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to Delete This record?", "Confirm Deleting ", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                        bookList.Delete(book);

                }
            }
            else
                MessageBox.Show("You Need to Select a Record First");
                
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            book = null;
            ISNAPtext.Text = null;
            autherText.Text = null;
            bookTitleText.Text = null;
            publisherText.Text = null;
            dateTimePicker1.Value = DateTime.Today;
            catagorycombo.SelectedIndex = 0;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(searchValueTxt.Text))
            {
                if (comboBox1.SelectedIndex == 4)
                {
                    DateTime date;
                    bool isDate = DateTime.TryParse(searchValueTxt.Text, out date);

                    if (isDate)
                    {
                        bookList.Filter(comboBox1.SelectedItem.ToString(), date.ToString("yyyy/MM/dd"));
                        //BookInformationTable.DataSource = 

                    }
                    else
                        MessageBox.Show("You Must Enter a Valild Date");
                }
                else if (comboBox1.SelectedIndex == 5)
                {
                    int id;
                    bool isInt = int.TryParse(searchValueTxt.Text, out id);

                    if (isInt)
                    {
                        bookList.Filter(comboBox1.SelectedItem.ToString(), searchValueTxt.Text);

                    }
                    else
                        MessageBox.Show("You Must Enter an Number");
                }
                else
                {
                    try { bookList.Filter(comboBox1.SelectedItem.ToString(), searchValueTxt.Text); } catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex.Message);
                    }
                }
                

            }
            else
                MessageBox.Show("TextBox is Empty");
        }

        private void clearSearchBtn_Click(object sender, EventArgs e)
        {

            loadDataToTable();
        }
    }
}
