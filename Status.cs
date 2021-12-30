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
            

        }
        private void Status_Load(object sender, EventArgs e)
        {
            if (Global.admin.Admin_ID != "2")
            {
                MessageBox.Show("Only super Admin is Allowed");
                this.Close();
            }
            //adding periods
            AdminSelect.Items.Add("All");
            AdminSelect.Items.Add("One Day");
            AdminSelect.Items.Add("One Week");
            AdminSelect.Items.Add("One Month");
            AdminSelect.Items.Add("One Year");
            //creating objects
            orderList = new OrderList();
            bookItemList = new BookItemList();
            customerList = new CustomerList();
            //to get the total number of books
            totalBooks.Text = bookItemList.totalCount("Book_Itme_id").ToString();
            //to get the total numbe of customers
            totalCustomers.Text = customerList.totalCount("CustomerID").ToString();
            //to get books in stock
            numberOfBooks.Text = bookItemList.totalCountGraterThen("Book_Itme_id", "quantity", "0").ToString();
            
        }

        private void AdminSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            //checking admin choes and using the righ method
            if (AdminSelect.SelectedIndex == 0)
            {
                try
                {
                    OrderNumbers.Text = orderList.totalCount("Order_id").ToString();
                    customerNumberText.Text = orderList.totalCountSpecial("CustomerID").ToString();
                    earningText.Text = orderList.TotalValue("Total_price").ToString();
                    orderList = new OrderList();
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
                orderList = new OrderList();
                OrderNumbers.Text = orderList.totalCount("Order_id", "Order_date",dateTimePicker1.Value.ToString("yyyy/MM/dd")).ToString();
                customerNumberText.Text = orderList.totalCountSpecial("CustomerID", "Order_date", dateTimePicker1.Value.ToString("yyyy/MM/dd")).ToString();
                earningText.Text = orderList.TotalValue("Total_price", "Order_date", dateTimePicker1.Value.ToString("yyyy/MM/dd")).ToString();

                orderList.Filter("Order_date", dateTimePicker1.Value.ToString("yyyy/MM/dd"));
                dataGridView1.DataSource = orderList.DataTable;
            }
            else if (AdminSelect.SelectedIndex == 2)
            {
                orderList = new OrderList();
                OrderNumbers.Text =       orderList.totalCountDate("Order_id", "Order_date", dateTimePicker1.Value.ToString("yyyy/MM/dd"), "Order_date", dateTimePicker1.Value.AddDays(7).ToString("yyyy/MM/dd")).ToString();
                customerNumberText.Text = orderList.totalCountSpecial("CustomerID", "Order_date", dateTimePicker1.Value.ToString("yyyy/MM/dd"), "Order_date", dateTimePicker1.Value.AddDays(7).ToString("yyyy/MM/dd")).ToString();
                earningText.Text = orderList.TotalValue("Total_price", "Order_date", dateTimePicker1.Value.ToString("yyyy/MM/dd"), "Order_date", dateTimePicker1.Value.AddDays(7).ToString("yyyy/MM/dd")).ToString();
                orderList.FilterRange("Order_date", dateTimePicker1.Value.ToString("yyyy/MM/dd"), "Order_date", dateTimePicker1.Value.AddDays(7).ToString("yyyy/MM/dd"));
                dataGridView1.DataSource = orderList.DataTable;
            }
            else if (AdminSelect.SelectedIndex == 3)
            {
                orderList = new OrderList();
                OrderNumbers.Text = orderList.totalCountDate("Order_id", "Order_date", dateTimePicker1.Value.ToString("yyyy/MM/dd"), "Order_date", dateTimePicker1.Value.AddMonths(1).ToString("yyyy/MM/dd")).ToString();
                customerNumberText.Text = orderList.totalCountSpecial("CustomerID", "Order_date", dateTimePicker1.Value.ToString("yyyy/MM/dd"), "Order_date", dateTimePicker1.Value.AddMonths(1).ToString("yyyy/MM/dd")).ToString();
                earningText.Text = orderList.TotalValue("Total_price", "Order_date", dateTimePicker1.Value.ToString("yyyy/MM/dd"), "Order_date", dateTimePicker1.Value.AddMonths(1).ToString("yyyy/MM/dd")).ToString();
                orderList.FilterRange("Order_date", dateTimePicker1.Value.ToString("yyyy/MM/dd"), "Order_date", dateTimePicker1.Value.AddMonths(1).ToString("yyyy/MM/dd"));
                dataGridView1.DataSource = orderList.DataTable;
               //customerNumberText.Text= orderList.test("CustomerID", "Order_date", dateTimePicker1.Value.ToString("yyyy/MM/dd"), "Order_date", dateTimePicker1.Value.AddMonths(1).ToString("yyyy/MM/dd"));
            }
            else if (AdminSelect.SelectedIndex == 4)
            {
                orderList = new OrderList();
                OrderNumbers.Text =       orderList.totalCountDate("Order_id", "Order_date",  dateTimePicker1.Value.ToString("yyyy/MM/dd"), "Order_date", dateTimePicker1.Value.AddYears(1).ToString("yyyy/MM/dd")).ToString();
                customerNumberText.Text = orderList.totalCountSpecial("CustomerID", "Order_date", dateTimePicker1.Value.ToString("yyyy/MM/dd"), "Order_date", dateTimePicker1.Value.AddYears(1).ToString("yyyy/MM/dd")).ToString();
                earningText.Text = orderList.TotalValue("Total_price", "Order_date", dateTimePicker1.Value.ToString("yyyy/MM/dd"), "Order_date", dateTimePicker1.Value.AddYears(1).ToString("yyyy/MM/dd")).ToString();
                orderList.FilterRange("Order_date", dateTimePicker1.Value.ToString("yyyy/MM/dd"), "Order_date", dateTimePicker1.Value.AddYears(1).ToString("yyyy/MM/dd"));
                dataGridView1.DataSource = orderList.DataTable;
            }

        }

        
    }
}
