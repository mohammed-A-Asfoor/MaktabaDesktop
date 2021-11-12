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
    public partial class Login : Form
    {
        Admin admin;
        AdminList adminList;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            adminList = new AdminList();

            adminList.Populate();
           
            
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            foreach (Admin admin1 in adminList.List)
            {
                if (admin1.Admin_Name == userNameText.Text && admin1.Admin_Password == passwordText.Text)
                {
                    
                
                    Global.admin = admin1;
                    MainForm frm = new MainForm();
                    Login loginfrm = new Login();
                    frm.Show();
                    loginfrm.Close();

                }

            }
            if (Global.admin == null)
            {
                MessageBox.Show("User not found");
            }
        }
    }
}
