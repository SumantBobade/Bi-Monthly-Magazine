namespace BiMonthlyBooklet
{
    partial class MainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.complaintsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewComplaintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllComplaintsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCloseComplaintsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.complaintsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewRecordToolStripMenuItem,
            this.updateRecordToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // addNewRecordToolStripMenuItem
            // 
            this.addNewRecordToolStripMenuItem.Name = "addNewRecordToolStripMenuItem";
            this.addNewRecordToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.addNewRecordToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.addNewRecordToolStripMenuItem.Text = "&Add New Record";
            this.addNewRecordToolStripMenuItem.Click += new System.EventHandler(this.addNewRecordToolStripMenuItem_Click);
            // 
            // updateRecordToolStripMenuItem
            // 
            this.updateRecordToolStripMenuItem.Name = "updateRecordToolStripMenuItem";
            this.updateRecordToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.U)));
            this.updateRecordToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.updateRecordToolStripMenuItem.Text = "&Update Record";
            this.updateRecordToolStripMenuItem.Click += new System.EventHandler(this.updateRecordToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllRecordsToolStripMenuItem,
            this.generateRecordsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.viewToolStripMenuItem.Text = "&View/Reports";
            // 
            // viewAllRecordsToolStripMenuItem
            // 
            this.viewAllRecordsToolStripMenuItem.Name = "viewAllRecordsToolStripMenuItem";
            this.viewAllRecordsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.viewAllRecordsToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.viewAllRecordsToolStripMenuItem.Text = "View All &Records";
            this.viewAllRecordsToolStripMenuItem.Click += new System.EventHandler(this.viewAllRecordsToolStripMenuItem_Click);
            // 
            // generateRecordsToolStripMenuItem
            // 
            this.generateRecordsToolStripMenuItem.Name = "generateRecordsToolStripMenuItem";
            this.generateRecordsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.G)));
            this.generateRecordsToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.generateRecordsToolStripMenuItem.Text = "&Generate Records";
            this.generateRecordsToolStripMenuItem.Click += new System.EventHandler(this.generateRecordsToolStripMenuItem_Click);
            // 
            // complaintsToolStripMenuItem
            // 
            this.complaintsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewComplaintToolStripMenuItem,
            this.viewAllComplaintsToolStripMenuItem,
            this.updateCloseComplaintsToolStripMenuItem});
            this.complaintsToolStripMenuItem.Name = "complaintsToolStripMenuItem";
            this.complaintsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.complaintsToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.complaintsToolStripMenuItem.Text = "&Complaints";
            // 
            // addNewComplaintToolStripMenuItem
            // 
            this.addNewComplaintToolStripMenuItem.Name = "addNewComplaintToolStripMenuItem";
            this.addNewComplaintToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.addNewComplaintToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.addNewComplaintToolStripMenuItem.Text = "Add &New Complaint";
            this.addNewComplaintToolStripMenuItem.Click += new System.EventHandler(this.addNewComplaintToolStripMenuItem_Click);
            // 
            // viewAllComplaintsToolStripMenuItem
            // 
            this.viewAllComplaintsToolStripMenuItem.Name = "viewAllComplaintsToolStripMenuItem";
            this.viewAllComplaintsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.viewAllComplaintsToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.viewAllComplaintsToolStripMenuItem.Text = "&View All Complaints";
            this.viewAllComplaintsToolStripMenuItem.Click += new System.EventHandler(this.viewAllComplaintsToolStripMenuItem_Click);
            // 
            // updateCloseComplaintsToolStripMenuItem
            // 
            this.updateCloseComplaintsToolStripMenuItem.Name = "updateCloseComplaintsToolStripMenuItem";
            this.updateCloseComplaintsToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.updateCloseComplaintsToolStripMenuItem.Text = "Update/Close Complaints";
            this.updateCloseComplaintsToolStripMenuItem.Click += new System.EventHandler(this.updateCloseComplaintsToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "Bi Monthly Magazine Main Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem complaintsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewComplaintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllComplaintsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCloseComplaintsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}