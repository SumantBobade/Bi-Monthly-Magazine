using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiMonthlyBooklet
{
    
    public partial class UpdateRecordForm : Form
    {

        SqlDataAdapter adp;
        DataViewManager dsview;
        public void bind1()
        {
            SubType.DataBindings.Add("Text", dsview, "Subscription_Details.Subscription_Type");
            Sub_Language.DataBindings.Add("Text", dsview, "Subscription_Details.Language");
            Title.DataBindings.Add("Text", dsview, "Subscription_Details.Title");
            FName.DataBindings.Add("Text", dsview, "Subscription_Details.FName");
            MName.DataBindings.Add("Text", dsview, "Subscription_Details.MName");
            LName.DataBindings.Add("Text", dsview, "Subscription_Details.LName");
            Address.DataBindings.Add("Text", dsview, "Subscription_Details.Address");
            Center.DataBindings.Add("Text", dsview, "Subscription_Details.DeliveryLoaction");
            City.DataBindings.Add("Text", dsview, "Subscription_Details.City");
            State.DataBindings.Add("Text", dsview, "Subscription_Details.State");
            Country.DataBindings.Add("Text", dsview, "Subscription_Details.Country");
            PinCode.DataBindings.Add("Text", dsview, "Subscription_Details.Pincode");
            ContactNo1.DataBindings.Add("Text", dsview, "Subscription_Details.MobileNo");
            ContactNo2.DataBindings.Add("Text", dsview, "Subscription_Details.TelNo");

            BookedAtCenter.DataBindings.Add("Text", dsview, "Subscription_Details.BookedAtCenter");
            SubYears.DataBindings.Add("Text", dsview, "Subscription_Details.NoOfYear");
            StartDate.DataBindings.Add("Text", dsview, "Subscription_Details.StartDate");
            EndDate.DataBindings.Add("Text", dsview, "Subscription_Details.EndDate");

            NoOfCopies.DataBindings.Add("Text", dsview, "Subscription_Details.NoofCopies");
            CopiesIssued.DataBindings.Add("Text", dsview, "Subscription_Details.Copy_Issued");
            Comments.DataBindings.Add("Text", dsview, "Subscription_Details.Comments");
            AccNo.DataBindings.Add("Text", dsview, "Subscription_Details.AccNo");
            SubEmailId.DataBindings.Add("Text", dsview, "Subscription_Details.Sub_EmailID");
            Remarks.DataBindings.Add("Text", dsview, "Subscription_Details.Remarks");
        }

        public void bind2()
        {
            SubType.DataBindings.Clear();
            Sub_Language.DataBindings.Clear();
            Title.DataBindings.Clear();
            FName.DataBindings.Clear();
            MName.DataBindings.Clear();
            LName.DataBindings.Clear();
            Address.DataBindings.Clear();
            Center.DataBindings.Clear();
            City.DataBindings.Clear();
            State.DataBindings.Clear();
            Country.DataBindings.Clear();
            PinCode.DataBindings.Clear();
            ContactNo1.DataBindings.Clear();
            ContactNo2.DataBindings.Clear();

            BookedAtCenter.DataBindings.Clear(); 
            SubYears.DataBindings.Clear();
            StartDate.DataBindings.Clear();
            EndDate.DataBindings.Clear();

            NoOfCopies.DataBindings.Clear();
            CopiesIssued.DataBindings.Clear();
            Comments.DataBindings.Clear();
            AccNo.DataBindings.Clear();
            SubEmailId.DataBindings.Clear();
            Remarks.DataBindings.Clear();
        }
        public UpdateRecordForm()
        {
            InitializeComponent();
        }

        

        private void UpdateRecordForm_Load(object sender, EventArgs e)
        {

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

        }

        private void SubType_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            bind2();
            if (Sub_No.Text.Length != 0)
            {
                string sub_No = Sub_No.Text;
                adp = new SqlDataAdapter("Select * from Subscription_Details where Subscriber_no ='" + sub_No + "'", connection.con);
                DataSet ds = new DataSet();
                adp.Fill(ds, "Subscription_Details");
                DataTable dt = new DataTable();
                dt = ds.Tables["Subscription_Details"];
                dsview = ds.DefaultViewManager;
                bind1();
            }
            else
            {
                MessageBox.Show("Please enter the value of subscription No for search.");
            }
        }
    }
}
