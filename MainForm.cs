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
        OrderList orderList;
        Order order;
        AddressesList addressesList;
        Addresses addresses;
        CustomerList customerList;
        customer customer;
        Book_ListList Book_ListList;
        Book_List book_Listl;
        string bookItemID;
        string orderID;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            bookItemList = new BookItemList();
            orderList = new OrderList();

            bookItemList.Populate();
            orderList.Populate();
            
            BooksItemsTable.DataSource = bookItemList.DataTable;
            OrdersTable.DataSource = orderList.DataTable;
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

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void House_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void OrdersTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            orderID = OrdersTable.CurrentRow.Cells[0].Value.ToString();
            order = new Order(orderID);
            orderList.Populate(order);

            OrderIDText.Text = order.Order_id;
            TotalPriceText.Text = order.Total_price;
            orderDateText.Value = Convert.ToDateTime(order.Order_date);

            addresses = new Addresses(order.Address_id);
            addressesList = new AddressesList();
            addressesList.Populate(addresses);

            streetText.Text = addresses.Street;
            blockText.Text = addresses.Block;
            houseText.Text = addresses.House;
            CityText.Text = addresses.City;
            countryText.Text = addresses.Country;

            customer = new customer(order.CustomerID);
            customerList = new CustomerList();
            customerList.Populate(customer);

            customerNameText.Text = customer.CustomerFname + " " + customer.CustomerLname;
            loadBookList();
           

        }
        public void loadBookList() {
            Book_ListList = new Book_ListList();
            Book_ListList.Filter("Order_id", order.Order_id);


            bookList = new BookList();
            bookListforOrder.Items.Clear();
            BookItem bookItem1;

            foreach (Book_List abook_List in Book_ListList.List)
            {

                bookItem1 = new BookItem(abook_List.Book_Itme_id);
                bookItemList.Populate(bookItem1);
                Book bookinfo = new Book(bookItem1.ISBAN);
                bookList.Populate(bookinfo);

                bookListforOrder.Items.Add("ISBAN: " + bookItem1.ISBAN + "     Book Title: " + bookinfo.Book_Title + "   book Price: " + bookItem1.Book_price);
            }

        }

        private void ClearTableBtn_Click(object sender, EventArgs e)
        {
            bookItemList.Populate();
            BooksItemsTable.DataSource = bookItemList.DataTable;
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void CityText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void TotalPriceText_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {

            Global.BookItem = null;
            ManageBookItems frm = new ManageBookItems();
            frm.Show();
        }

        private void EditBookItemBtn_Click(object sender, EventArgs e)
        {
            if (bookItem != null)
            {
                Global.BookItem = bookItem;
                ManageBookItems frm = new ManageBookItems();
                frm.Show();
            }
            else
            {
                MessageBox.Show("You need to Select a Book Item from the List");
            }
        }
    }
}
