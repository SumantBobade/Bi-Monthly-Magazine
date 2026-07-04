namespace BiMonthlyBooklet
{
    partial class ViewRecordForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchOption = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Recipt_No = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Center = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Sub_No = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Language = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Sub_Validity = new System.Windows.Forms.ComboBox();
            this.Title = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.FName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.MName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.LName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.RichTextBox();
            this.City = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.State = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Country = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.MobileNo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Tel_No = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Pincode = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.AccNo = new System.Windows.Forms.TextBox();
            this.SearchSelectField = new System.Windows.Forms.Button();
            this.ViewAllRecords = new System.Windows.Forms.Button();
            this.CloseForm = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Search Option :-";
            // 
            // SearchOption
            // 
            this.SearchOption.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.SearchOption.FormattingEnabled = true;
            this.SearchOption.Items.AddRange(new object[] {
            "Recipt No",
            "Subscription No",
            "Title",
            "Name",
            "Address",
            "PinCode",
            "Mobile No",
            "Phone No",
            "Acc No.",
            "Language"});
            this.SearchOption.Location = new System.Drawing.Point(183, 10);
            this.SearchOption.Name = "SearchOption";
            this.SearchOption.Size = new System.Drawing.Size(161, 30);
            this.SearchOption.TabIndex = 1;
            this.SearchOption.SelectedIndexChanged += new System.EventHandler(this.SearchOption_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Recipt_No
            // 
            this.Recipt_No.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.Recipt_No.Location = new System.Drawing.Point(183, 46);
            this.Recipt_No.Name = "Recipt_No";
            this.Recipt_No.Size = new System.Drawing.Size(161, 29);
            this.Recipt_No.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label2.Location = new System.Drawing.Point(87, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Recipt No :-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label3.Location = new System.Drawing.Point(109, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Center :-";
            // 
            // Center
            // 
            this.Center.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.Center.FormattingEnabled = true;
            this.Center.Location = new System.Drawing.Point(183, 83);
            this.Center.Name = "Center";
            this.Center.Size = new System.Drawing.Size(161, 30);
            this.Center.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label4.Location = new System.Drawing.Point(364, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Subscription No :-";
            // 
            // Sub_No
            // 
            this.Sub_No.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.Sub_No.Location = new System.Drawing.Point(503, 10);
            this.Sub_No.Name = "Sub_No";
            this.Sub_No.Size = new System.Drawing.Size(161, 29);
            this.Sub_No.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label5.Location = new System.Drawing.Point(672, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Language :-";
            // 
            // Language
            // 
            this.Language.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.Language.Location = new System.Drawing.Point(768, 11);
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(161, 29);
            this.Language.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label6.Location = new System.Drawing.Point(364, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Subscription Validity :-";
            // 
            // Sub_Validity
            // 
            this.Sub_Validity.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.Sub_Validity.FormattingEnabled = true;
            this.Sub_Validity.Items.AddRange(new object[] {
            "Subscription Valid",
            "Last copy--Please Review",
            "Subscription Expand"});
            this.Sub_Validity.Location = new System.Drawing.Point(535, 50);
            this.Sub_Validity.Name = "Sub_Validity";
            this.Sub_Validity.Size = new System.Drawing.Size(161, 30);
            this.Sub_Validity.TabIndex = 12;
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.Title.FormattingEnabled = true;
            this.Title.Location = new System.Drawing.Point(87, 119);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(65, 30);
            this.Title.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label7.Location = new System.Drawing.Point(29, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Title :-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label8.Location = new System.Drawing.Point(163, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "First Name :-";
            // 
            // FName
            // 
            this.FName.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.FName.Location = new System.Drawing.Point(268, 120);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(161, 29);
            this.FName.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label9.Location = new System.Drawing.Point(441, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 22);
            this.label9.TabIndex = 18;
            this.label9.Text = "Middle Name :-";
            // 
            // MName
            // 
            this.MName.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.MName.Location = new System.Drawing.Point(564, 119);
            this.MName.Name = "MName";
            this.MName.Size = new System.Drawing.Size(161, 29);
            this.MName.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label10.Location = new System.Drawing.Point(734, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 22);
            this.label10.TabIndex = 20;
            this.label10.Text = "Last Name :-";
            // 
            // LName
            // 
            this.LName.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.LName.Location = new System.Drawing.Point(839, 119);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(161, 29);
            this.LName.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label11.Location = new System.Drawing.Point(13, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 22);
            this.label11.TabIndex = 21;
            this.label11.Text = "Address :-";
            // 
            // Address
            // 
            this.Address.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.Address.Location = new System.Drawing.Point(91, 160);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(171, 102);
            this.Address.TabIndex = 22;
            this.Address.Text = "";
            // 
            // City
            // 
            this.City.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.City.FormattingEnabled = true;
            this.City.Items.AddRange(new object[] {
            "Ahmedabad",
            "Amritsar",
            "Bengaluru",
            "Bhopal",
            "Chennai",
            "Delhi",
            "Hyderabad",
            "Indore",
            "Jaipur",
            "Kanpur",
            "Kochi",
            "Kolkata",
            "Lucknow",
            "Mumbai",
            "Nagpur",
            "Patna",
            "Pune",
            "Surat",
            "Visakhapatnam",
            "Wardha"});
            this.City.Location = new System.Drawing.Point(350, 157);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(103, 30);
            this.City.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label12.Location = new System.Drawing.Point(292, 163);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 22);
            this.label12.TabIndex = 23;
            this.label12.Text = "City :-";
            // 
            // State
            // 
            this.State.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.State.FormattingEnabled = true;
            this.State.Items.AddRange(new object[] {
            "Andhra Pradesh",
            "Arunachal Pradesh",
            "Assam",
            "Bihar",
            "Chhattisgarh",
            "Goa",
            "Gujarat",
            "Haryana",
            "Himachal Pradesh",
            "Jharkhand",
            "Karnataka",
            "Kerala",
            "Madhya Pradesh",
            "Maharashtra",
            "Manipur",
            "Meghalaya",
            "Mizoram",
            "Nagaland",
            "Odisha",
            "Punjab",
            "Rajasthan",
            "Sikkim",
            "Tamil Nadu",
            "Telangana",
            "Tripura",
            "Uttar Pradesh",
            "Uttarakhand",
            "West Bengal"});
            this.State.Location = new System.Drawing.Point(350, 193);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(103, 30);
            this.State.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label13.Location = new System.Drawing.Point(287, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 22);
            this.label13.TabIndex = 25;
            this.label13.Text = "State :-";
            // 
            // Country
            // 
            this.Country.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.Country.FormattingEnabled = true;
            this.Country.Items.AddRange(new object[] {
            "India",
            "UAE",
            "US",
            "UK"});
            this.Country.Location = new System.Drawing.Point(350, 229);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(103, 30);
            this.Country.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label14.Location = new System.Drawing.Point(264, 234);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 22);
            this.label14.TabIndex = 27;
            this.label14.Text = "Country :-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label15.Location = new System.Drawing.Point(467, 161);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 22);
            this.label15.TabIndex = 30;
            this.label15.Text = "Mobile No :-";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MobileNo
            // 
            this.MobileNo.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.MobileNo.Location = new System.Drawing.Point(566, 158);
            this.MobileNo.Name = "MobileNo";
            this.MobileNo.Size = new System.Drawing.Size(161, 29);
            this.MobileNo.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label16.Location = new System.Drawing.Point(469, 198);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 22);
            this.label16.TabIndex = 32;
            this.label16.Text = "Phone No :-";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Tel_No
            // 
            this.Tel_No.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.Tel_No.Location = new System.Drawing.Point(566, 193);
            this.Tel_No.Name = "Tel_No";
            this.Tel_No.Size = new System.Drawing.Size(161, 29);
            this.Tel_No.TabIndex = 31;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label17.Location = new System.Drawing.Point(481, 232);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 22);
            this.label17.TabIndex = 34;
            this.label17.Text = "Pincode :-";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Pincode
            // 
            this.Pincode.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.Pincode.Location = new System.Drawing.Point(566, 229);
            this.Pincode.Name = "Pincode";
            this.Pincode.Size = new System.Drawing.Size(161, 29);
            this.Pincode.TabIndex = 33;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label18.Location = new System.Drawing.Point(366, 271);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 22);
            this.label18.TabIndex = 36;
            this.label18.Text = "Acc No :-";
            // 
            // AccNo
            // 
            this.AccNo.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.AccNo.Location = new System.Drawing.Point(445, 268);
            this.AccNo.Name = "AccNo";
            this.AccNo.Size = new System.Drawing.Size(282, 29);
            this.AccNo.TabIndex = 35;
            // 
            // SearchSelectField
            // 
            this.SearchSelectField.BackColor = System.Drawing.SystemColors.Window;
            this.SearchSelectField.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.SearchSelectField.Location = new System.Drawing.Point(738, 160);
            this.SearchSelectField.Name = "SearchSelectField";
            this.SearchSelectField.Size = new System.Drawing.Size(262, 31);
            this.SearchSelectField.TabIndex = 37;
            this.SearchSelectField.Text = "Search From Selected Field";
            this.SearchSelectField.UseVisualStyleBackColor = false;
            this.SearchSelectField.Click += new System.EventHandler(this.SearchSelectField_Click);
            // 
            // ViewAllRecords
            // 
            this.ViewAllRecords.BackColor = System.Drawing.SystemColors.Window;
            this.ViewAllRecords.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.ViewAllRecords.Location = new System.Drawing.Point(738, 193);
            this.ViewAllRecords.Name = "ViewAllRecords";
            this.ViewAllRecords.Size = new System.Drawing.Size(262, 31);
            this.ViewAllRecords.TabIndex = 38;
            this.ViewAllRecords.Text = "View All Records";
            this.ViewAllRecords.UseVisualStyleBackColor = false;
            // 
            // CloseForm
            // 
            this.CloseForm.BackColor = System.Drawing.SystemColors.Window;
            this.CloseForm.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.CloseForm.Location = new System.Drawing.Point(738, 230);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(262, 31);
            this.CloseForm.TabIndex = 39;
            this.CloseForm.Text = "Close Form";
            this.CloseForm.UseVisualStyleBackColor = false;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.Window;
            this.Clear.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.Clear.Location = new System.Drawing.Point(738, 266);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(262, 31);
            this.Clear.TabIndex = 40;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            // 
            // GridView
            // 
            this.GridView.AllowUserToOrderColumns = true;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Location = new System.Drawing.Point(12, 318);
            this.GridView.Name = "GridView";
            this.GridView.Size = new System.Drawing.Size(1006, 267);
            this.GridView.TabIndex = 41;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label19.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label19.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label19.Location = new System.Drawing.Point(350, 591);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(463, 23);
            this.label19.TabIndex = 42;
            // 
            // ViewRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1030, 622);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.CloseForm);
            this.Controls.Add(this.ViewAllRecords);
            this.Controls.Add(this.SearchSelectField);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.AccNo);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Pincode);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Tel_No);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.MobileNo);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.State);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.City);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.MName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.FName);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Sub_Validity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Language);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Sub_No);
            this.Controls.Add(this.Center);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Recipt_No);
            this.Controls.Add(this.SearchOption);
            this.Controls.Add(this.label1);
            this.Name = "ViewRecordForm";
            this.Text = "Bi Monthly Magazine View Record Form";
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SearchOption;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox Recipt_No;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Center;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Sub_No;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Language;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Sub_Validity;
        private System.Windows.Forms.ComboBox Title;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox FName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox MName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox LName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox Address;
        private System.Windows.Forms.ComboBox City;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox State;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox Country;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox MobileNo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Tel_No;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox Pincode;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox AccNo;
        private System.Windows.Forms.Button SearchSelectField;
        private System.Windows.Forms.Button ViewAllRecords;
        private System.Windows.Forms.Button CloseForm;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.Label label19;
    }
}