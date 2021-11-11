
namespace MaktabaDesktop
{
    partial class BookInformationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BookInformationTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ISNAPtext = new System.Windows.Forms.TextBox();
            this.bookTitleText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.autherText = new System.Windows.Forms.TextBox();
            this.lable3 = new System.Windows.Forms.Label();
            this.DORtext = new System.Windows.Forms.TextBox();
            this.lable4 = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.BookInformationTable)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // BookInformationTable
            // 
            this.BookInformationTable.AllowUserToAddRows = false;
            this.BookInformationTable.AllowUserToDeleteRows = false;
            this.BookInformationTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookInformationTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookInformationTable.Location = new System.Drawing.Point(0, 0);
            this.BookInformationTable.MultiSelect = false;
            this.BookInformationTable.Name = "BookInformationTable";
            this.BookInformationTable.ReadOnly = true;
            this.BookInformationTable.RowTemplate.Height = 25;
            this.BookInformationTable.Size = new System.Drawing.Size(800, 239);
            this.BookInformationTable.TabIndex = 0;
            this.BookInformationTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookInformationTable_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ISPAN:";
            // 
            // ISNAPtext
            // 
            this.ISNAPtext.Location = new System.Drawing.Point(85, 20);
            this.ISNAPtext.Name = "ISNAPtext";
            this.ISNAPtext.Size = new System.Drawing.Size(100, 23);
            this.ISNAPtext.TabIndex = 2;
            // 
            // bookTitleText
            // 
            this.bookTitleText.Location = new System.Drawing.Point(85, 64);
            this.bookTitleText.Name = "bookTitleText";
            this.bookTitleText.Size = new System.Drawing.Size(100, 23);
            this.bookTitleText.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Book Title:";
            // 
            // autherText
            // 
            this.autherText.Location = new System.Drawing.Point(333, 17);
            this.autherText.Name = "autherText";
            this.autherText.Size = new System.Drawing.Size(100, 23);
            this.autherText.TabIndex = 6;
            // 
            // lable3
            // 
            this.lable3.AutoSize = true;
            this.lable3.Location = new System.Drawing.Point(207, 25);
            this.lable3.Name = "lable3";
            this.lable3.Size = new System.Drawing.Size(76, 15);
            this.lable3.TabIndex = 5;
            this.lable3.Text = "Book Auther:";
            // 
            // DORtext
            // 
            this.DORtext.Location = new System.Drawing.Point(333, 64);
            this.DORtext.Name = "DORtext";
            this.DORtext.Size = new System.Drawing.Size(100, 23);
            this.DORtext.TabIndex = 8;
            // 
            // lable4
            // 
            this.lable4.AutoSize = true;
            this.lable4.Location = new System.Drawing.Point(207, 67);
            this.lable4.Name = "lable4";
            this.lable4.Size = new System.Drawing.Size(120, 15);
            this.lable4.TabIndex = 7;
            this.lable4.Text = "Book Date of Release:";
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(113, 42);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 9;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(7, 42);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 10;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(7, 86);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 11;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(113, 86);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 12;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Catagory";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 53);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 292);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 158);
            this.panel2.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ISNAPtext);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lable4);
            this.panel4.Controls.Add(this.autherText);
            this.panel4.Controls.Add(this.bookTitleText);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.DORtext);
            this.panel4.Controls.Add(this.lable3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(535, 158);
            this.panel4.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.editBtn);
            this.panel3.Controls.Add(this.clearBtn);
            this.panel3.Controls.Add(this.addBtn);
            this.panel3.Controls.Add(this.deleteBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(600, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 158);
            this.panel3.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.BookInformationTable);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 53);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(800, 239);
            this.panel5.TabIndex = 17;
            // 
            // BookInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BookInformationForm";
            this.Text = "BookInformationForm";
            this.Load += new System.EventHandler(this.BookInformationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookInformationTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BookInformationTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ISNAPtext;
        private System.Windows.Forms.TextBox bookTitleText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox autherText;
        private System.Windows.Forms.Label lable3;
        private System.Windows.Forms.TextBox DORtext;
        private System.Windows.Forms.Label lable4;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
    }
}