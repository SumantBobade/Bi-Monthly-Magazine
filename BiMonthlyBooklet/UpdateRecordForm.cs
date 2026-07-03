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
            Center.DataBindings.Add("Text", dsview, "Subscription_Details.DeliveryLocation");
            City.DataBindings.Add("Text", dsview, "Subscription_Details.City");
            State.DataBindings.Add("Text", dsview, "Subscription_Details.State");
            Country.DataBindings.Add("Text", dsview, "Subscription_Details.Country");
            PinCode.DataBindings.Add("Text", dsview, "Subscription_Details.Pincode");
            ContactNo1.DataBindings.Add("Text", dsview, "Subscription_Details.MobileNo");
            ContactNo2.DataBindings.Add("Text", dsview, "Subscription_Details.PhoneNo");

            BookedAtCenter.DataBindings.Add("Text", dsview, "Subscription_Details.BookedAt");
            SubYears.DataBindings.Add("Text", dsview, "Subscription_Details.NoofYear");
            StartDate.DataBindings.Add("Text", dsview, "Subscription_Details.Sub_StartDate");
            EndDate.DataBindings.Add("Text", dsview, "Subscription_Details.Sub_EndDate");

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
            string vsno, vrno, vstype, vlang, vtitle, vfname, vmname, vlname,
                vaddress, vcenter, vcity, vstate, vcountry, vpin, vmobno, vphone, vbooked,
                vnoofyear, vnoofcopy, vcopy_issued, vcomments, vaccno, vsubemailid, vremarks;

            vsno = Sub_No.Text;
            vrno = Recipt_No.Text;
            vstype = Sub_No.Text;
            vlang = Sub_Language.Text;
            vtitle = Title.Text;
            vfname = FName.Text;
            vmname = MName.Text;
            vlname = LName.Text;
            vaddress = Address.Text;
            vcenter = Center.Text;
            vcity = City.Text;
            vstate = State.Text;
            vcountry = Country.Text;
            vpin = PinCode.Text;
            vmobno = ContactNo1.Text;
            vphone = ContactNo2.Text;
            vbooked = BookedAtCenter.Text;
            vnoofyear = SubYears.Text;
            vnoofcopy = NoOfCopies.Text;
            vcopy_issued = CopiesIssued.Text;
            vaccno = AccNo.Text;
            vsubemailid = SubEmailId.Text;
            vcomments = Comments.Text;
            vremarks = Remarks.Text;

            SqlCommand comm;
            string strupdate =
    "UPDATE Subscription_Details SET " +
    "Receipt_no='" + vrno + "', " +
    "Subscription_Type='" + vstype + "', " +
    "Language='" + vlang + "', " +
    "Title='" + vtitle + "', " +
    "FName='" + vfname + "', " +
    "MName='" + vmname + "', " +
    "LName='" + vlname + "', " +
    "Address='" + vaddress + "', " +
    "DeliveryLocation='" + vcenter + "', " +
    "City='" + vcity + "', " +
    "State='" + vstate + "', " +
    "Country='" + vcountry + "', " +
    "Pincode='" + vpin + "', " +
    "MobileNo='" + vmobno + "', " +
    "PhoneNo='" + vphone + "', " +
    "BookedAt='" + vbooked + "', " +
    "NoofYear='" + vnoofyear + "', " +
    "NoofCopies='" + vnoofcopy + "', " +
    "Copy_Issued='" + vcopy_issued + "', " +
    "Comments='" + vcomments + "', " +
    "Remarks='" + vremarks + "', " +
    "AccNo='" + vaccno + "', " +
    "Sub_EmailID='" + vsubemailid + "' " +
    "WHERE Subscriber_no='" + vsno + "'";

            comm = new SqlCommand(strupdate, connection.con);
            comm.Parameters.Add("@Sub_StartDate", SqlDbType.SmallDateTime).Value = StartDate.Text;
            comm.Parameters.Add("@Sub_EndDate", SqlDbType.SmallDateTime).Value = EndDate.Text;

            connection.con.Open();
            int i = comm.ExecuteNonQuery();
            MessageBox.Show(i + " Record/s Updated.");
            connection.con.Close();
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

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearData()
        {
            SubType.Text = "";
            Sub_Language.Text = ""; ;
            Title.Text = "";
            FName.Text = "";
            MName.Text = "";
            LName.Text = "";
            Address.Text = "";
            Center.Text = "";
            City.Text = "";
            State.Text = "";
            Country.Text = "";
            PinCode.Text = "";
            ContactNo1.Text = "";
            ContactNo2.Text = "";

            BookedAtCenter.Text = "";
            SubYears.Text = "";
            StartDate.Text = "";
            EndDate.Text = "";

            NoOfCopies.Text = "";
            CopiesIssued.Text = "";
            Comments.Text = "";
            AccNo.Text = "";
            SubEmailId.Text = "";
            Remarks.Text = "";
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
             DialogResult s = MessageBox.Show("Do you Really Want to Delete"+
                 "The record from database", "ABC Magazine Software", MessageBoxButtons.YesNo);

            if (s == DialogResult.Yes)
            {
                string sub_no = Sub_No.Text;
                SqlCommand comm = new SqlCommand("Delete from Subscription_Details where Subscriber_no='" + sub_no+"'", connection.con);
                connection.con.Open();
                int i = comm.ExecuteNonQuery();

                MessageBox.Show(i + " Record Deleted");
                connection.con.Close();
                ClearData();
            }else if(s == DialogResult.No)
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("Please Select One Option.");
            }
        }
    }
}
