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
    public partial class AddingComplentForm : Form
    {
        public AddingComplentForm()
        {
            InitializeComponent();
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
    }
}
