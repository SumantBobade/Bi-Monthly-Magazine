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
using System.IO;

namespace BiMonthlyBooklet
{
    public partial class ViewRecordForm : Form
    {
        public string searchoption = "";
        SqlDataAdapter adp;
        DataSet ds = new DataSet();
        public ViewRecordForm()
        {
            InitializeComponent();
        }

        public void clear()
        {
            Sub_No.Text = "";
            Recipt_No.Text = "";
            Center.Text = "";
            City.Text = "";
            State.Text = "";
            Country.Text = "";
            Title.Text = "";
            FName.Text = "";
            MName.Text = "";
            LName.Text = "";
            Address.Text = "";
            Pincode.Text = "";
            MobileNo.Text = "";
            Tel_No.Text = "";
            AccNo.Text = "";
            Sub_Validity.Text = "";
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchSelectField_Click(object sender, EventArgs e)
        {
            string str, subno, fnm, mnm, lnm, va, add, cen, ciy, state, coun,
                pin, ph, mob, acc, lang, title, reno;
            int i;

            if(searchoption == "ReciptNo")
            {
                reno = Recipt_No.Text;
                str = "Select Subscriber_no, Recipt_no, Language, Title, FName, " +
                    "MName, LName, Address, DeliverLocation, StartDate, EndDate," +
                    "Copy_Issued from Subscription_Details " +
                    "where Recipt_no like '%" + reno + "%' order by Subscriber_no";

                adp = new SqlDataAdapter(str, connection.con);
                adp.Fill(ds, "Subscription_Details");

                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("!!!Sorry No Record Found!!!", "Magazine Publication")
                }
                else
                {
                    GridView.DataSource = ds.Tables[0].DefaultView;
                    i = ds.Tables[0].Rows.Count - 1;
                    label19.Text = "The Total Rows are "+ i.ToString();
                }
            }
        }

