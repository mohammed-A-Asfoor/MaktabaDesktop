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
        customer customer;
        CustomerList customerList;
        Addresses addresses;
        AddressesList addressesList;
        string ISBAN;
        public Manage_Orders()
        {
            InitializeComponent();
        }

        private void Manage_Orders_Load(object sender, EventArgs e)
        {
            customerList = new CustomerList();
            bookList = new BookList();
            bookItemList = new BookItemList();
            loadCustomerTable();
            loadBooksTable();
            ISBAN = BooksTable.CurrentRow.Cells[0].Value.ToString();
            bookItemList.Filter("ISBAN", ISBAN);
            BookItemTable.DataSource = bookItemList.DataTable;
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
    }
}
