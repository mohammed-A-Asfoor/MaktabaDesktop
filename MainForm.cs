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
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

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
        BookItem testItem;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            bookItemList = new BookItemList();
            testItem = new BookItem();
            bookItemList.getColumnName(testItem);
            bookitemcolumnNames.DataSource= bookItemList.ColumnNames;
            orderList = new OrderList();
            order = new Order();
            orderList.getColumnName(order);
            OrderColumnNames.DataSource = orderList.ColumnNames;
            order = null;
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
            orderList.Populate();
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
          
            BookPriceText.Text = bookItem.Book_price;
            isbanText.Text = bookItem.ISBAN;
            AddingDateFeild.Value = Convert.ToDateTime(bookItem.Adding_date);
            pictureBox1.ImageLocation = bookItem.Image;

            book = new Book(bookItem.ISBAN);
            bookList = new BookList();
            bookList.Populate(book);

            

            titleText.Text = book.Book_Title;
            autherText.Text = book.Book_Auther;
            PublisherText.Text = book.Publisher;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            //check if Value TextBox is Not Empty
            if (!string.IsNullOrWhiteSpace(ValueText.Text))
            {
                if (bookitemcolumnNames.SelectedIndex == 0 || bookitemcolumnNames.SelectedIndex == 1|| bookitemcolumnNames.SelectedIndex == 7)
                {
                    int num;
                    bool isInt = int.TryParse(ValueText.Text, out num);
                    if (isInt)
                        bookItemList.Filter(bookitemcolumnNames.SelectedItem.ToString(), ValueText.Text);
                    else
                        MessageBox.Show("Wrong DataType, you must enter a number");
                }else if (bookitemcolumnNames.SelectedIndex == 4)
                {
                    DateTime date;
                    bool isDate = DateTime.TryParse(ValueText.Text, out date);

                    if (isDate)
                    {
                        bookItemList.Filter(bookitemcolumnNames.SelectedItem.ToString(), ValueText.Text);

                    }
                    else
                        MessageBox.Show("You Must Enter a Valild Date");
                } else if(bookitemcolumnNames.SelectedIndex == 5){
                    Double amount;
                    bool isDouble = double.TryParse(ValueText.Text, out amount);

                    if (isDouble)
                    {
                        bookItemList.Filter(bookitemcolumnNames.SelectedItem.ToString(), ValueText.Text);

                    }
                    else
                        MessageBox.Show("Value must be a Number");
                }
              
               
            }
            else
                MessageBox.Show("Empty Feild");
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

        private void ManageCustomersBtn_Click(object sender, EventArgs e)
        {
            ManageCustomers frm = new ManageCustomers();
            frm.Show();
        }

        private void ManagediscountCodesBtn_Click(object sender, EventArgs e)
        {
            Managediscountcode frm = new Managediscountcode();
            frm.Show();
        }

        private void DeleteOrderBtn_Click(object sender, EventArgs e)
        {
            if (order != null)
            {
                Book_ListList = new Book_ListList();
                
                //checking if the customer is linked to an order or a list
                
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to Delete Order? ", "Deleting Order ", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {

                        try
                        {
                        if (Book_ListList.CheckChildRecord("Order_id", order.Order_id))
                        {
                            Book_ListList.Delete(order);
                        }
                        orderList.Delete(order);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex);
                        }
                        if (!customer.getVaild())
                        {
                            MessageBox.Show("Error: " + customer.getErroMessage());
                        }
                        else
                        {
                             MessageBox.Show("Customer Deleted");
                             loadOrdersTable();
                        }

                     }
                
      

                
            }
            else
                MessageBox.Show("you should Select an Order First");
        }

        private void EditOrderBtn_Click(object sender, EventArgs e)
        {
            if (order != null)
            {
                Manage_Orders frm = new Manage_Orders();
                Global.Order = order;
                frm.Show();
            }
            else
                MessageBox.Show("You Need to Select An order First");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchOrderBtn_Click(object sender, EventArgs e)
        {
           
            if (OrderColumnNames.SelectedIndex == 0 || OrderColumnNames.SelectedIndex == 3 || OrderColumnNames.SelectedIndex == 4)
            {
              
                int id;
                bool isInt = int.TryParse(orderSearchValueText.Text, out id);

                if (isInt)
                {
                    orderList.Filter(OrderColumnNames.SelectedItem.ToString(), orderSearchValueText.Text);

                }
                else
                    MessageBox.Show("You Must Enter an Number");
            }
            else if (OrderColumnNames.SelectedIndex == 1)
            {
                DateTime date;
                bool isDate = DateTime.TryParse(orderSearchValueText.Text, out date);

                if (isDate)
                {
                    orderList.Filter(OrderColumnNames.SelectedItem.ToString(), orderSearchValueText.Text);

                }
                else
                    MessageBox.Show("You Must Enter a Valild Date");
            }
            else if (OrderColumnNames.SelectedIndex == 2)
            {
                Double amount;
                bool isDouble = double.TryParse(orderSearchValueText.Text, out amount);

                if (isDouble)
                {
                    orderList.Filter(OrderColumnNames.SelectedItem.ToString(), orderSearchValueText.Text);

                }
                else
                    MessageBox.Show("Value must be a number");
            }
        }

        private void clearOrderSearch_Click(object sender, EventArgs e)
        {
            orderList.Populate();
            loadOrdersTable();
        }

        private void StatusBtn_Click(object sender, EventArgs e)
        {
            Status frm = new Status();
            frm.Show();
        }

        private void createPDFBtn_Click(object sender, EventArgs e)
        {


            if (order != null)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filepath = Path.GetDirectoryName(saveFileDialog1.FileName);
                    MessageBox.Show(filepath);

                    Document document = new Document(PageSize.A5, 20f, 20f, 30f, 30f);
                    PdfWriter pdfWriter = PdfWriter.GetInstance(document, new FileStream(saveFileDialog1.FileName, FileMode.Create));
                    document.Open();

                    Paragraph header = new Paragraph("MaktabaOnline");
                    header.SpacingAfter = 30f;
                    Paragraph orderData = new Paragraph("Order Number: "+order.Order_id+" /// Date:"+order.Order_date);
                    header.SpacingAfter = 10f;
                    Paragraph customerData = new Paragraph("Customer Name: " + customer.Customer_fname + " " + customer.customer_lname + "////Customer Phone: " + customer.Customer_Phone);
                    customerData.SpacingAfter = 10f;
                    Paragraph customerAddress = new Paragraph("Address: House:" + addresses.House + " /// Road:" + addresses.Street + " // Block:" + addresses.Block);
                    Paragraph customerAddress1 = new Paragraph("City:" + addresses.City + " /// Country:" + addresses.Country);
                    customerAddress1.SpacingAfter = 20f;

                    PdfPTable pdfPTable = new PdfPTable(4);
                    BookItem justofrNames = new BookItem();
                    pdfPTable.AddCell("bookItem ID");
                    pdfPTable.AddCell("ISPAN");
                    pdfPTable.AddCell("Price");
                    pdfPTable.AddCell("Quantity");
                    foreach (Book_List list in Book_ListList.List)
                    {
                        BookItem abookItem = new BookItem(list.Book_Itme_id);
                        bookItemList.Populate(abookItem);
                        pdfPTable.AddCell(abookItem.Book_Itme_id);
                        pdfPTable.AddCell(abookItem.ISBAN);
                        pdfPTable.AddCell(abookItem.Book_price);
                        pdfPTable.AddCell(abookItem.Quantity);
                    }
                    pdfPTable.SpacingAfter = 20f;

                     Paragraph price = new Paragraph("Total Prcie: "+order.Total_price);
                    price.SpacingAfter = 50f;
                    Paragraph note = new Paragraph("Note: disocunt amount is not inclouded");




                    document.Add(header);
                    document.Add(orderData);
                    document.Add(customerData);
                    document.Add(customerAddress);
                    document.Add(customerAddress1);
                    document.Add(pdfPTable);
                    document.Add(price);
                    document.Add(note);

                    document.Close();
                }
            }
            else
                MessageBox.Show("you Must Select a Row first");
            

        }
    }
}