        private void SearchOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SearchOption.SelectedIndex == 1)
            {
                searchoption = "Recipt_No";
                clear();
                Recipt_No.Enabled = true;
                Sub_No.Enabled = false;
                FName.Enabled = false;
                MName.Enabled = false;
                LName.Enabled = false;
                Title.Enabled = false;
                Address.Enabled = false;
                Pincode.Enabled = false;
                Country.Enabled = false;
                State.Enabled = false;
                Language.Enabled = false;
                AccNo .Enabled = false;
                MobileNo .Enabled = false;
                Tel_No .Enabled = false;
            }
            else if (SearchOption.SelectedIndex == 2)
            {
                searchoption = "Sub_No";
                clear();
                Recipt_No.Enabled = false;
                Sub_No.Enabled = true;
                FName.Enabled = false;
                MName.Enabled = false;
                LName.Enabled = false;
                Title.Enabled = false;
                Address.Enabled = false;
                Pincode.Enabled = false;
                Country.Enabled = false;
                State.Enabled = false;
                Language.Enabled = false;
                AccNo.Enabled = false;
                MobileNo.Enabled = false;
                Tel_No.Enabled = false;
            }
            else if (SearchOption.SelectedIndex == 3)
            {
                searchoption = "Title";
                clear();
                Recipt_No.Enabled = false;
                Sub_No.Enabled = false;
                FName.Enabled = false;
                MName.Enabled = false;
                LName.Enabled = false;
                Title.Enabled = true;
                Address.Enabled = false;
                Pincode.Enabled = false;
                Country.Enabled = false;
                State.Enabled = false;
                Language.Enabled = false;
                AccNo.Enabled = false;
                MobileNo.Enabled = false;
                Tel_No.Enabled = false;
            }
            else if (SearchOption.SelectedIndex == 4)
            {
                searchoption = "Name";
                clear();
                Recipt_No.Enabled = false;
                Sub_No.Enabled = false;
                FName.Enabled = true;
                MName.Enabled = true;
                LName.Enabled = true;
                Title.Enabled = false;
                Address.Enabled = false;
                Pincode.Enabled = false;
                Country.Enabled = false;
                State.Enabled = false;
                Language.Enabled = false;
                AccNo.Enabled = false;
                MobileNo.Enabled = false;
                Tel_No.Enabled = false;
            }
            else if (SearchOption.SelectedIndex == 5)
            {
                searchoption = "Address";
                clear();
                Recipt_No.Enabled = false;
                Sub_No.Enabled = false;
                FName.Enabled = false;
                MName.Enabled = false;
                LName.Enabled = false;
                Title.Enabled = false;
                Address.Enabled = true;
                Pincode.Enabled = false;
                Country.Enabled = false;
                State.Enabled = false;
                Language.Enabled = false;
                AccNo.Enabled = false;
                MobileNo.Enabled = false;
                Tel_No.Enabled = false;
            }
            else if (SearchOption.SelectedIndex == 6)
            {
                searchoption = "Pincode";
                clear();
                Recipt_No.Enabled = false;
                Sub_No.Enabled = false;
                FName.Enabled = false;
                MName.Enabled = false;
                LName.Enabled = false;
                Title.Enabled = false;
                Address.Enabled = false;
                Pincode.Enabled = true;
                Country.Enabled = false;
                State.Enabled = false;
                Language.Enabled = false;
                AccNo.Enabled = false;
                MobileNo.Enabled = false;
                Tel_No.Enabled = false;
            }
            else if (SearchOption.SelectedIndex == 7)
            {
                searchoption = "PhoneNo";
                clear();
                Recipt_No.Enabled = false;
                Sub_No.Enabled = false;
                FName.Enabled = false;
                MName.Enabled = false;
                LName.Enabled = false;
                Title.Enabled = false;
                Address.Enabled = false;
                Pincode.Enabled = false;
                Country.Enabled = false;
                State.Enabled = false;
                Language.Enabled = false;
                AccNo.Enabled = false;
                MobileNo.Enabled = false;
                Tel_No.Enabled = true;
            }else if (SearchOption.SelectedIndex == 8)
            {
                searchoption = "MobileNo";
                clear();
                Recipt_No.Enabled = false;
                Sub_No.Enabled = false;
                FName.Enabled = false;
                MName.Enabled = false;
                LName.Enabled = false;
                Title.Enabled = false;
                Address.Enabled = false;
                Pincode.Enabled = false;
                Country.Enabled = false;
                State.Enabled = false;
                Language.Enabled = false;
                AccNo.Enabled = false;
                MobileNo.Enabled = true;
                Tel_No.Enabled = false;
            }
            else if (SearchOption.SelectedIndex == 9)
            {
                searchoption = "AccNo";
                clear();
                Recipt_No.Enabled = false;
                Sub_No.Enabled = false;
                FName.Enabled = false;
                MName.Enabled = false;
                LName.Enabled = false;
                Title.Enabled = false;
                Address.Enabled = false;
                Pincode.Enabled = false;
                Country.Enabled = false;
                State.Enabled = false;
                Language.Enabled = false;
                AccNo.Enabled = true;
                MobileNo.Enabled = false;
                Tel_No.Enabled = false;
            }
            else if (SearchOption.SelectedIndex == 10)
            {
                searchoption = "Language";
                clear();
                Recipt_No.Enabled = false;
                Sub_No.Enabled = false;
                FName.Enabled = false;
                MName.Enabled = false;
                LName.Enabled = false;
                Title.Enabled = false;
                Address.Enabled = false;
                Pincode.Enabled = false;
                Country.Enabled = false;
                State.Enabled = false;
                Language.Enabled = true;
                AccNo.Enabled = false;
                MobileNo.Enabled = false;
                Tel_No.Enabled = false;
            }
            else
            { 
                    searchoption = "NonSelected";
                    clear();
                    Recipt_No.Enabled = false;
                    Sub_No.Enabled = false;
                    FName.Enabled = false;
                    MName.Enabled = false;
                    LName.Enabled = false;
                    Title.Enabled = false;
                    Address.Enabled = false;
                    Pincode.Enabled = false;
                    Country.Enabled = false;
                    State.Enabled = false;
                    Language.Enabled = false;
                    AccNo.Enabled = false;
                    MobileNo.Enabled = false;
                    Tel_No.Enabled = false;
               
            }
        }
    }
}
