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
    public partial class AddNewForm : Form
    {
        SqlCommand comm = new SqlCommand();
        public AddNewForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddNewForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void AddRecord_Click(object sender, EventArgs e)
        {
            string sub_typev, sub_langv, sub_nov, recipt_nov, titlev, fnamev, mnamev, lnamev, addressv,
                cityv, statev, countryv, pinv, con_personv, mob_nov, con_vov, modeofdelv, center_namev,
                sub_noof_yearv, acc_nov, booked_at_centerv, start_datev, end_datev, copy_issuedv,
                sub_emailidv, commentsv, sub_noofcopiesc;

            bool flag = true;
            commentsv = "SUBSCRIPTION VALID";
            sub_typev = "NEW";
            sub_noof_yearv = "";
            sub_langv = Language.Text;
            sub_nov = SubNo.Text;
            recipt_nov = ReciptNo.Text;
            titlev = Title.Text;
            fnamev = FirstName.Text;
            mnamev = MiddleName.Text;
            lnamev = LastName.Text;
            addressv = Address.Text;
            cityv = City.Text;
            statev = State.Text;
            countryv = Country.Text;
            pinv = PinCode.Text;
            con_personv = ContactPerson.Text;
            mob_nov = MobileNo.Text;
            con_vov = TelNo.Text;
            center_namev = CenterName.Text;
            booked_at_centerv = BookAtCenter.Text;
            copy_issuedv = CopyIssued.Text;
            sub_emailidv = SubEmail.Text;
            sub_noofcopiesc = "1";
            start_datev = StartDate.Text; ;
            end_datev = "";

            if (Direct.Checked)
            {
                modeofdelv = Country.Text + "-" + "Direct";
            }else if(AtCenter.Checked == true)
            {
                modeofdelv = CenterName.Text;
            }else if(Direct.Checked == false && AtCenter.Checked == false)
            {
                MessageBox.Show("Please select mode of delivery.");
                flag = false;
            }

            if(year1.Checked == true)
            {
                sub_noof_yearv = "1";
            }else if(year3.Checked == true)
            {
                sub_noof_yearv = "3";
            }else if(year5.Checked == true)
            {
                sub_noof_yearv = "5";
            }else if(year1.Checked==false && year3.Checked == false && year5.Checked == false)
            {
                MessageBox.Show("Please select No of Year for your Subscription.");
                flag = false;
            }

            // Replace .ToShortDateString() with the explicit ISO format "yyyy-MM-dd"
            end_datev = EndDate.Value.ToString("yyyy-MM-dd");
            start_datev = StartDate.Value.ToString("yyyy-MM-dd");
            acc_nov = AccNo.Text;

            string str = "INSERT INTO Subscription_Details " +
                "(Subscriber_no, Receipt_no, Subscription_Type, Language, Title, " +
                "FName, MName, LName, Address, DeliveryLocation, " +
                "City, State, Country, Pincode, Contact_Person, " +
                "MobileNo, PhoneNo, BookedAt, NoofYear, Sub_StartDate, " +
                "Sub_EndDate, NoofCopies, Copy_Issued, Comments, Remarks, " +
                "AccNo, Sub_EmailID) VALUES (" +
                "'" + sub_nov + "', " +
                "'" + recipt_nov + "', " +
                "'" + sub_typev + "', " +
                "'" + sub_langv + "', " +
                "'" + titlev + "', " +
                "'" + fnamev + "', " +
                "'" + mnamev + "', " +
                "'" + lnamev + "', " +
                "'" + addressv + "', " +
                "'" + center_namev + "', " +
                "'" + cityv + "', " +
                "'" + statev + "', " +
                "'" + countryv + "', " +
                "'" + pinv + "', " +
                "'" + con_personv + "', " +
                "'" + mob_nov + "', " +
                "'" + con_vov + "', " +
                "'" + booked_at_centerv + "', " +
                "'" + sub_noof_yearv + "', " +
                "'" + start_datev + "', " +
                "'" + end_datev + "', " +
                "'" + sub_noofcopiesc + "', " +
                "'" + copy_issuedv + "', " +
                "'" + commentsv + "', " +
                "'', " + // Placeholder for 'Remarks' since it wasn't defined in your variables
                "'" + acc_nov + "', " +
                "'" + sub_emailidv + "')";


            if (flag == false)
            {

            }
            else
            {
                comm.CommandText = str;
                comm.Connection = connection.con;
                connection.con.Open();
                int i = comm.ExecuteNonQuery();
                MessageBox.Show(i + " Record/s Added");
                connection.con.Close();
            }
        }
    }
}
