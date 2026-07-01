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
    }
}
