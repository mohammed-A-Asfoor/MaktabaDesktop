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
    public partial class BookInformationForm : Form
    {
        BookList bookList;
        Book book;
        string ISPAN;
        public BookInformationForm()
        {
            InitializeComponent();
        }

        private void BookInformationForm_Load(object sender, EventArgs e)
        {
            bookList = new BookList();
            loadDataToTable();
        } //to load data and refresh table after editing it
        public void loadDataToTable()
        {
            bookList.Populate();

            BookInformationTable.DataSource = bookList.DataTable;
        }

        private void BookInformationTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ISPAN = BookInformationTable.CurrentRow.Cells[0].Value.ToString();
            book = new Book(ISPAN);
            
             bookList.Populate(book);
            loadDataToTextfields();
            
        }
       
        public void loadDataToTextfields()
        {
            ISNAPtext.Text = book.ISBAN;
            autherText.Text = book.Book_Auther;
            bookTitleText.Text = book.Book_Title;
            DORtext.Text = book.Date_Of_Release;
            
        }
        public void loadDataToObject()
        {
            book.ISBAN = ISNAPtext.Text;
            book.Book_Title = bookTitleText.Text;
            book.Book_Auther = autherText.Text;
            book.Date_Of_Release = DORtext.Text;
            book.category_id = textBox1.Text;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (book != null)
            {
                MessageBox.Show("Click Clear and try agian");
            }else
            {
                book = new Book();
                loadDataToObject();
                //book.Catagoryid = car
                try
                {
                    bookList.Add(book);
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                 }
                if(book.getErroMessage()!=null)
                    MessageBox.Show(book.getErroMessage());
                else
                    loadDataToTable();

            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (book != null)
            {
                loadDataToObject();
                try
                {
                    bookList.Update(book);
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (book.getErroMessage() != null)
                    MessageBox.Show("ERROR: " + book.getErroMessage());
                else
                    loadDataToTable(); 
            }
            else
                MessageBox.Show("You need to Select a Reocrd First");
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
     //       bookList.CheckChildRecord("category_id", )
        }
    }
}
