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
    public partial class ManageCustomers : Form
    {
        CustomerList customerList;
        customer customer;
        AddressesList addressesList;
        Addresses addresses;
        OrderList orderList;
        public ManageCustomers()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            customerList = new CustomerList();
            addressesList = new AddressesList();
            orderList = new OrderList();
            loadCustomerTable();

            comboBox1.DataSource = customerList.ColumnNames;
        }

        private void customersTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //making sure that Address section is cleared
            AddresssTextList.Items.Clear();
            addresses = null;
            streetText.Text = null;
            blockText.Text = null;
            HouseText.Text = null;
            cityText.Text = null;
            countryText.Text = null;
            //getting Customer ID
            string customerID = customersTable.CurrentRow.Cells[0].Value.ToString();
            customer = new customer(customerID);

            //creating customer Object
            customerList.Populate(customer);

            //filling the text boxes
            customerFNameText.Text = customer.Customer_fname;
            customerLNameText.Text = customer.customer_lname;
            CustomerPhoneText.Text = customer.Customer_Phone;
            CustomerEmail.Text = customer.Customer_Email;
            CustomerPasswordText.Text = customer.Customer_password;
            customerbirthDatePicker.Value = Convert.ToDateTime(customer.Customer_DOB);
            loadAddress();
        }
        public void loadAddress()
        {
            addressesList.Filter("CustomerID", customer.customerID);

            AddresssTextList.Items.Clear();
            foreach (Addresses addresses1 in addressesList.List)
            {
              
                AddresssTextList.Items.Add(addresses1.Address_id + " /House:" + addresses1.House+ " /City:" + addresses1.City + " /country:" + addresses1.Country);
            }

        }

        private void AddresssTextList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //make an itme as one string 
            string record = AddresssTextList.SelectedItem.ToString();
            //geting the address id
            string addresssID = record.Substring(0, record.IndexOf(" "));
            //creating the address object using the id
            addresses = new Addresses(addresssID);
            addressesList.Populate(addresses);

            HouseText.Text = addresses.House;
            streetText.Text = addresses.Street;
            blockText.Text = addresses.Block;
            cityText.Text = addresses.City;
            countryText.Text = addresses.Country;


            
        }
        public void loadDataInCustomer()
        {
            
            customer.Customer_fname = customerFNameText.Text;
            customer.customer_lname = customerLNameText.Text;
            customer.Customer_DOB = customerbirthDatePicker.Value.ToString("yyyy/MM/dd");
            customer.Customer_Phone = CustomerPhoneText.Text;
            customer.Customer_Email = CustomerEmail.Text;
            customer.Customer_password = CustomerPasswordText.Text;

        }
        public void loadCustomerTable()
        {
            customerList.Populate();
            customersTable.DataSource = customerList.DataTable;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (customer != null)
            {
                MessageBox.Show("you need to click Clear and try agian");
            }
            else
            {
                if (string.IsNullOrEmpty(customerFNameText.Text) || string.IsNullOrEmpty(customerLNameText.Text) || string.IsNullOrEmpty(CustomerPhoneText.Text) || string.IsNullOrEmpty(CustomerEmail.Text) || string.IsNullOrEmpty(CustomerPasswordText.Text))
                {
                    MessageBox.Show("Empty feild");
                }
                else
                {
                    customer = new customer();
                    //setting varablies of customer object
                    loadDataInCustomer();
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to Add a new Record?", "Adding new Customer", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        loadDataInCustomer();
                        try
                        {
                            customerList.Add(customer);
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
                            MessageBox.Show("Customer Added to the Database");
                            loadCustomerTable();
                        }
                    }

                }
            }
                
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (customer != null)
            {
                if (string.IsNullOrEmpty(customerFNameText.Text) || string.IsNullOrEmpty(customerLNameText.Text) || string.IsNullOrEmpty(CustomerPhoneText.Text) || string.IsNullOrEmpty(CustomerEmail.Text) || string.IsNullOrEmpty(CustomerPasswordText.Text))
                {
                    MessageBox.Show("Empty feild");
                }
                else
                {
                    //setting varablies of customer object
                    loadDataInCustomer();
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to Edit customer Information?", "Editing Customer Information", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        
                        try
                        {
                            customerList.Update(customer);
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
                            MessageBox.Show("Customer Information Updated");
                            loadCustomerTable();
                        }
                            
                    }

                }
            }
            else
                MessageBox.Show("you should Select a Record First");
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            customer = null;
            AddresssTextList.Items.Clear();
            addresses = null;
            streetText.Text = null;
            blockText.Text = null;
            HouseText.Text = null;
            cityText.Text = null;
            countryText.Text=null;
            customerFNameText.Text = null;
            customerLNameText.Text = null;
            CustomerPhoneText.Text = null;
            CustomerEmail.Text = null;
            CustomerPasswordText.Text = null;
            customerbirthDatePicker.Value = DateTime.Now;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (customer != null)
            {
                if (string.IsNullOrEmpty(customerFNameText.Text) || string.IsNullOrEmpty(customerLNameText.Text) || string.IsNullOrEmpty(CustomerPhoneText.Text) || string.IsNullOrEmpty(CustomerEmail.Text) || string.IsNullOrEmpty(CustomerPasswordText.Text))
                {
                    MessageBox.Show("Empty feild");
                }
                else
                {
                    //checking if the customer is linked to an order or a list
                    if (!orderList.CheckChildRecord("CustomerID", customer.customerID) || !addressesList.CheckChildRecord("CustomerID", customer.customerID))
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to Edit customer Information?", "Editing Customer Information", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {

                            try
                            {
                                customerList.Delete(customer);
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
                                loadCustomerTable();
                            }

                        }
                    }
                    else
                        MessageBox.Show("this Customer have Orders or addresses. you need to Delete them First");
                    

                }
            }
            else
                MessageBox.Show("you should Select a Record First");
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                customerList.Filter(comboBox1.SelectedItem.ToString(), valueText.Text);
            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            customersTable.DataSource = customerList.DataTable;
        }

        private void ClearTable_Click(object sender, EventArgs e)
        {
            loadCustomerTable();
        }
        public void loadAddressdata()
        {
            //addresses.Address_id=customer.Customer_fname.ch
            addresses.House = HouseText.Text;
            addresses.Street = streetText.Text;
            addresses.Block = blockText.Text;
            addresses.Country = countryText.Text;
            addresses.City = cityText.Text;
            addresses.CustomerID = customer.customerID;
        }
        
        private void addAdressBtn_Click(object sender, EventArgs e)
        {
            if (customer != null)
            {
                if (addresses == null)
                {
                    if (!string.IsNullOrEmpty(streetText.Text) || !string.IsNullOrEmpty(HouseText.Text) || !string.IsNullOrEmpty(blockText.Text) || !string.IsNullOrEmpty(countryText.Text) || !string.IsNullOrEmpty(cityText.Text))
                    {
                        addresses = new Addresses();
                       
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to Add a new Address to"+customer.Customer_fname+" ?", "Adding new Address", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            //setting varablies of Address object
                            loadAddressdata();
                            try
                            {
                               addressesList.Add(addresses);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex);
                            }
                            if (!addresses.getVaild())
                            {
                                MessageBox.Show("Error: " + addresses.getErroMessage());
                            }
                            else
                            {
                                MessageBox.Show("Addresse for "+customer.Customer_fname+ " Added to the Database");
                                loadAddress();
                            }
                        }
                    }
                    else
                        MessageBox.Show("empty fields");
                }
                else
                    MessageBox.Show("click Clear and try Agian");
            }
            else
                MessageBox.Show("You Need to Select a Customer Then Add the Address.");
        }

        private void ClearAddressBtn_Click(object sender, EventArgs e)
        {
            addresses = null;
            streetText.Text = null;
            blockText.Text = null;
            HouseText.Text = null;
            cityText.Text = null;
            countryText.Text = null;
        }

        private void EditAdressBtn_Click(object sender, EventArgs e)
        {
            if (customer != null)
            {
                if (addresses != null)
                {
                    if (!string.IsNullOrEmpty(streetText.Text) || !string.IsNullOrEmpty(HouseText.Text) || !string.IsNullOrEmpty(blockText.Text) || !string.IsNullOrEmpty(countryText.Text) || !string.IsNullOrEmpty(cityText.Text))
                    {
                       

                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to Edit this  Address of the Customer: " + customer.Customer_fname + " ?", "Editing  an Address", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            //setting varablies of Address object
                            loadAddressdata();
                            try
                            {
                                addressesList.Update(addresses);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex);
                            }
                            if (!addresses.getVaild())
                            {
                                MessageBox.Show("Error: " + addresses.getErroMessage());
                            }
                            else
                            {
                                MessageBox.Show("Address Edited  ");
                                loadAddress();
                            }
                        }
                    }
                    else
                        MessageBox.Show("empty fields");
                }
                else
                    MessageBox.Show("You need to Select an Address First");
            }
            else
                MessageBox.Show("You Need to Select a Customer Then Select An Address to Edit the Address.");
        }

        private void DeleteAddressBtn_Click(object sender, EventArgs e)
        {
            if (customer != null)
            {
                if (addresses != null)
                {
                  
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to Delete this  Address of the Customer: " + customer.Customer_fname + " ?", "Deleting  an Address", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            //setting varablies of Address object
                            loadAddressdata();
                            try
                            {
                                addressesList.Delete(addresses);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex);
                            }
                            if (!addresses.getVaild())
                            {
                                MessageBox.Show("Error: " + addresses.getErroMessage());
                            }
                            else
                            {
                                MessageBox.Show("Address Deleted  ");
                                loadAddress();
                            }
                        }
                   
                }
                else
                    MessageBox.Show("You need to Select an Address First");
            }
            else
                MessageBox.Show("You Need to Select a Customer Then Select An Address to Delete the Address.");
        }
    }
}
