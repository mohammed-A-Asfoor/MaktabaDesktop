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
        BookItem bookItem;
        BookItemList bookItemList;
        Book book;
        BookList bookList;
        public ManageBookItems()
        {
            InitializeComponent();
        }

        private void ManageBookItems_Load(object sender, EventArgs e)
        {
            //creating book and book lsit object 
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

                //seting text feilds for Book infomration
                ISBANText.Text = bookItem.ISBAN;
                titleText.Text = book.Book_Title;
                autherText.Text = book.Book_Auther;
                dateTimePicker1.Value = Convert.ToDateTime(book.Date_Of_Release);
                catagoryText.Text = book.category_id;

                //seting infomration for BookItem
                publisherText.Text = bookItem.Publisher;
                quantitiyNum.Value = Convert.ToInt16(bookItem.Quantity);
                 comboBox1.Items.
            }
        }
        public void  loadBooksTable()
        {
            BooksTable.DataSource = bookList.DataTable ;
        }
    }
}
