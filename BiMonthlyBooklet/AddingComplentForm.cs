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
    public partial class AddingComplentForm : Form
    {
        SqlCommand comm;
        DataSet ds = new DataSet();
        public AddingComplentForm()
        {
            InitializeComponent();
        }

        public void CL()
        {
            ComID.Text = "";
            SubNo.Text = "";
            SubName.Text = "";
            ComDetails.Text = "";
            ComDate.Value = DateTime.Now;
            ComResolve.Text = "";
            ResolveDate.Value = DateTime.Now;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComResolve_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ComResolve.SelectedIndex == 1)
            {
                ResolveDate.Enabled = true;
            }
            else
            {
                ResolveDate.Enabled = false;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            comm = new SqlCommand("Insert into Complaint_Data values ('"+ ComID.Text+"' ,'"+SubNo.Text+"','"+SubName.Text+"','"+ComDetails.Text+"','"+ComDate.Value.ToShortDateString()+"','"+ComResolve.Text+"','"+ResolveDate.Value.ToShortDateString()+"');", connection.con);
            connection.con.Open();
            int i = comm.ExecuteNonQuery();
            MessageBox.Show(i + " Records Added");
            connection.con.Close();
            CL();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            CL();
        }
    }
}
