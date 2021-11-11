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
    public partial class MainForm : Form
    {
        BookItem bookItem;
        BookItemList bookItemList;
        Book book;
        BookList bookList;
        string bookItemID;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            bookItemList = new BookItemList();
            bookItemList.Populate();

            BooksItemsTable.DataSource = bookItemList.DataTable;
        }
        
        private void BooksItemsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bookItemID = BooksItemsTable.CurrentRow.Cells[0].Value.ToString();
            bookItem = new BookItem(bookItemID);
            bookItemList.Populate(bookItem);
            LoadDataIntoBookItem();
        }
        public void LoadDataIntoBookItem()
        {
            QuantityText.Text = bookItem.Quantity;
            ConditionText.Text = bookItem.Condition;
            PublisherText.Text = bookItem.Publisher;
            BookPriceText.Text = bookItem.Book_price;
            isbanText.Text = bookItem.ISBAN;
            AddingDateFeild.Value = Convert.ToDateTime(bookItem.Adding_date);

            book = new Book(bookItem.ISBAN);
            bookList = new BookList();
            bookList.Populate(book);

            titleText.Text = book.Book_Title;
            autherText.Text = book.Book_Auther;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
           bookItemList.Filter(FiledText.Text, ValueText.Text);
           BooksItemsTable.DataSource = bookItemList.DataTable;
            //isbanText.Text= 
        }
    }
}
