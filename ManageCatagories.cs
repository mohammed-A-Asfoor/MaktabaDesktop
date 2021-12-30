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
    public partial class ManageCatagories : Form
    {
        CatagoryList catagoryList;
        Catagory catagory;
        BookList bookList;
        public ManageCatagories()
        {
            InitializeComponent();
        }

        private void ManageCatagories_Load(object sender, EventArgs e)
        {
            
            
            loadCatagoryTable();

        }
        public void loadCatagoryTable()
        {
            catagoryList = new CatagoryList();
            catagoryList.Populate();
            dataGridView1.DataSource = catagoryList.DataTable;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.RowCount != 0)
                {
                    string catagoryID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    catagory = new Catagory(catagoryID);
                    catagoryList.Populate(catagory);
                    CatagoryNameText.Text = catagory.catagory_name;
                    catagoryDescText.Text = catagory.catagory_description;
                }
                else
                    MessageBox.Show("No data to display");
            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void loadDataInCatagory()
        {
            catagory.catagory_name = CatagoryNameText.Text;
            catagory.catagory_description = catagoryDescText.Text;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

            if (catagory == null)
            {
                if (!string.IsNullOrEmpty(CatagoryNameText.Text) || !string.IsNullOrEmpty(CatagoryNameText.Text))
                {


                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to Add a new Catagory?", "Adding new Catagory", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        catagory = new Catagory();
                        //setting varablies of Admin object
                        loadDataInCatagory();
                        try
                        {
                            catagoryList.Add(catagory);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex);
                        }
                        if (!catagory.getVaild())
                        {
                            MessageBox.Show("Error: " + catagory.getErroMessage());
                        }
                        else
                        {
                            MessageBox.Show("Catagory was Added");
                            loadCatagoryTable();
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
            if (catagory != null)
            {
                if (!string.IsNullOrEmpty(CatagoryNameText.Text) || !string.IsNullOrEmpty(catagoryDescText.Text))
                {


                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to Edit This Catagory?", "Edting "+catagory.catagory_name+" Catagory", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {

                        //setting varablies of Admin object
                        loadDataInCatagory();
                        try
                        {
                            catagoryList.Update(catagory);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex);
                        }
                        if (!catagory.getVaild())
                        {
                            MessageBox.Show("Error: " + catagory.getErroMessage());
                        }
                        else
                        {
                            MessageBox.Show("admin " + catagory.catagory_name+ " Was Edited");
                            loadCatagoryTable();
                        }
                    }
                }
                else
                    MessageBox.Show("empty fields");
            }
            else
                MessageBox.Show("You Need to Select A Record First");
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (catagory != null)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to Delete This Catagory?", "Deleting Catagory " + catagory.catagory_name, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //verifying if the catagory is being used
                    bookList = new BookList();
                    if (!bookList.CheckChildRecord("category_id", catagory.category_id))
                    {
                        //setting varablies of Admin object
                        loadDataInCatagory();
                        try
                        {
                            catagoryList.Delete(catagory);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex);
                        }
                        if (!catagory.getVaild())
                        {
                            MessageBox.Show("Error: " + catagory.getErroMessage());
                        }
                        else
                        {
                            MessageBox.Show("Catagory " + catagory.catagory_name + " Was Deleted");
                            catagory = null;
                            CatagoryNameText.Text = null;
                            catagoryDescText.Text = null;
                            loadCatagoryTable();
                        }
                    }
                    else
                        MessageBox.Show("This Catagory is being used by a Book. You need to Delete the books First. NOTE: This might require you to Delete Book itmes related to Selected Books");
                    
                }

            }
            else
                MessageBox.Show("You Need to Select A Record First");
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {

            catagory = null;
            CatagoryNameText.Text = null;
            catagoryDescText.Text = null;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
