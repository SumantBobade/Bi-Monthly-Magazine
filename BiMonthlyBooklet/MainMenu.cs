using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiMonthlyBooklet
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addNewRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewForm a1 = new AddNewForm();
            a1.MdiParent = this;
            a1.Show();
        }

        private void updateRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateRecordForm u1 = new UpdateRecordForm();
            u1.MdiParent = this;
            u1.Show();
        }

        private void viewAllRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewRecordForm v1 = new ViewRecordForm();
            v1.MdiParent = this;
            v1.Show();
        }

        private void generateRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateReportForm g1 = new GenerateReportForm();
            g1.MdiParent = this;
            g1.Show();
        }

        private void addNewComplaintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddingComplentForm a1 = new AddingComplentForm();
            a1.MdiParent = this;
            a1.Show();
        }

        private void viewAllComplaintsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewComplaintForm v1 = new ViewComplaintForm();
            v1.MdiParent = this;
            v1.Show();
        }

        private void updateCloseComplaintsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateComplaintForm u1 = new UpdateComplaintForm();
            u1.MdiParent = this;
            u1.Show();
        }
    }
}
