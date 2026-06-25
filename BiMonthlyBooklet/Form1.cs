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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void login_btn_Click(object sender, EventArgs e)
        {
            //if(textBox1.Text=="Administrator" && textBox2.Text == "admin")
            //{
            //    //MessageBox.Show("This is Login Button");
            //    MainMenu m1 = new MainMenu();
            //    this.Hide();
            //    m1.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Invalid UserName or Password.");
            //}
            string str = "Select Username, password from Login where Username='"+textBox1.Text + "' and password='"+textBox2.Text"'";
            SqlDataAdapter adp = new SqlDataAdapter(str, connection.con);
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
