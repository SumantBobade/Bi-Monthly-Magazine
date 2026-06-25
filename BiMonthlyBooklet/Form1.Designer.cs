namespace BiMonthlyBooklet
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter UserName:-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Password:-";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(202, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(202, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(169, 20);
            this.textBox2.TabIndex = 3;
            // 
            // login_btn
            // 
            this.login_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.Location = new System.Drawing.Point(44, 129);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(88, 31);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "&Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.Location = new System.Drawing.Point(283, 129);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(88, 31);
            this.exit_btn.TabIndex = 5;
            this.exit_btn.Text = "&Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // Clear_btn
            // 
            this.Clear_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_btn.Location = new System.Drawing.Point(164, 129);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(88, 31);
            this.Clear_btn.TabIndex = 6;
            this.Clear_btn.Text = "&Clear";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 195);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button Clear_btn;
    }
}

