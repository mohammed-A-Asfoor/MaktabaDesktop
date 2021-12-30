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
    public partial class Manage_Orders : Form
    {
        Order order;
        OrderList orderList;
        Book book;
        BookList bookList;
        BookItem bookItem;
        BookItemList bookItemList;
        Book_List book_List;
        Book_ListList book_ListList;
        customer customer;
        CustomerList customerList;
        Addresses addresses;
        AddressesList addressesList;
        List<BookItem> orderBooks;
        string ISBAN;
        Double total = 0;
        Double discount = 0;
        string customerID;
        public Manage_Orders()
        {
            InitializeComponent();
        }

        private void Manage_Orders_Load(object sender, EventArgs e)
        {
            //creating objects
            customerList = new CustomerList();
            bookList = new BookList();
            bookItemList = new BookItemList();
            book_ListList = new Book_ListList();
            orderBooks = new List<BookItem>();
            book = new Book();
            customer = new customer();
            //getting the coumn manes for search
            bookList.getColumnName(book);
            customerList.getColumnName(customer);

            book = null;
            customer = null;

            customerColumnNames.DataSource = customerList.ColumnNames;
            booksColumnNames.DataSource = bookList.ColumnNames;
            

            //loading tables 
            loadCustomerTable();
            loadBooksTable();
            ISBAN = BooksTable.CurrentRow.Cells[0].Value.ToString();
            bookItemList.Filter("ISBAN", ISBAN);
            BookItemTable.DataSource = bookItemList.DataTable;

            if (Global.Order != null)
            {
                order = Global.Order;

                //loading customer information 
                customerID = order.CustomerID;
                customer = new customer(customerID);
                customerList.Populate(customer);
                loadCustomerData();
               
                //looading Book List
                book_ListList = new Book_ListList();
                book_ListList.Filter("Order_id", order.Order_id);
                orderBooks.Clear();
                book_List = new Book_List();
                foreach(Book_List book_List1 in book_ListList.List)
                {
                    bookItem = new BookItem(book_List1.Book_Itme_id);
                    bookItemList.Populate(bookItem);
                    orderBooks.Add(bookItem);
                }
                
                loadorderBooks();
                loadTotalPrice();
            }
        }
        public void loadCustomerTable() {
            
            customerList.Populate();
            CustomerTable.DataSource = customerList.DataTable;
        }
        public void loadBooksTable()
        {
           
            bookList.Populate();
            BooksTable.DataSource = bookList.DataTable;
        }
        public void loadBookItemTable()
        {
            bookItemList.Populate();
            
        }
        public void loadorderBooks()
        {
            listBox1.Items.Clear();
            foreach (BookItem bookItem1 in orderBooks)
            {
                listBox1.Items.Add(bookItem1.Book_Itme_id + " // " + bookItem1.ISBAN + " // "+bookItem1.Quantity);
            }
        }

        private void BooksTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (BooksTable.RowCount != 0)
                {
                    string ISBN = BooksTable.CurrentRow.Cells[0].Value.ToString();

                    bookItemList.Filter("ISBAN", ISBN);
                }
                else
                    MessageBox.Show("No data to display");
            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BookItemTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (BookItemTable.RowCount != 0)
                {
                    //getting the bookitem id 
                    string bookitemID = BookItemTable.CurrentRow.Cells[0].Value.ToString();
                    bookItem = new BookItem(bookitemID);
                    //creating and populating the Book item Object
                    loadIntoBookInfo();
                }
                else
                    MessageBox.Show("No data to Display");
            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void loadIntoBookInfo()
        {
           
            bookItemList.Populate(bookItem);
            //creating and populating the Book object
            book = new Book(bookItem.ISBAN);
            bookList.Populate(book);
            //setting textBoxs 
            isbanText.Text = bookItem.ISBAN;
            PublisherText.Text = book.Publisher;
            titleText.Text = book.Book_Title;
            autherText.Text = book.Book_Auther;
            ConditionText.Text = bookItem.Condition;
            BookPriceText.Text = bookItem.Book_price;
            //to make sure that the number of orderd books is not more then the stock
            int maxnum = Convert.ToInt32(bookItem.Quantity);
            numericUpDown1.Maximum = maxnum;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void loadTotalPrice()
        {
            total = 0;
            foreach(BookItem item in orderBooks)
            {
                total = total + (Convert.ToDouble(item.Book_price)*Convert.ToInt32(item.Quantity));
            }
            if (discount > total)
            {
                discount = total;
            }
            else if (discount < 0)
                discount = 0;

            totalPriceText.Text = (total-discount).ToString() ;
        }

        private void AddBookItemBtn_Click(object sender, EventArgs e)
        {
            if (bookItem != null)
            {
                bool selectedBefore = false;
                foreach (BookItem bookItem2 in orderBooks)
                {
                    if (bookItem.Book_Itme_id == bookItem2.Book_Itme_id)
                    {

                        selectedBefore = true;
                        break;
                    }

                }
                if (!selectedBefore)
                {
                    bookItem.Quantity = numericUpDown1.Value.ToString();
                    orderBooks.Add(bookItem);
                    loadorderBooks();
                    loadTotalPrice();
                    
                }
                else
                    MessageBox.Show("You Selected This Book Before");
            }

            else
                MessageBox.Show("you Need to Select a book first");

          
        }
        

        private void DeleteBookFromOrder_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("You Need to Select an Item First");
            }
            else
            {
                orderBooks.RemoveAt(listBox1.SelectedIndex);
                loadorderBooks();
                if (orderBooks.Count == 0)
                    total = 0;
                discount = 0;
                discountText.Text = "";
                loadTotalPrice();
            }
            
        }

        private void clearOrderBoks_Click(object sender, EventArgs e)
        {
            orderBooks.Clear();
            listBox1.Items.Clear();
            discount = 0;
            discountText.Text = "";
            loadTotalPrice();
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomerTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (CustomerTable.RowCount != 0)
                {
                    //getting the CustomerID form the Table
                    customerID = CustomerTable.CurrentRow.Cells[0].Value.ToString();
                    //ceating the customer object
                    customer = new customer(customerID);
                    customerList.Populate(customer);
                    loadCustomerData();
                }
                else
                    MessageBox.Show("No Data to show");
            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

         
        }
        public void loadCustomerData()
        {
            listbox2.DataSource = null;
            listbox2.Items.Clear();
            //setting textboxs values
            CustomerNameText.Text = customer.Customer_fname + " " + customer.customer_lname;
            customerEmailText.Text = customer.Customer_Email;
            custimerPhoneText.Text = customer.Customer_Phone;

            //getting a the lsit of address for the seclected customer

            addressesList = new AddressesList();
            addressesList.Filter("CustomerID", customer.customerID);
                
            if (addressesList.List.Count != 0)
            {
                listbox2.DataSource = addressesList.List;
                listbox2.SelectedIndex = 0;
            }
            else
            {
                addresses = null;
                MessageBox.Show("You Must Add an address to this Customer");
            }
               
        }

        private void listbox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbox2.DataSource!=null)
            {
                addresses = (Addresses)listbox2.SelectedItem;
                
            }
           
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //validation
            if (bookItem != null && book != null && orderBooks.Count != 0 )
            {
                if (customer != null && addresses != null)
                {

                    
                        //setting varablies of customer object
                        
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to Save this Order new Order?", "Saving Order information", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {

                        try
                        {
                            orderList = new OrderList();

                            //checking if we are adding an order or deleteing one
                            if (Global.Order == null)
                            {
                                order = new Order();
                                //load Order Data
                                order.CustomerID = customer.customerID;
                                order.Address_id = addresses.Address_id;
                                order.Order_date = DateTime.Now.ToString("yyyy/MM/dd");
                                order.Total_price = totalPriceText.Text;
                                orderList.Add(order);
                                order.Order_id = orderList.MaxID().ToString();

                                //adding the books 
                                foreach (BookItem bookItem1 in orderBooks)
                                {
                                    book_List = new Book_List(order.Order_id, bookItem1.Book_Itme_id);
                                    book_List.Quantity = bookItem1.Quantity;

                                    book_ListList.Add(book_List);
                                    bookItem = new BookItem(bookItem1.Book_Itme_id);
                                    bookItemList.Populate(bookItem);
                                    //editing the stock
                                    bookItem.Quantity = (Convert.ToInt32(bookItem.Quantity) - Convert.ToInt32(bookItem1.Quantity)).ToString();
                                    //editing date format
                                    DateTime date;
                                    bool isDate = DateTime.TryParse(bookItem.Adding_date, out date);
                                    if (isDate)
                                    {
                                        bookItem.Adding_date = date.ToString("yyyy/MM/dd");
                                        bookItemList.Update(bookItem);
                                        
                                    }
                                    else
                                        MessageBox.Show("Something went wrong, Delete the order and try again");
                                   
                                   
                                }

                            }
                            else
                            {
                                
                                //load Order Data
                                order.CustomerID = customer.customerID;
                                order.Address_id = addresses.Address_id;
                                order.Order_date = DateTime.Now.ToString("yyyy/MM/dd");
                                order.Total_price = totalPriceText.Text;

                                orderList.Update(order);

                                //deleting previos Books
                                book_ListList.Delete(order);
                                //adding the books 
                                foreach (BookItem bookItem1 in orderBooks)
                                {
                                    //creating the object and adding data to the database
                                    book_List = new Book_List(order.Order_id, bookItem1.Book_Itme_id);
                                    book_List.Quantity = bookItem1.Quantity;
                                    book_ListList.Add(book_List);

                                    //editing the stock
                                    bookItem = new BookItem(bookItem1.Book_Itme_id);
                                    bookItemList.Populate(bookItem);
                                    //for edit. we check if the stock is 0 
                                    if (bookItem.Quantity != "0")
                                    {
                                        bookItem.Quantity = (Convert.ToInt32(bookItem.Quantity) - Convert.ToInt32(bookItem1.Quantity)).ToString();
                                        //editing date format
                                        DateTime date;
                                        bool isDate = DateTime.TryParse(bookItem.Adding_date, out date);
                                        if (isDate)
                                        {
                                            bookItem.Adding_date = date.ToString("yyyy/MM/dd");
                                            bookItemList.Update(bookItem);

                                        }
                                        else
                                            MessageBox.Show("Something went wrong, Delete the order and try again");
                                    }
                                    
                                    


                                }

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex);
                        }
                        if (!order.getVaild())
                        {
                            MessageBox.Show("Error: " + order.getErroMessage());
                        }
                        else if (!book_List.getVaild())
                            MessageBox.Show("Error: " + order.getErroMessage());
                        else
                        {
                            MessageBox.Show("record Has been  Saved ");
                            this.Close();
                        }
                        }

                    
                }
                else
                    MessageBox.Show("You Must Selece a customer and an address");
            }
            else
                MessageBox.Show("Something is Empty");
        }

        private void discountText_TextChanged(object sender, EventArgs e)
        {
            if (discountText.Text == "")
            {
                discount = 0;
                loadTotalPrice();
            }
               
            else
            {
                bool IsDouble = double.TryParse(discountText.Text, out discount);

                if (IsDouble)
                {
                    loadTotalPrice();
                }
                else
                {
                    MessageBox.Show("You Must Only Enter Numbers in the Discount Textbox");
                    discount = 0;
                    loadTotalPrice();
                }
            }
        }

        private void searchCustomerBtn_Click(object sender, EventArgs e)
        {
            //check if Value TextBox is Not Empty
            if (!string.IsNullOrWhiteSpace(customerSearchValue.Text))
            {
                if (customerColumnNames.SelectedIndex == 0 || customerColumnNames.SelectedIndex == 1 || customerColumnNames.SelectedIndex == 2)
                {
                    int num;
                    bool isInt = int.TryParse(customerSearchValue.Text, out num);
                    if (isInt)
                        customerList.Filter(customerColumnNames.SelectedItem.ToString(), customerSearchValue.Text);
                    else
                        MessageBox.Show("Wrong DataType, you must enter a number");
                }
                else if (customerColumnNames.SelectedIndex == 3)
                {
                    DateTime date;
                    bool isDate = DateTime.TryParse(customerSearchValue.Text, out date);

                    if (isDate)
                    {
                        customerList.Filter(customerColumnNames.SelectedItem.ToString(), customerSearchValue.Text);

                    }
                    else
                        MessageBox.Show("You Must Enter a Valild Date");
                }else
                    customerList.Filter(customerColumnNames.SelectedItem.ToString(), customerSearchValue.Text);



            }
            else
                MessageBox.Show("Empty Feild");
        }

        private void searchBookBtn_Click(object sender, EventArgs e)
        {
            //check if Value TextBox is Not Empty
            if (!string.IsNullOrWhiteSpace(bookSearchValueText.Text))
            {
                if (booksColumnNames.SelectedIndex == 6)
                {
                    int num;
                    bool isInt = int.TryParse(bookSearchValueText.Text, out num);
                    if (isInt)
                        bookList.Filter(booksColumnNames.SelectedItem.ToString(), bookSearchValueText.Text);
                    else
                        MessageBox.Show("Wrong DataType, you must enter a number");
                }
                else if (booksColumnNames.SelectedIndex == 4)
                {
                    DateTime date;
                    bool isDate = DateTime.TryParse(bookSearchValueText.Text, out date);

                    if (isDate)
                    {
                        bookList.Filter(booksColumnNames.SelectedItem.ToString(), date.ToString("yyyy/MM/dd"));

                    }
                    else
                        MessageBox.Show("You Must Enter a Valild Date");
                }else
                    bookList.Filter(booksColumnNames.SelectedItem.ToString(), bookSearchValueText.Text);



            }
            else
                MessageBox.Show("Empty Feild");
        }

        private void clearcustomerBtn_Click(object sender, EventArgs e)
        {
            customerList.Populate();
            loadCustomerTable();
        }

        private void clearbookBtn_Click(object sender, EventArgs e)
        {
            bookList.Populate();
            loadBooksTable();
        }
    }
}
