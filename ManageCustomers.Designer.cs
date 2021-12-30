
namespace MaktabaDesktop
{
    partial class ManageCustomers
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
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.customersTable = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.customerbirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.CustomerPasswordText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CustomerEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomerPhoneText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customerLNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customerFNameText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.ClearTable = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.valueText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ClearAddressBtn = new System.Windows.Forms.Button();
            this.DeleteAddressBtn = new System.Windows.Forms.Button();
            this.EditAdressBtn = new System.Windows.Forms.Button();
            this.addAdressBtn = new System.Windows.Forms.Button();
            this.countryText = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cityText = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.blockText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.HouseText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.streetText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.AddresssTextList = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersTable)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label14);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 89);
            this.panel1.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Top;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(855, 51);
            this.label14.TabIndex = 0;
            this.label14.Text = "Manage Customers Information";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.customersTable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(855, 234);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Reload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customersTable
            // 
            this.customersTable.AllowUserToAddRows = false;
            this.customersTable.AllowUserToDeleteRows = false;
            this.customersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.customersTable.Location = new System.Drawing.Point(0, 39);
            this.customersTable.Name = "customersTable";
            this.customersTable.ReadOnly = true;
            this.customersTable.RowTemplate.Height = 25;
            this.customersTable.Size = new System.Drawing.Size(855, 195);
            this.customersTable.TabIndex = 0;
            this.customersTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersTable_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 323);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(855, 135);
            this.panel3.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.customerbirthDatePicker);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.CustomerPasswordText);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.CustomerEmail);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.CustomerPhoneText);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.customerLNameText);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.customerFNameText);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(654, 135);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer information";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // customerbirthDatePicker
            // 
            this.customerbirthDatePicker.Location = new System.Drawing.Point(149, 102);
            this.customerbirthDatePicker.Name = "customerbirthDatePicker";
            this.customerbirthDatePicker.Size = new System.Drawing.Size(148, 23);
            this.customerbirthDatePicker.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(358, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Customer Password:";
            // 
            // CustomerPasswordText
            // 
            this.CustomerPasswordText.Location = new System.Drawing.Point(479, 99);
            this.CustomerPasswordText.Name = "CustomerPasswordText";
            this.CustomerPasswordText.Size = new System.Drawing.Size(128, 23);
            this.CustomerPasswordText.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Customer Email";
            // 
            // CustomerEmail
            // 
            this.CustomerEmail.Location = new System.Drawing.Point(479, 62);
            this.CustomerEmail.Name = "CustomerEmail";
            this.CustomerEmail.Size = new System.Drawing.Size(128, 23);
            this.CustomerEmail.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Customer Phone";
            // 
            // CustomerPhoneText
            // 
            this.CustomerPhoneText.Location = new System.Drawing.Point(479, 21);
            this.CustomerPhoneText.Name = "CustomerPhoneText";
            this.CustomerPhoneText.Size = new System.Drawing.Size(128, 23);
            this.CustomerPhoneText.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Customer Birth Day:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Customer Last Name:";
            // 
            // customerLNameText
            // 
            this.customerLNameText.Location = new System.Drawing.Point(147, 62);
            this.customerLNameText.Name = "customerLNameText";
            this.customerLNameText.Size = new System.Drawing.Size(148, 23);
            this.customerLNameText.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Customer First Name:";
            // 
            // customerFNameText
            // 
            this.customerFNameText.Location = new System.Drawing.Point(149, 18);
            this.customerFNameText.Name = "customerFNameText";
            this.customerFNameText.Size = new System.Drawing.Size(148, 23);
            this.customerFNameText.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.SearchBtn);
            this.groupBox1.Controls.Add(this.ClearTable);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.valueText);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(660, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 135);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(70, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 25;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(8, 102);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(67, 23);
            this.SearchBtn.TabIndex = 30;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // ClearTable
            // 
            this.ClearTable.Location = new System.Drawing.Point(81, 100);
            this.ClearTable.Name = "ClearTable";
            this.ClearTable.Size = new System.Drawing.Size(110, 23);
            this.ClearTable.TabIndex = 29;
            this.ClearTable.Text = "Clear Search";
            this.ClearTable.UseVisualStyleBackColor = true;
            this.ClearTable.Click += new System.EventHandler(this.ClearTable_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "Value:";
            // 
            // valueText
            // 
            this.valueText.Location = new System.Drawing.Point(70, 61);
            this.valueText.Name = "valueText";
            this.valueText.Size = new System.Drawing.Size(121, 23);
            this.valueText.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "Column:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ClearAddressBtn);
            this.groupBox3.Controls.Add(this.DeleteAddressBtn);
            this.groupBox3.Controls.Add(this.EditAdressBtn);
            this.groupBox3.Controls.Add(this.addAdressBtn);
            this.groupBox3.Controls.Add(this.countryText);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.cityText);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.blockText);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.HouseText);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.streetText);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(0, 458);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(358, 103);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Address Information";
            // 
            // ClearAddressBtn
            // 
            this.ClearAddressBtn.Location = new System.Drawing.Point(303, 76);
            this.ClearAddressBtn.Name = "ClearAddressBtn";
            this.ClearAddressBtn.Size = new System.Drawing.Size(45, 23);
            this.ClearAddressBtn.TabIndex = 44;
            this.ClearAddressBtn.Text = "Clear";
            this.ClearAddressBtn.UseVisualStyleBackColor = true;
            this.ClearAddressBtn.Click += new System.EventHandler(this.ClearAddressBtn_Click);
            // 
            // DeleteAddressBtn
            // 
            this.DeleteAddressBtn.Location = new System.Drawing.Point(248, 76);
            this.DeleteAddressBtn.Name = "DeleteAddressBtn";
            this.DeleteAddressBtn.Size = new System.Drawing.Size(49, 23);
            this.DeleteAddressBtn.TabIndex = 43;
            this.DeleteAddressBtn.Text = "Delete";
            this.DeleteAddressBtn.UseVisualStyleBackColor = true;
            this.DeleteAddressBtn.Click += new System.EventHandler(this.DeleteAddressBtn_Click);
            // 
            // EditAdressBtn
            // 
            this.EditAdressBtn.Location = new System.Drawing.Point(198, 76);
            this.EditAdressBtn.Name = "EditAdressBtn";
            this.EditAdressBtn.Size = new System.Drawing.Size(45, 23);
            this.EditAdressBtn.TabIndex = 42;
            this.EditAdressBtn.Text = "Edit";
            this.EditAdressBtn.UseVisualStyleBackColor = true;
            this.EditAdressBtn.Click += new System.EventHandler(this.EditAdressBtn_Click);
            // 
            // addAdressBtn
            // 
            this.addAdressBtn.Location = new System.Drawing.Point(147, 76);
            this.addAdressBtn.Name = "addAdressBtn";
            this.addAdressBtn.Size = new System.Drawing.Size(45, 23);
            this.addAdressBtn.TabIndex = 41;
            this.addAdressBtn.Text = "Add";
            this.addAdressBtn.UseVisualStyleBackColor = true;
            this.addAdressBtn.Click += new System.EventHandler(this.addAdressBtn_Click);
            // 
            // countryText
            // 
            this.countryText.Location = new System.Drawing.Point(197, 45);
            this.countryText.Name = "countryText";
            this.countryText.Size = new System.Drawing.Size(151, 23);
            this.countryText.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(147, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 15);
            this.label12.TabIndex = 40;
            this.label12.Text = "Country:";
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(197, 16);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(155, 23);
            this.cityText.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(147, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 15);
            this.label13.TabIndex = 38;
            this.label13.Text = "City:";
            // 
            // blockText
            // 
            this.blockText.Location = new System.Drawing.Point(47, 73);
            this.blockText.Name = "blockText";
            this.blockText.Size = new System.Drawing.Size(100, 23);
            this.blockText.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 15);
            this.label11.TabIndex = 36;
            this.label11.Text = "Blcok:";
            // 
            // HouseText
            // 
            this.HouseText.Location = new System.Drawing.Point(47, 45);
            this.HouseText.Name = "HouseText";
            this.HouseText.Size = new System.Drawing.Size(100, 23);
            this.HouseText.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 15);
            this.label10.TabIndex = 34;
            this.label10.Text = "House:";
            // 
            // streetText
            // 
            this.streetText.Location = new System.Drawing.Point(47, 16);
            this.streetText.Name = "streetText";
            this.streetText.Size = new System.Drawing.Size(100, 23);
            this.streetText.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 15);
            this.label9.TabIndex = 32;
            this.label9.Text = "Street:";
            // 
            // AddresssTextList
            // 
            this.AddresssTextList.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddresssTextList.FormattingEnabled = true;
            this.AddresssTextList.ItemHeight = 15;
            this.AddresssTextList.Location = new System.Drawing.Point(358, 458);
            this.AddresssTextList.Name = "AddresssTextList";
            this.AddresssTextList.Size = new System.Drawing.Size(296, 103);
            this.AddresssTextList.TabIndex = 4;
            this.AddresssTextList.SelectedIndexChanged += new System.EventHandler(this.AddresssTextList_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.EditBtn);
            this.panel4.Controls.Add(this.AddBtn);
            this.panel4.Controls.Add(this.ClearBtn);
            this.panel4.Controls.Add(this.DeleteBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(660, 458);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(195, 103);
            this.panel4.TabIndex = 5;
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(98, 15);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(72, 23);
            this.EditBtn.TabIndex = 36;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(8, 16);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(72, 23);
            this.AddBtn.TabIndex = 35;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(98, 68);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(72, 23);
            this.ClearBtn.TabIndex = 34;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(8, 68);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(72, 23);
            this.DeleteBtn.TabIndex = 33;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ManageCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 561);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.AddresssTextList);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ManageCustomers";
            this.Text = "ManageCustomers";
            this.Load += new System.EventHandler(this.ManageCustomers_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customersTable)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView customersTable;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker customerbirthDatePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CustomerPasswordText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CustomerEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CustomerPhoneText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerLNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerFNameText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button ClearTable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox valueText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ClearAddressBtn;
        private System.Windows.Forms.Button DeleteAddressBtn;
        private System.Windows.Forms.Button EditAdressBtn;
        private System.Windows.Forms.Button addAdressBtn;
        private System.Windows.Forms.TextBox countryText;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox cityText;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox blockText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox HouseText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox streetText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox AddresssTextList;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.TextBox Customer;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label14;
    }
}