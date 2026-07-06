using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace BiMonthlyBooklet
{
    public partial class UpdateComplaintForm : Form
    {
        SqlDataAdapter adp;
        DataViewManager dview;
        DataSet ds = new DataSet();

        public UpdateComplaintForm()
        {
            InitializeComponent();
        }

        public void bind1()
        {
            SubNo.DataBindings.Add("Text", dview, "Complaint_Data.Subscriber_No");
            SubName.DataBindings.Add("Text", dview, "Complaint_Data.Subscriber_Name");
            ComDetails.DataBindings.Add("Text", dview, "Complaint_Data.Complaint_Details");
            ComDate.DataBindings.Add("Text", dview, "Complaint_Data.Complaint_Date");
            ComResolve.DataBindings.Add("Text", dview, "Complaint_Data.Complaint_Resolve");
            ResolveDate.DataBindings.Add("Text", dview, "Complaint_Data.Resolve_Date");
        }

        public void bind2()
        {
            SubNo.DataBindings.Clear();
            SubName.DataBindings.Clear();
            ComDetails.DataBindings.Clear();
            ComDate.DataBindings.Clear();
            ComResolve.DataBindings.Clear();
            ResolveDate.DataBindings.Clear();
        }

        public void enable1()
        {
            
            ComDetails.Enabled = true;
            ComResolve.Enabled = true;
            ResolveDate.Enabled = true;
        }

        public void disable1()
        {
            SubNo.Enabled = false;
            SubName.Enabled = false;
            ComDetails.Enabled = false;
            ComDate.Enabled = false;
            ComResolve.Enabled = false;
            ResolveDate.Enabled = false;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            bind2();
            if(ComID.Text != "")
            {
                adp = new SqlDataAdapter("Select * from Complaint_Data where Complaint_ID='"+ComID.Text+"';", connection.con);
                adp.Fill(ds, "Complaint_Data");
                DataTable dt = new DataTable();
                dt = ds.Tables["Complaint_Data"];
                dview = ds.DefaultViewManager;
                bind1();
                enable1();

            }
            else
            {
                disable1();
                MessageBox.Show("Please enter the complaint id to search");
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("Update Complaint_Data set Complaint_Details='" + ComDetails.Text + "', Complaint_Resolve='" + ComResolve.Text + "', Resolve_Date='" + ResolveDate.Text + "' Where Complaint_ID='" + ComID.Text + "'", connection.con);
            connection.con.Open();
            int i = comm.ExecuteNonQuery();
            MessageBox.Show(i+" Records Added");
            connection.con.Close();

            ComID.Text = "";
            SubNo.Text = "";
            SubName.Text = "";
            ComDetails.Text = "";
            ComDate.Value = DateTime.Now;
            ComResolve.Text = "";
            ResolveDate.Value = DateTime.Now;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ComID.Text = "";
            SubNo.Text = "";
            SubName.Text = "";
            ComDetails.Text = "";
            ComDate.Value = DateTime.Now;
            ComResolve.Text = "";
            ResolveDate.Value = DateTime.Now;
            disable1();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
