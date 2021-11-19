
namespace MaktabaDesktop
{
    partial class Manage_Orders
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CustomerTable = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.refreashCustomerTable = new System.Windows.Forms.Button();
            this.refreashBookTable = new System.Windows.Forms.Button();
            this.BooksTable = new System.Windows.Forms.DataGridView();
            this.BookItemTable = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BookPriceText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PublisherText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ConditionText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.TextBox();
            this.autherText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.isbanText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AddressesList = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerTable)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookItemTable)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 266);
            this.panel1.TabIndex = 0;
            // 
            // CustomerTable
            // 
            this.CustomerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomerTable.Location = new System.Drawing.Point(3, 19);
            this.CustomerTable.Name = "CustomerTable";
            this.CustomerTable.RowTemplate.Height = 25;
            this.CustomerTable.Size = new System.Drawing.Size(387, 212);
            this.CustomerTable.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 266);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 142);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.refreashCustomerTable);
            this.groupBox1.Controls.Add(this.CustomerTable);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 266);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customers:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BookItemTable);
            this.groupBox2.Controls.Add(this.BooksTable);
            this.groupBox2.Controls.Add(this.refreashBookTable);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(396, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 266);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Books:";
            // 
            // refreashCustomerTable
            // 
            this.refreashCustomerTable.Location = new System.Drawing.Point(3, 237);
            this.refreashCustomerTable.Name = "refreashCustomerTable";
            this.refreashCustomerTable.Size = new System.Drawing.Size(75, 23);
            this.refreashCustomerTable.TabIndex = 1;
            this.refreashCustomerTable.Text = "refreash";
            this.refreashCustomerTable.UseVisualStyleBackColor = true;
            // 
            // refreashBookTable
            // 
            this.refreashBookTable.Location = new System.Drawing.Point(6, 237);
            this.refreashBookTable.Name = "refreashBookTable";
            this.refreashBookTable.Size = new System.Drawing.Size(75, 23);
            this.refreashBookTable.TabIndex = 3;
            this.refreashBookTable.Text = "refreash";
            this.refreashBookTable.UseVisualStyleBackColor = true;
            // 
            // BooksTable
            // 
            this.BooksTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.BooksTable.Location = new System.Drawing.Point(3, 19);
            this.BooksTable.Name = "BooksTable";
            this.BooksTable.RowTemplate.Height = 25;
            this.BooksTable.Size = new System.Drawing.Size(398, 107);
            this.BooksTable.TabIndex = 2;
            // 
            // BookItemTable
            // 
            this.BookItemTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookItemTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.BookItemTable.Location = new System.Drawing.Point(3, 126);
            this.BookItemTable.Name = "BookItemTable";
            this.BookItemTable.RowTemplate.Height = 25;
            this.BookItemTable.Size = new System.Drawing.Size(398, 105);
            this.BookItemTable.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AddressesList);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(393, 142);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customer Information:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.titleText);
            this.groupBox4.Controls.Add(this.autherText);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.isbanText);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.BookPriceText);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.PublisherText);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.ConditionText);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox4.Location = new System.Drawing.Point(396, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(404, 142);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Book Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Email:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(110, 113);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customer Phone:";
            // 
            // BookPriceText
            // 
            this.BookPriceText.Location = new System.Drawing.Point(68, 116);
            this.BookPriceText.Name = "BookPriceText";
            this.BookPriceText.ReadOnly = true;
            this.BookPriceText.Size = new System.Drawing.Size(100, 23);
            this.BookPriceText.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Book Price:";
            // 
            // PublisherText
            // 
            this.PublisherText.Location = new System.Drawing.Point(68, 33);
            this.PublisherText.Name = "PublisherText";
            this.PublisherText.ReadOnly = true;
            this.PublisherText.Size = new System.Drawing.Size(100, 23);
            this.PublisherText.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Publisher:";
            // 
            // ConditionText
            // 
            this.ConditionText.Location = new System.Drawing.Point(68, 75);
            this.ConditionText.Name = "ConditionText";
            this.ConditionText.ReadOnly = true;
            this.ConditionText.Size = new System.Drawing.Size(100, 23);
            this.ConditionText.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Condition:";
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(267, 75);
            this.titleText.Name = "titleText";
            this.titleText.ReadOnly = true;
            this.titleText.Size = new System.Drawing.Size(125, 23);
            this.titleText.TabIndex = 24;
            // 
            // autherText
            // 
            this.autherText.Location = new System.Drawing.Point(267, 113);
            this.autherText.Name = "autherText";
            this.autherText.ReadOnly = true;
            this.autherText.Size = new System.Drawing.Size(125, 23);
            this.autherText.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(185, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Book Auther:";
            // 
            // isbanText
            // 
            this.isbanText.Location = new System.Drawing.Point(267, 33);
            this.isbanText.Name = "isbanText";
            this.isbanText.ReadOnly = true;
            this.isbanText.Size = new System.Drawing.Size(125, 23);
            this.isbanText.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(185, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "ISBAN:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(185, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Book Title:";
            // 
            // AddressesList
            // 
            this.AddressesList.Dock = System.Windows.Forms.DockStyle.Right;
            this.AddressesList.FormattingEnabled = true;
            this.AddressesList.ItemHeight = 15;
            this.AddressesList.Location = new System.Drawing.Point(225, 19);
            this.AddressesList.Name = "AddressesList";
            this.AddressesList.Size = new System.Drawing.Size(165, 120);
            this.AddressesList.TabIndex = 6;
            // 
            // Manage_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Manage_Orders";
            this.Text = "Manage_Orders";
            this.Load += new System.EventHandler(this.Manage_Orders_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BooksTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookItemTable)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView BookItemTable;
        private System.Windows.Forms.DataGridView BooksTable;
        private System.Windows.Forms.Button refreashBookTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button refreashCustomerTable;
        private System.Windows.Forms.DataGridView CustomerTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BookPriceText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PublisherText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ConditionText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.TextBox autherText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox isbanText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox AddressesList;
    }
}