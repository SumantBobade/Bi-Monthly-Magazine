namespace BiMonthlyBooklet
{
    partial class AddNewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Language = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SubNo = new System.Windows.Forms.TextBox();
            this.ReciptNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.ComboBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.MiddleName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.ComboBox();
            this.State = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Country = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.PinCode = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ContactPerson = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.MobileNo = new System.Windows.Forms.TextBox();
            this.TelNo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CenterName = new System.Windows.Forms.ComboBox();
            this.AtCenter = new System.Windows.Forms.RadioButton();
            this.Direct = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.year5 = new System.Windows.Forms.RadioButton();
            this.year3 = new System.Windows.Forms.RadioButton();
            this.year1 = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.AccNo = new System.Windows.Forms.TextBox();
            this.BookAtCenter = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.CopyIssued = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.SubEmail = new System.Windows.Forms.TextBox();
            this.AddRecord = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(430, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 91);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insights for the fast-evolving digital world.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.Language);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.groupBox1.Location = new System.Drawing.Point(16, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 61);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Subscriber Language";
            // 
            // Language
            // 
            this.Language.AllowDrop = true;
            this.Language.FormattingEnabled = true;
            this.Language.Items.AddRange(new object[] {
            "English",
            "Hindi"});
            this.Language.Location = new System.Drawing.Point(61, 25);
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(152, 30);
            this.Language.TabIndex = 0;
            this.Language.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label2.Location = new System.Drawing.Point(240, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subscription No:-";
            // 
            // SubNo
            // 
            this.SubNo.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.SubNo.Location = new System.Drawing.Point(375, 105);
            this.SubNo.Name = "SubNo";
            this.SubNo.Size = new System.Drawing.Size(149, 29);
            this.SubNo.TabIndex = 4;
            // 
            // ReciptNo
            // 
            this.ReciptNo.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.ReciptNo.Location = new System.Drawing.Point(631, 105);
            this.ReciptNo.Name = "ReciptNo";
            this.ReciptNo.Size = new System.Drawing.Size(156, 29);
            this.ReciptNo.TabIndex = 6;
            this.ReciptNo.TextChanged += new System.EventHandler(this.ReciptNo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label3.Location = new System.Drawing.Point(539, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Recipt No:-";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label4.Location = new System.Drawing.Point(12, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name:-";
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.Title.FormattingEnabled = true;
            this.Title.Items.AddRange(new object[] {
            "Mr.",
            "Mrs.",
            "Miss.",
            "Mst."});
            this.Title.Location = new System.Drawing.Point(79, 169);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(74, 30);
            this.Title.TabIndex = 8;
            // 
            // FirstName
            // 
            this.FirstName.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.FirstName.Location = new System.Drawing.Point(180, 170);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(149, 29);
            this.FirstName.TabIndex = 9;
            // 
            // MiddleName
            // 
            this.MiddleName.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.MiddleName.Location = new System.Drawing.Point(366, 169);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(149, 29);
            this.MiddleName.TabIndex = 10;
            // 
            // LastName
            // 
            this.LastName.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.LastName.Location = new System.Drawing.Point(543, 169);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(149, 29);
            this.LastName.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label5.Location = new System.Drawing.Point(92, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label6.Location = new System.Drawing.Point(211, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "First Name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label7.Location = new System.Drawing.Point(391, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "Middle Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label8.Location = new System.Drawing.Point(585, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "Last Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label9.Location = new System.Drawing.Point(12, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 22);
            this.label9.TabIndex = 16;
            this.label9.Text = "Address:-";
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(91, 249);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(238, 96);
            this.Address.TabIndex = 17;
            this.Address.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label10.Location = new System.Drawing.Point(362, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 22);
            this.label10.TabIndex = 18;
            this.label10.Text = "City:-";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // City
            // 
            this.City.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.City.FormattingEnabled = true;
            this.City.Items.AddRange(new object[] {
            "Ahmedabad",
            "",
            "",
            "Amritsar",
            "",
            "",
            "Bengaluru",
            "",
            "",
            "Bhopal",
            "",
            "",
            "Chennai",
            "",
            "",
            "Delhi",
            "",
            "",
            "Hyderabad",
            "",
            "",
            "Indore",
            "",
            "",
            "Jaipur",
            "",
            "",
            "Kanpur",
            "",
            "",
            "Kochi",
            "",
            "",
            "Kolkata",
            "",
            "",
            "Lucknow",
            "",
            "",
            "Mumbai",
            "",
            "",
            "Nagpur",
            "",
            "",
            "Patna",
            "",
            "",
            "Pune",
            "",
            "",
            "Surat",
            "",
            "",
            "Visakhapatnam",
            "",
            "",
            "Wardha"});
            this.City.Location = new System.Drawing.Point(416, 246);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(129, 30);
            this.City.TabIndex = 19;
            // 
            // State
            // 
            this.State.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.State.FormattingEnabled = true;
            this.State.Items.AddRange(new object[] {
            "",
            "Andhra Pradesh",
            "",
            "Arunachal Pradesh",
            "",
            "Assam",
            "",
            "Bihar",
            "",
            "Chhattisgarh",
            "",
            "Goa",
            "",
            "Gujarat",
            "",
            "Haryana",
            "",
            "Himachal Pradesh",
            "",
            "Jharkhand",
            "",
            "Karnataka",
            "",
            "Kerala",
            "",
            "Madhya Pradesh",
            "",
            "Maharashtra",
            "",
            "Manipur",
            "",
            "Meghalaya",
            "",
            "Mizoram",
            "",
            "Nagaland",
            "",
            "Odisha",
            "",
            "Punjab",
            "",
            "Rajasthan",
            "",
            "Sikkim",
            "",
            "Tamil Nadu",
            "",
            "Telangana",
            "",
            "Tripura",
            "",
            "Uttar Pradesh",
            "",
            "Uttarakhand",
            "",
            "West Bengal"});
            this.State.Location = new System.Drawing.Point(416, 279);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(129, 30);
            this.State.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label11.Location = new System.Drawing.Point(362, 282);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 22);
            this.label11.TabIndex = 20;
            this.label11.Text = "State:-";
            // 
            // Country
            // 
            this.Country.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.Country.FormattingEnabled = true;
            this.Country.Items.AddRange(new object[] {
            "Mr.",
            "Mrs.",
            "Miss.",
            "Mst."});
            this.Country.Location = new System.Drawing.Point(416, 315);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(129, 30);
            this.Country.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label12.Location = new System.Drawing.Point(339, 318);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 22);
            this.label12.TabIndex = 22;
            this.label12.Text = "Country:-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label13.Location = new System.Drawing.Point(577, 246);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 22);
            this.label13.TabIndex = 24;
            this.label13.Text = "Pin Code:-";
            // 
            // PinCode
            // 
            this.PinCode.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.PinCode.Location = new System.Drawing.Point(664, 246);
            this.PinCode.Name = "PinCode";
            this.PinCode.Size = new System.Drawing.Size(123, 29);
            this.PinCode.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label14.Location = new System.Drawing.Point(12, 371);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 22);
            this.label14.TabIndex = 26;
            this.label14.Text = "Contact Person:-";
            // 
            // ContactPerson
            // 
            this.ContactPerson.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.ContactPerson.FormattingEnabled = true;
            this.ContactPerson.Items.AddRange(new object[] {
            "Subscriber Himself",
            "Sponserer"});
            this.ContactPerson.Location = new System.Drawing.Point(140, 368);
            this.ContactPerson.Name = "ContactPerson";
            this.ContactPerson.Size = new System.Drawing.Size(147, 30);
            this.ContactPerson.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label15.Location = new System.Drawing.Point(293, 371);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 22);
            this.label15.TabIndex = 28;
            this.label15.Text = "Mobile No:-";
            // 
            // MobileNo
            // 
            this.MobileNo.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.MobileNo.Location = new System.Drawing.Point(390, 369);
            this.MobileNo.Name = "MobileNo";
            this.MobileNo.Size = new System.Drawing.Size(166, 29);
            this.MobileNo.TabIndex = 29;
            // 
            // TelNo
            // 
            this.TelNo.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.TelNo.Location = new System.Drawing.Point(631, 369);
            this.TelNo.Name = "TelNo";
            this.TelNo.Size = new System.Drawing.Size(160, 29);
            this.TelNo.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label16.Location = new System.Drawing.Point(562, 372);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 22);
            this.label16.TabIndex = 30;
            this.label16.Text = "Tel No:-";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.CenterName);
            this.groupBox2.Controls.Add(this.AtCenter);
            this.groupBox2.Controls.Add(this.Direct);
            this.groupBox2.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.groupBox2.Location = new System.Drawing.Point(16, 418);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 61);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mode of Delivery";
            // 
            // CenterName
            // 
            this.CenterName.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.CenterName.FormattingEnabled = true;
            this.CenterName.Items.AddRange(new object[] {
            "Mr.",
            "Mrs.",
            "Miss.",
            "Mst."});
            this.CenterName.Location = new System.Drawing.Point(164, 25);
            this.CenterName.Name = "CenterName";
            this.CenterName.Size = new System.Drawing.Size(107, 30);
            this.CenterName.TabIndex = 32;
            this.CenterName.SelectedIndexChanged += new System.EventHandler(this.CenterName_SelectedIndexChanged);
            // 
            // AtCenter
            // 
            this.AtCenter.AutoSize = true;
            this.AtCenter.Location = new System.Drawing.Point(75, 29);
            this.AtCenter.Name = "AtCenter";
            this.AtCenter.Size = new System.Drawing.Size(92, 26);
            this.AtCenter.TabIndex = 1;
            this.AtCenter.TabStop = true;
            this.AtCenter.Text = "At Center";
            this.AtCenter.UseVisualStyleBackColor = true;
            // 
            // Direct
            // 
            this.Direct.AutoSize = true;
            this.Direct.Location = new System.Drawing.Point(7, 29);
            this.Direct.Name = "Direct";
            this.Direct.Size = new System.Drawing.Size(69, 26);
            this.Direct.TabIndex = 0;
            this.Direct.TabStop = true;
            this.Direct.Text = "Direct";
            this.Direct.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.year5);
            this.groupBox3.Controls.Add(this.year3);
            this.groupBox3.Controls.Add(this.year1);
            this.groupBox3.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.groupBox3.Location = new System.Drawing.Point(312, 418);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(313, 61);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Subscription No. Of Year";
            // 
            // year5
            // 
            this.year5.AutoSize = true;
            this.year5.Location = new System.Drawing.Point(232, 29);
            this.year5.Name = "year5";
            this.year5.Size = new System.Drawing.Size(71, 26);
            this.year5.TabIndex = 2;
            this.year5.TabStop = true;
            this.year5.Text = "5 Year";
            this.year5.UseVisualStyleBackColor = true;
            // 
            // year3
            // 
            this.year3.AutoSize = true;
            this.year3.Location = new System.Drawing.Point(117, 29);
            this.year3.Name = "year3";
            this.year3.Size = new System.Drawing.Size(71, 26);
            this.year3.TabIndex = 1;
            this.year3.TabStop = true;
            this.year3.Text = "3 Year";
            this.year3.UseVisualStyleBackColor = true;
            // 
            // year1
            // 
            this.year1.AutoSize = true;
            this.year1.Location = new System.Drawing.Point(7, 29);
            this.year1.Name = "year1";
            this.year1.Size = new System.Drawing.Size(71, 26);
            this.year1.TabIndex = 0;
            this.year1.TabStop = true;
            this.year1.Text = "1 Year";
            this.year1.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label17.Location = new System.Drawing.Point(631, 418);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 22);
            this.label17.TabIndex = 34;
            this.label17.Text = "Acc No:-";
            // 
            // AccNo
            // 
            this.AccNo.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.AccNo.Location = new System.Drawing.Point(635, 447);
            this.AccNo.Name = "AccNo";
            this.AccNo.Size = new System.Drawing.Size(160, 29);
            this.AccNo.TabIndex = 35;
            // 
            // BookAtCenter
            // 
            this.BookAtCenter.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.BookAtCenter.FormattingEnabled = true;
            this.BookAtCenter.Items.AddRange(new object[] {
            "Subscriber Himself",
            "Sponserer"});
            this.BookAtCenter.Location = new System.Drawing.Point(150, 491);
            this.BookAtCenter.Name = "BookAtCenter";
            this.BookAtCenter.Size = new System.Drawing.Size(147, 30);
            this.BookAtCenter.TabIndex = 37;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label18.Location = new System.Drawing.Point(12, 494);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(137, 22);
            this.label18.TabIndex = 36;
            this.label18.Text = "Booked At Center:-";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label19.Location = new System.Drawing.Point(308, 491);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 22);
            this.label19.TabIndex = 38;
            this.label19.Text = "Start Date:-";
            // 
            // StartDate
            // 
            this.StartDate.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.StartDate.Location = new System.Drawing.Point(395, 489);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(154, 29);
            this.StartDate.TabIndex = 39;
            // 
            // EndDate
            // 
            this.EndDate.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.EndDate.Location = new System.Drawing.Point(640, 489);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(155, 29);
            this.EndDate.TabIndex = 41;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label20.Location = new System.Drawing.Point(555, 491);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 22);
            this.label20.TabIndex = 40;
            this.label20.Text = "End Date:-";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label21.Location = new System.Drawing.Point(12, 528);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(102, 22);
            this.label21.TabIndex = 42;
            this.label21.Text = "Copy Issued:-";
            // 
            // CopyIssued
            // 
            this.CopyIssued.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.CopyIssued.Location = new System.Drawing.Point(120, 525);
            this.CopyIssued.Name = "CopyIssued";
            this.CopyIssued.Size = new System.Drawing.Size(94, 29);
            this.CopyIssued.TabIndex = 43;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label22.Location = new System.Drawing.Point(227, 528);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(113, 22);
            this.label22.TabIndex = 44;
            this.label22.Text = "Sub-Email-ID:-";
            // 
            // SubEmail
            // 
            this.SubEmail.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.SubEmail.Location = new System.Drawing.Point(346, 524);
            this.SubEmail.Name = "SubEmail";
            this.SubEmail.Size = new System.Drawing.Size(160, 29);
            this.SubEmail.TabIndex = 45;
            // 
            // AddRecord
            // 
            this.AddRecord.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddRecord.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.AddRecord.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddRecord.Location = new System.Drawing.Point(512, 525);
            this.AddRecord.Name = "AddRecord";
            this.AddRecord.Size = new System.Drawing.Size(146, 29);
            this.AddRecord.TabIndex = 46;
            this.AddRecord.Text = "Add Record";
            this.AddRecord.UseVisualStyleBackColor = false;
            this.AddRecord.Click += new System.EventHandler(this.AddRecord_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Clear.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.Clear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Clear.Location = new System.Drawing.Point(664, 524);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(131, 29);
            this.Clear.TabIndex = 47;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // AddNewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(811, 572);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.AddRecord);
            this.Controls.Add(this.SubEmail);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.CopyIssued);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.BookAtCenter);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.AccNo);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.TelNo);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.MobileNo);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ContactPerson);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.PinCode);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.State);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.City);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.MiddleName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ReciptNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SubNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddNewForm";
            this.Text = "Bi Monthly Add New Record Form";
            this.Load += new System.EventHandler(this.AddNewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Language;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SubNo;
        private System.Windows.Forms.TextBox ReciptNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Title;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox MiddleName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox Address;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox City;
        private System.Windows.Forms.ComboBox State;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox Country;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox PinCode;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox ContactPerson;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox MobileNo;
        private System.Windows.Forms.TextBox TelNo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CenterName;
        private System.Windows.Forms.RadioButton AtCenter;
        private System.Windows.Forms.RadioButton Direct;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton year3;
        private System.Windows.Forms.RadioButton year1;
        private System.Windows.Forms.RadioButton year5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox AccNo;
        private System.Windows.Forms.ComboBox BookAtCenter;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox CopyIssued;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox SubEmail;
        private System.Windows.Forms.Button AddRecord;
        private System.Windows.Forms.Button Clear;
    }
}