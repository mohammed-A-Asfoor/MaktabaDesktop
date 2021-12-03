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
    public partial class Managediscountcode : Form
    {
        public Managediscountcode()
        {
            InitializeComponent();
        }
        discountCodeList discountCodeList;
        Discount_Code discount_Code;
        AdminList adminList;
        Admin admin;
        private void Managediscountcode_Load(object sender, EventArgs e)
        {
            adminList = new AdminList();
            discountCodeList = new discountCodeList();
            loadDiscountTable();

            //adding the status 
            statusCombo.Items.Add("Active");
            statusCombo.Items.Add("Disabled");

            //creating the columns list for search function
            columnList.DataSource = discountCodeList.ColumnNames;
        }
        public void loadDiscountTable()
        {
            discountCodeList.Populate();
            dataGridView1.DataSource = discountCodeList.DataTable;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //getting the ID from the Table
            string discountCodeID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //creating the Object
            discount_Code = new Discount_Code(discountCodeID);
            //getting the data from the Table
            discountCodeList.Populate(discount_Code);
            //showing the values to the Admin
            DiscountCodeText.Text = discount_Code.codeID;
            Persantage.Value = Convert.ToDecimal(discount_Code.Amount);
            if (discount_Code.Status != "True")
            {
                statusCombo.SelectedIndex = 1;
            }
            else
                statusCombo.SelectedIndex = 0;

            //showing who last Editied the Record
            admin = new Admin(discount_Code.Admin_ID);
            adminList.Populate(admin);
            AdminLable.Text = "Last Edit was by " + admin.Admin_Name;


        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (valueText.Text != "")
            {
                //if statmens to verify the value type
                if (columnList.SelectedItem.ToString() == "Status")
                {
                    //because the column type is boolean
                    if (valueText.Text == "active")
                    {
                       
                        valueText.Text = "True";
                        discountCodeList.Filter(columnList.SelectedItem.ToString(), valueText.Text);
                    }
                    else if (valueText.Text == "disabled")
                    {
                        valueText.Text = "False";
                        discountCodeList.Filter(columnList.SelectedItem.ToString(), valueText.Text);
                        
                    }
                    else
                    {
                        MessageBox.Show("The status Value must be either active or disabled");
                        valueText.Text = null;
                    }
                    
                   
                }else if (columnList.SelectedItem.ToString() == "Admin_ID")
                {
                    int num;
                    bool isNum=int.TryParse(valueText.Text, out num);

                    if (isNum)
                        discountCodeList.Filter(columnList.SelectedItem.ToString(), valueText.Text);
                    else
                        MessageBox.Show("The Value must be Number");
                    //other columns are string so the value type won return an error
                }else
                    discountCodeList.Filter(columnList.SelectedItem.ToString(), valueText.Text);


            }
            else
                MessageBox.Show("You Need to Enter a Value"); ;
        }

        private void clearSearchBtn_Click(object sender, EventArgs e)
        {
            loadDiscountTable();
        }
        public void loaddiscountCodeData()
        {
            discount_Code.codeID = DiscountCodeText.Text;
            discount_Code.Amount = Persantage.Value.ToString();
            if (statusCombo.SelectedItem.ToString() != "Disabled")
            {
                discount_Code.Status = "True";
            }
            else
                discount_Code.Status = "False";
            discount_Code.Admin_ID = Global.admin.Admin_ID;
        }
         

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (discount_Code != null)
            {
                MessageBox.Show("you need to click Clear and try agian");
            }
            else
            {
                if (string.IsNullOrEmpty(DiscountCodeText.Text) || string.IsNullOrEmpty(Persantage.Text) )
                {
                    MessageBox.Show("Empty feild");
                }
                else
                {
                    discount_Code = new Discount_Code();
                    
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to Add a new Discount Code??", "Adding new Discount Code", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //setting varablies of discount code
                        loaddiscountCodeData();
                        try
                        {
                            discountCodeList.Add(discount_Code);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex);
                        }
                        if (!discount_Code.getVaild())
                        {
                            MessageBox.Show("Error: " + discount_Code.getErroMessage());
                        }
                        else
                        {
                            MessageBox.Show("Discount Code Added to the Database");
                            loadDiscountTable();
                        }
                    }

                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            discount_Code = null;
            DiscountCodeText.Text = null;
            Persantage.Value = 0;
            AdminLable.Text = "";
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (discount_Code != null)
            {
                if (string.IsNullOrEmpty(DiscountCodeText.Text) || string.IsNullOrEmpty(Persantage.Text))
                {
                    MessageBox.Show("Empty feild");
                }
                else
                {
                   
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to Edit Discount code Information?", "Editing Discount code Information", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //setting varablies of customer object
                        loaddiscountCodeData();

                        try
                        {
                            discountCodeList.Update(discount_Code);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex);
                        }
                        if (!discount_Code.getVaild())
                        {
                            MessageBox.Show("Error: " + discount_Code.getErroMessage());
                        }
                        else
                        {
                            MessageBox.Show("Customer Information Updated");
                            loadDiscountTable();
                        }

                    }

                }
            }
            else
                MessageBox.Show("you should Select a Record First");
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (discount_Code != null)
            {
                if (string.IsNullOrEmpty(DiscountCodeText.Text) || string.IsNullOrEmpty(Persantage.Text) )
                {
                    MessageBox.Show("Empty feild");
                }
                else
                {
                    
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to Edit customer Information?", "Editing Customer Information", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {

                            try
                            {
                                discountCodeList.Delete(discount_Code);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex);
                            }
                            if (!discount_Code.getVaild())
                            {
                                MessageBox.Show("Error: " + discount_Code.getErroMessage());
                            }
                            else
                            {
                                MessageBox.Show("Customer Deleted");
                            loadDiscountTable();
                            }

                        }
                    
                    else
                        MessageBox.Show("this Customer have Orders or addresses. you need to Delete them First");


                }
            }
            else
                MessageBox.Show("you should Select a Record First");
        }
    }
}
