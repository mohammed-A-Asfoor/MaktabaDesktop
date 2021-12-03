
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BookItemTable = new System.Windows.Forms.DataGridView();
            this.BooksTable = new System.Windows.Forms.DataGridView();
            this.refreashBookTable = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.refreashCustomerTable = new System.Windows.Forms.Button();
            this.CustomerTable = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.AddBookItemBtn = new System.Windows.Forms.Button();
            this.titleText = new System.Windows.Forms.TextBox();
            this.autherText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.isbanText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BookPriceText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PublisherText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ConditionText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.searchCustomerBtn = new System.Windows.Forms.Button();
            this.clearcustomerBtn = new System.Windows.Forms.Button();
            this.customerSearchValue = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.customerColumnNames = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.listbox2 = new System.Windows.Forms.ListBox();
            this.custimerPhoneText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.customerEmailText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.discountText = new System.Windows.Forms.TextBox();
            this.totalPriceText = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.clearbookBtn = new System.Windows.Forms.Button();
            this.searchBookBtn = new System.Windows.Forms.Button();
            this.bookSearchValueText = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.booksColumnNames = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.clearOrderBoks = new System.Windows.Forms.Button();
            this.DeleteBookFromOrder = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookItemTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerTable)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1244, 266);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BookItemTable);
            this.groupBox2.Controls.Add(this.BooksTable);
            this.groupBox2.Controls.Add(this.refreashBookTable);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(707, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 266);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Books:";
            // 
            // BookItemTable
            // 
            this.BookItemTable.AllowUserToAddRows = false;
            this.BookItemTable.AllowUserToDeleteRows = false;
            this.BookItemTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookItemTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookItemTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.BookItemTable.Location = new System.Drawing.Point(3, 126);
            this.BookItemTable.Name = "BookItemTable";
            this.BookItemTable.ReadOnly = true;
            this.BookItemTable.RowTemplate.Height = 25;
            this.BookItemTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookItemTable.Size = new System.Drawing.Size(531, 105);
            this.BookItemTable.TabIndex = 4;
            this.BookItemTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookItemTable_CellClick);
            // 
            // BooksTable
            // 
            this.BooksTable.AllowUserToAddRows = false;
            this.BooksTable.AllowUserToDeleteRows = false;
            this.BooksTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BooksTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.BooksTable.Location = new System.Drawing.Point(3, 19);
            this.BooksTable.Name = "BooksTable";
            this.BooksTable.ReadOnly = true;
            this.BooksTable.RowTemplate.Height = 25;
            this.BooksTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BooksTable.Size = new System.Drawing.Size(531, 107);
            this.BooksTable.TabIndex = 2;
            this.BooksTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BooksTable_CellClick);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.refreashCustomerTable);
            this.groupBox1.Controls.Add(this.CustomerTable);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 266);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customers:";
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
            // CustomerTable
            // 
            this.CustomerTable.AllowUserToAddRows = false;
            this.CustomerTable.AllowUserToDeleteRows = false;
            this.CustomerTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomerTable.Location = new System.Drawing.Point(3, 19);
            this.CustomerTable.Name = "CustomerTable";
            this.CustomerTable.ReadOnly = true;
            this.CustomerTable.RowTemplate.Height = 25;
            this.CustomerTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerTable.Size = new System.Drawing.Size(695, 212);
            this.CustomerTable.TabIndex = 0;
            this.CustomerTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerTable_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 266);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1244, 158);
            this.panel2.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numericUpDown1);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.AddBookItemBtn);
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
            this.groupBox4.Location = new System.Drawing.Point(707, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(537, 158);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Book Information";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(425, 32);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 23);
            this.numericUpDown1.TabIndex = 28;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(425, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "Number of Books:";
            // 
            // AddBookItemBtn
            // 
            this.AddBookItemBtn.Location = new System.Drawing.Point(425, 112);
            this.AddBookItemBtn.Name = "AddBookItemBtn";
            this.AddBookItemBtn.Size = new System.Drawing.Size(100, 23);
            this.AddBookItemBtn.TabIndex = 25;
            this.AddBookItemBtn.Text = "Add To Order";
            this.AddBookItemBtn.UseVisualStyleBackColor = true;
            this.AddBookItemBtn.Click += new System.EventHandler(this.AddBookItemBtn_Click);
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(294, 75);
            this.titleText.Name = "titleText";
            this.titleText.ReadOnly = true;
            this.titleText.Size = new System.Drawing.Size(125, 23);
            this.titleText.TabIndex = 24;
            // 
            // autherText
            // 
            this.autherText.Location = new System.Drawing.Point(294, 113);
            this.autherText.Name = "autherText";
            this.autherText.ReadOnly = true;
            this.autherText.Size = new System.Drawing.Size(125, 23);
            this.autherText.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(212, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Book Auther:";
            // 
            // isbanText
            // 
            this.isbanText.Location = new System.Drawing.Point(294, 33);
            this.isbanText.Name = "isbanText";
            this.isbanText.ReadOnly = true;
            this.isbanText.Size = new System.Drawing.Size(125, 23);
            this.isbanText.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "ISBAN:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Book Title:";
            // 
            // BookPriceText
            // 
            this.BookPriceText.Location = new System.Drawing.Point(94, 116);
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
            this.PublisherText.Location = new System.Drawing.Point(94, 33);
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
            this.ConditionText.Location = new System.Drawing.Point(94, 75);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.listbox2);
            this.groupBox3.Controls.Add(this.custimerPhoneText);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.customerEmailText);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.CustomerNameText);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(701, 158);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customer Information:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(228, 130);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 15);
            this.label16.TabIndex = 9;
            this.label16.Text = "Selected address:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.searchCustomerBtn);
            this.groupBox7.Controls.Add(this.clearcustomerBtn);
            this.groupBox7.Controls.Add(this.customerSearchValue);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.customerColumnNames);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox7.Location = new System.Drawing.Point(473, 19);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(225, 136);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Search By Customer:";
            // 
            // searchCustomerBtn
            // 
            this.searchCustomerBtn.Location = new System.Drawing.Point(7, 89);
            this.searchCustomerBtn.Name = "searchCustomerBtn";
            this.searchCustomerBtn.Size = new System.Drawing.Size(100, 23);
            this.searchCustomerBtn.TabIndex = 29;
            this.searchCustomerBtn.Text = "Search";
            this.searchCustomerBtn.UseVisualStyleBackColor = true;
            this.searchCustomerBtn.Click += new System.EventHandler(this.searchCustomerBtn_Click);
            // 
            // clearcustomerBtn
            // 
            this.clearcustomerBtn.Location = new System.Drawing.Point(115, 89);
            this.clearcustomerBtn.Name = "clearcustomerBtn";
            this.clearcustomerBtn.Size = new System.Drawing.Size(100, 23);
            this.clearcustomerBtn.TabIndex = 28;
            this.clearcustomerBtn.Text = "Clear";
            this.clearcustomerBtn.UseVisualStyleBackColor = true;
            this.clearcustomerBtn.Click += new System.EventHandler(this.clearcustomerBtn_Click);
            // 
            // customerSearchValue
            // 
            this.customerSearchValue.Location = new System.Drawing.Point(101, 63);
            this.customerSearchValue.Name = "customerSearchValue";
            this.customerSearchValue.Size = new System.Drawing.Size(114, 23);
            this.customerSearchValue.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 15);
            this.label14.TabIndex = 2;
            this.label14.Text = "Value:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 15);
            this.label15.TabIndex = 1;
            this.label15.Text = "Column Name:";
            // 
            // customerColumnNames
            // 
            this.customerColumnNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerColumnNames.FormattingEnabled = true;
            this.customerColumnNames.Location = new System.Drawing.Point(101, 20);
            this.customerColumnNames.Name = "customerColumnNames";
            this.customerColumnNames.Size = new System.Drawing.Size(114, 23);
            this.customerColumnNames.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(228, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 15);
            this.label13.TabIndex = 7;
            this.label13.Text = "Address:";
            // 
            // listbox2
            // 
            this.listbox2.FormattingEnabled = true;
            this.listbox2.ItemHeight = 15;
            this.listbox2.Location = new System.Drawing.Point(228, 32);
            this.listbox2.Name = "listbox2";
            this.listbox2.Size = new System.Drawing.Size(239, 94);
            this.listbox2.TabIndex = 6;
            this.listbox2.SelectedIndexChanged += new System.EventHandler(this.listbox2_SelectedIndexChanged);
            // 
            // custimerPhoneText
            // 
            this.custimerPhoneText.Location = new System.Drawing.Point(110, 113);
            this.custimerPhoneText.Name = "custimerPhoneText";
            this.custimerPhoneText.Size = new System.Drawing.Size(112, 23);
            this.custimerPhoneText.TabIndex = 5;
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
            // customerEmailText
            // 
            this.customerEmailText.Location = new System.Drawing.Point(110, 75);
            this.customerEmailText.Name = "customerEmailText";
            this.customerEmailText.Size = new System.Drawing.Size(112, 23);
            this.customerEmailText.TabIndex = 3;
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
            // CustomerNameText
            // 
            this.CustomerNameText.Location = new System.Drawing.Point(110, 33);
            this.CustomerNameText.Name = "CustomerNameText";
            this.CustomerNameText.Size = new System.Drawing.Size(112, 23);
            this.CustomerNameText.TabIndex = 1;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.discountText);
            this.panel3.Controls.Add(this.totalPriceText);
            this.panel3.Controls.Add(this.saveBtn);
            this.panel3.Controls.Add(this.groupBox6);
            this.panel3.Controls.Add(this.groupBox5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 424);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1244, 123);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1062, 62);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 15);
            this.label18.TabIndex = 34;
            this.label18.Text = "Total";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1062, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 15);
            this.label17.TabIndex = 33;
            this.label17.Text = "Discount";
            // 
            // discountText
            // 
            this.discountText.ForeColor = System.Drawing.Color.Red;
            this.discountText.Location = new System.Drawing.Point(1132, 19);
            this.discountText.Name = "discountText";
            this.discountText.Size = new System.Drawing.Size(100, 23);
            this.discountText.TabIndex = 32;
            this.discountText.TextChanged += new System.EventHandler(this.discountText_TextChanged);
            // 
            // totalPriceText
            // 
            this.totalPriceText.ForeColor = System.Drawing.Color.SpringGreen;
            this.totalPriceText.Location = new System.Drawing.Point(1132, 59);
            this.totalPriceText.Name = "totalPriceText";
            this.totalPriceText.ReadOnly = true;
            this.totalPriceText.Size = new System.Drawing.Size(100, 23);
            this.totalPriceText.TabIndex = 31;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(1132, 88);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(100, 23);
            this.saveBtn.TabIndex = 30;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.clearbookBtn);
            this.groupBox6.Controls.Add(this.searchBookBtn);
            this.groupBox6.Controls.Add(this.bookSearchValueText);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.booksColumnNames);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox6.Location = new System.Drawing.Point(702, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(353, 123);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Search By Book";
            // 
            // clearbookBtn
            // 
            this.clearbookBtn.Location = new System.Drawing.Point(243, 70);
            this.clearbookBtn.Name = "clearbookBtn";
            this.clearbookBtn.Size = new System.Drawing.Size(100, 23);
            this.clearbookBtn.TabIndex = 29;
            this.clearbookBtn.Text = "Clear table";
            this.clearbookBtn.UseVisualStyleBackColor = true;
            this.clearbookBtn.Click += new System.EventHandler(this.clearbookBtn_Click);
            // 
            // searchBookBtn
            // 
            this.searchBookBtn.Location = new System.Drawing.Point(243, 18);
            this.searchBookBtn.Name = "searchBookBtn";
            this.searchBookBtn.Size = new System.Drawing.Size(100, 23);
            this.searchBookBtn.TabIndex = 28;
            this.searchBookBtn.Text = "Search";
            this.searchBookBtn.UseVisualStyleBackColor = true;
            this.searchBookBtn.Click += new System.EventHandler(this.searchBookBtn_Click);
            // 
            // bookSearchValueText
            // 
            this.bookSearchValueText.Location = new System.Drawing.Point(94, 71);
            this.bookSearchValueText.Name = "bookSearchValueText";
            this.bookSearchValueText.Size = new System.Drawing.Size(121, 23);
            this.bookSearchValueText.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 15);
            this.label12.TabIndex = 2;
            this.label12.Text = "Value:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Column Name:";
            // 
            // booksColumnNames
            // 
            this.booksColumnNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.booksColumnNames.FormattingEnabled = true;
            this.booksColumnNames.Location = new System.Drawing.Point(94, 20);
            this.booksColumnNames.Name = "booksColumnNames";
            this.booksColumnNames.Size = new System.Drawing.Size(121, 23);
            this.booksColumnNames.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.clearOrderBoks);
            this.groupBox5.Controls.Add(this.DeleteBookFromOrder);
            this.groupBox5.Controls.Add(this.listBox1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(702, 123);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Book List:";
            // 
            // clearOrderBoks
            // 
            this.clearOrderBoks.Location = new System.Drawing.Point(419, 71);
            this.clearOrderBoks.Name = "clearOrderBoks";
            this.clearOrderBoks.Size = new System.Drawing.Size(75, 23);
            this.clearOrderBoks.TabIndex = 2;
            this.clearOrderBoks.Text = "Clear";
            this.clearOrderBoks.UseVisualStyleBackColor = true;
            this.clearOrderBoks.Click += new System.EventHandler(this.clearOrderBoks_Click);
            // 
            // DeleteBookFromOrder
            // 
            this.DeleteBookFromOrder.Location = new System.Drawing.Point(419, 23);
            this.DeleteBookFromOrder.Name = "DeleteBookFromOrder";
            this.DeleteBookFromOrder.Size = new System.Drawing.Size(75, 23);
            this.DeleteBookFromOrder.TabIndex = 1;
            this.DeleteBookFromOrder.Text = "Delete";
            this.DeleteBookFromOrder.UseVisualStyleBackColor = true;
            this.DeleteBookFromOrder.Click += new System.EventHandler(this.DeleteBookFromOrder_Click);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(3, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(336, 101);
            this.listBox1.TabIndex = 0;
            // 
            // Manage_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 547);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Manage_Orders";
            this.Text = "Manage_Orders";
            this.Load += new System.EventHandler(this.Manage_Orders_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BookItemTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button refreashCustomerTable;
        private System.Windows.Forms.DataGridView CustomerTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView BookItemTable;
        private System.Windows.Forms.DataGridView BooksTable;
        private System.Windows.Forms.Button refreashBookTable;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button AddBookItemBtn;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.TextBox autherText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox isbanText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BookPriceText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PublisherText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ConditionText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox custimerPhoneText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customerEmailText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CustomerNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button clearbookBtn;
        private System.Windows.Forms.Button searchBookBtn;
        private System.Windows.Forms.TextBox bookSearchValueText;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox booksColumnNames;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button clearOrderBoks;
        private System.Windows.Forms.Button DeleteBookFromOrder;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button searchCustomerBtn;
        private System.Windows.Forms.Button clearcustomerBtn;
        private System.Windows.Forms.TextBox customerSearchValue;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox customerColumnNames;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox listbox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox discountText;
        private System.Windows.Forms.TextBox totalPriceText;
    }
}