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

            //creating the catagory list
            catagoryList = new CatagoryList();
            catagoryList.Populate();
            catagorycombo.DataSource = catagoryList.List;

            loadDataToTable();
        } //to load data and refresh table after editing it
        public void loadDataToTable()
        {
            bookList.Populate();

            BookInformationTable.DataSource = bookList.DataTable;
        }

        private void BookInformationTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ISPAN = BookInformationTable.CurrentRow.Cells[0].Value.ToString();
            book = new Book(ISPAN);
            
             bookList.Populate(book);
            loadDataToTextfields();
            
        }
       
        public void loadDataToTextfields()
        {
            ISNAPtext.Text = book.ISBAN;
            autherText.Text = book.Book_Auther;
            bookTitleText.Text = book.Book_Title;
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
                book = new Book();
                loadDataToObject();
                //book.Catagoryid = car
                try
                {
                    bookList.Add(book);
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                 }
                if(book.getErroMessage()!=null)
                    MessageBox.Show(book.getErroMessage());
                else
                    loadDataToTable();

            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ISNAPtext.Text) || !string.IsNullOrWhiteSpace(autherText.Text) || !string.IsNullOrWhiteSpace(bookTitleText.Text))
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
                        loadDataToTable();
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
            dateTimePicker1.Value = DateTime.Today;
            catagorycombo.SelectedIndex = 0;
        }
    }
}
