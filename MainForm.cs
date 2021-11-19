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
        Book_List book_List;
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

            loadBookitemTable();
            loadOrdersTable();

           
            
        }
        public void loadBookitemTable()
        {
            bookItemList.Populate();
            BooksItemsTable.DataSource = bookItemList.DataTable;
        }
        public void loadOrdersTable()
        {
            OrdersTable.DataSource = orderList.DataTable;
            orderList.Populate();
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
           // isbanText.Text = bookItemList.PopulateTest(bookItem);
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

            customerNameText.Text = customer.Customer_fname + " " + customer.customer_lname;
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

        private void refreashBtn_Click(object sender, EventArgs e)
        {
            loadBookitemTable();
        }

        private void RefreashBookItemBtn_Click(object sender, EventArgs e)
        {
            loadOrdersTable();
        }

        private void DeleteBookItemBtn_Click(object sender, EventArgs e)
        {
            if (bookItem == null)
                MessageBox.Show("You Need to Select a Record First");
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to Delete This record?", "Confirm Deleting ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                  //  textBox1.Text = bookItemList.PopulateTest("Book_Itme_id", bookItem.Book_Itme_id);
                    Book_ListList = new Book_ListList();
                    if(Book_ListList.CheckChildRecord("Book_Itme_id", bookItem.Book_Itme_id))
                    {
                        MessageBox.Show("this book item is used in an Order");
                    }else
                    bookItemList.Delete(bookItem);
                    
                    loadBookitemTable();
                } 
            }
        }

        private void AddNewOrder_Click(object sender, EventArgs e)
        {
            Global.Order = null;
            Manage_Orders frm = new Manage_Orders();
            frm.Show();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void PublisherText_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuantityText_TextChanged(object sender, EventArgs e)
        {

        }

        private void booksBtn_Click(object sender, EventArgs e)
        {
            BookInformationForm frm = new BookInformationForm();
            frm.Show();
        }

        private void catagoriesBtn_Click(object sender, EventArgs e)
        {
            ManageCatagories frm = new ManageCatagories();
            frm.Show();
        }

        private void AdminsBtn_Click(object sender, EventArgs e)
        {
            Manage_Admins frm = new Manage_Admins();
            frm.Show();
        }
    }
}
