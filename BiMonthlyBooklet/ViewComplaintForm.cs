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
    public partial class ViewComplaintForm : Form
    {
        public ViewComplaintForm()
        {
            InitializeComponent();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("Select * From Complaint_Data Order by Complaint_ID", connection.con);
            DataSet ds = new DataSet();
            adp.Fill(ds, "Complaint_Data");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
