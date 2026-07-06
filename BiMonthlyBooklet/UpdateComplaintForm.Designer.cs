namespace BiMonthlyBooklet
{
    partial class UpdateComplaintForm
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
            this.Exit = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.ComResolve = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ResolveDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.ComDate = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.ComDetails = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SubName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SubNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ComID = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.Exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Exit.Location = new System.Drawing.Point(321, 411);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(124, 32);
            this.Exit.TabIndex = 73;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.Clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Clear.Location = new System.Drawing.Point(191, 411);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(124, 32);
            this.Clear.TabIndex = 72;
            this.Clear.Text = "&Clear";
            this.Clear.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.Update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Update.Location = new System.Drawing.Point(55, 411);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(127, 32);
            this.Update.TabIndex = 71;
            this.Update.Text = "&Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ComResolve
            // 
            this.ComResolve.Enabled = false;
            this.ComResolve.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.ComResolve.FormattingEnabled = true;
            this.ComResolve.Items.AddRange(new object[] {
            "---",
            "Yes",
            "No"});
            this.ComResolve.Location = new System.Drawing.Point(173, 328);
            this.ComResolve.Name = "ComResolve";
            this.ComResolve.Size = new System.Drawing.Size(246, 30);
            this.ComResolve.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label5.Location = new System.Drawing.Point(18, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 22);
            this.label5.TabIndex = 69;
            this.label5.Text = "Complanit Resolve :-";
            // 
            // ResolveDate
            // 
            this.ResolveDate.Enabled = false;
            this.ResolveDate.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.ResolveDate.Location = new System.Drawing.Point(173, 364);
            this.ResolveDate.Name = "ResolveDate";
            this.ResolveDate.Size = new System.Drawing.Size(272, 29);
            this.ResolveDate.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label4.Location = new System.Drawing.Point(58, 369);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(109, 22);
            this.label4.TabIndex = 67;
            this.label4.Text = "Resolve Date :-";
            // 
            // ComDate
            // 
            this.ComDate.Enabled = false;
            this.ComDate.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.ComDate.Location = new System.Drawing.Point(173, 287);
            this.ComDate.Name = "ComDate";
            this.ComDate.Size = new System.Drawing.Size(272, 29);
            this.ComDate.TabIndex = 66;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label22.Location = new System.Drawing.Point(41, 291);
            this.label22.Name = "label22";
            this.label22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label22.Size = new System.Drawing.Size(126, 22);
            this.label22.TabIndex = 65;
            this.label22.Text = "Conplaint Date :-";
            // 
            // ComDetails
            // 
            this.ComDetails.Enabled = false;
            this.ComDetails.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.ComDetails.Location = new System.Drawing.Point(173, 140);
            this.ComDetails.Name = "ComDetails";
            this.ComDetails.Size = new System.Drawing.Size(246, 127);
            this.ComDetails.TabIndex = 64;
            this.ComDetails.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label3.Location = new System.Drawing.Point(22, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 22);
            this.label3.TabIndex = 63;
            this.label3.Text = "Complaint Details :-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label2.Location = new System.Drawing.Point(32, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 22);
            this.label2.TabIndex = 62;
            this.label2.Text = "Subsciber Name :-";
            // 
            // SubName
            // 
            this.SubName.Enabled = false;
            this.SubName.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.SubName.Location = new System.Drawing.Point(173, 96);
            this.SubName.Name = "SubName";
            this.SubName.Size = new System.Drawing.Size(247, 29);
            this.SubName.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label1.Location = new System.Drawing.Point(47, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 60;
            this.label1.Text = "Subscriber No :-";
            // 
            // SubNo
            // 
            this.SubNo.Enabled = false;
            this.SubNo.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.SubNo.Location = new System.Drawing.Point(173, 48);
            this.SubNo.Name = "SubNo";
            this.SubNo.Size = new System.Drawing.Size(247, 29);
            this.SubNo.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label8.Location = new System.Drawing.Point(51, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 22);
            this.label8.TabIndex = 58;
            this.label8.Text = "Complaint ID :-";
            // 
            // ComID
            // 
            this.ComID.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.ComID.Location = new System.Drawing.Point(173, 7);
            this.ComID.Name = "ComID";
            this.ComID.Size = new System.Drawing.Size(247, 29);
            this.ComID.TabIndex = 57;
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.Search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Search.Location = new System.Drawing.Point(439, 7);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(89, 32);
            this.Search.TabIndex = 74;
            this.Search.Text = "&Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // UpdateComplaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 460);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.ComResolve);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ResolveDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComDate);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.ComDetails);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SubName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ComID);
            this.Name = "UpdateComplaintForm";
            this.Text = "Bi Monthly Magazine UpdateComplaintForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.ComboBox ComResolve;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker ResolveDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker ComDate;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.RichTextBox ComDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SubName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SubNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ComID;
        private System.Windows.Forms.Button Search;
    }
}