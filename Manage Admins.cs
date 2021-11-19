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
    
    public partial class Manage_Admins : Form
    {
        Admin admin;
        AdminList adminList;

        public Manage_Admins()
        {
            InitializeComponent();
        }

        private void Manage_Admins_Load(object sender, EventArgs e)
        {
            if (Global.admin.Admin_ID == "2")
            {
                adminList = new AdminList();
                LoadAdminTable();
            }
            else
            {
                MessageBox.Show("You are not Authorized to Enter Here");
                this.Close();
            }
        }
        public void LoadAdminTable()
        {
            adminList.Populate();
            AdminTable.DataSource = adminList.DataTable;
        }

        private void AdminTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string AdminID = AdminTable.CurrentRow.Cells[0].Value.ToString();
            admin = new Admin(AdminID);
            adminList.Populate(admin);
            loadAdminData();

        }
        public void loadAdminData()
        {
            AdminNameText.Text = admin.Admin_Name;
            AdminEmailText.Text = admin.Admin_Email;
            AdminPasswordText.Text = admin.Admin_Password;
        }
        public void loadDataInAdmin()
        {
            admin.Admin_Name = AdminNameText.Text;
            admin.Admin_Email = AdminEmailText.Text;
            admin.Admin_Password = AdminPasswordText.Text;
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (admin == null)
            {
                if (!string.IsNullOrEmpty(AdminNameText.Text) || !string.IsNullOrEmpty(AdminEmailText.Text) || !string.IsNullOrEmpty(AdminPasswordText.Text))
                {


                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to Add a new Admin?", "Adding new Admin", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        admin = new Admin();
                        //setting varablies of Admin object
                        loadDataInAdmin();
                        try
                        {
                            adminList.Add(admin);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex);
                        }
                        if (!admin.getVaild())
                        {
                            MessageBox.Show("Error: " + admin.getErroMessage());
                        }
                        else
                        {
                            MessageBox.Show("admin was Added");
                            LoadAdminTable();
                        }
                    }
                }
                else
                    MessageBox.Show("empty fields");
            }
            else
                MessageBox.Show("You Need to Cilck Clear and Try Agin");
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (admin != null)
            {
                if (!string.IsNullOrEmpty(AdminNameText.Text) || !string.IsNullOrEmpty(AdminEmailText.Text) || !string.IsNullOrEmpty(AdminPasswordText.Text))
                {


                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to Edtit This Admin?", "Edting Admin "+admin.Admin_Name, MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        
                        //setting varablies of Admin object
                        loadDataInAdmin();
                        try
                        {
                            adminList.Update(admin);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex);
                        }
                        if (!admin.getVaild())
                        {
                            MessageBox.Show("Error: " + admin.getErroMessage());
                        }
                        else
                        {
                            MessageBox.Show("admin "+admin.Admin_Name+" Was Edited");
                            LoadAdminTable();
                        }
                    }
                }
                else
                    MessageBox.Show("empty fields");
            }
            else
                MessageBox.Show("You Need to Select A Record First");
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (admin != null)
            {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to Delete This AdminAdmin?", "Deleting Admin "+admin.Admin_Name, MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {

                        //setting varablies of Admin object
                        loadDataInAdmin();
                        try
                        {
                            adminList.Delete(admin);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex);
                        }
                        if (!admin.getVaild())
                        {
                            MessageBox.Show("Error: " + admin.getErroMessage());
                        }
                        else
                        {
                            MessageBox.Show("admin " + admin.Admin_Name + " Was Deleted");
                        admin = null;
                            LoadAdminTable();
                        }
                    }
                
            }
            else
                MessageBox.Show("You Need to Select A Record First");
        }
    }
}
