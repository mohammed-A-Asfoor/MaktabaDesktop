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
    
    public partial class Status : Form
    {
        OrderList orderList;
        BookItemList bookItemList;
        CustomerList customerList;
        public Status()
        {
            InitializeComponent();
            AdminSelect.Items.Add("All");
            AdminSelect.Items.Add("One Day");
            AdminSelect.Items.Add("One Week");
            AdminSelect.Items.Add("One Month");
            AdminSelect.Items.Add("One Year");
            orderList = new OrderList();
            bookItemList = new BookItemList();
            customerList = new CustomerList();
            //to get the total number of books
            totalBooks.Text = bookItemList.totalCount("Book_Itme_id").ToString();
            //to get the total numbe of customers
            totalCustomers.Text = customerList.totalCount("CustomerID").ToString();
            //to get books in stock
            numberOfBooks.Text= bookItemList.totalCountGraterThen("Book_Itme_id", "quantity", "0").ToString();

        }

        private void AdminSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AdminSelect.SelectedIndex == 0)
            {
                try
                {
                    OrderNumbers.Text = orderList.totalCount("Order_id").ToString();
                    customerNumberText.Text = orderList.totalCountSpecial("CustomerID").ToString();
                    orderList.Populate();
                    dataGridView1.DataSource = orderList.DataTable;


                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
                
            else if (AdminSelect.SelectedIndex == 1)
            {
                OrderNumbers.Text = orderList.totalCount("Order_id", "Order_date",dateTimePicker1.Value.ToString("yyyy/MM/dd")).ToString();
                customerNumberText.Text = orderList.totalCount("CustomerID", "Order_date", dateTimePicker1.Value.ToString("yyyy/MM/dd")).ToString();
                orderList.Filter("Order_date", dateTimePicker1.Value.ToString("yyyy/MM/dd"));
                dataGridView1.DataSource = orderList.DataTable;
            }
            else if (AdminSelect.SelectedIndex == 2)
            {
                OrderNumbers.Text =       orderList.totalCount("Order_id", "Order_date", dateTimePicker1.Value.ToString("yyyy/MM/dd"), "Order_date", dateTimePicker1.Value.AddDays(7).ToString("yyyy/MM/dd")).ToString();
                customerNumberText.Text = orderList.totalCount("CustomerID", "Order_date", dateTimePicker1.Value.ToString("yyyy/MM/dd"), "Order_date", dateTimePicker1.Value.AddDays(7).ToString("yyyy/MM/dd")).ToString();
                orderList.FilterRange("Order_date", dateTimePicker1.Value.ToString("yyyy/MM/dd"), "Order_date", dateTimePicker1.Value.AddDays(7).ToString("yyyy/MM/dd"));
                dataGridView1.DataSource = orderList.DataTable;
            }
            else if (AdminSelect.SelectedIndex == 3)
            {
                OrderNumbers.Text = orderList.totalCount("Order_id", "Order_date", dateTimePicker1.Value.ToString("yyyy/MM/dd"), "Order_date", dateTimePicker1.Value.AddMonths(1).ToString("yyyy/MM/dd")).ToString();
                customerNumberText.Text = orderList.totalCount("CustomerID", "Order_date", dateTimePicker1.Value.ToString("yyyy/MM/dd"), "Order_date", dateTimePicker1.Value.AddMonths(1).ToString("yyyy/MM/dd")).ToString();
                orderList.FilterRange("Order_date", dateTimePicker1.Value.ToString("yyyy/MM/dd"), "Order_date", dateTimePicker1.Value.AddMonths(1).ToString("yyyy/MM/dd"));
                dataGridView1.DataSource = orderList.DataTable;
            }
            else if (AdminSelect.SelectedIndex == 4)
            {
                OrderNumbers.Text =       orderList.totalCount("Order_id", "Order_date",  dateTimePicker1.Value.ToString("yyyy/MM/dd"), "Order_date", dateTimePicker1.Value.AddYears(1).ToString("yyyy/MM/dd")).ToString();
                customerNumberText.Text = orderList.totalCount("CustomerID", "Order_date", dateTimePicker1.Value.ToString("yyyy/MM/dd"), "Order_date", dateTimePicker1.Value.AddYears(1).ToString("yyyy/MM/dd")).ToString();
                orderList.FilterRange("Order_date", dateTimePicker1.Value.ToString("yyyy/MM/dd"), "Order_date", dateTimePicker1.Value.AddYears(1).ToString("yyyy/MM/dd"));
                dataGridView1.DataSource = orderList.DataTable;
            }

        }
    }
}
