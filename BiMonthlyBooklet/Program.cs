using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace BiMonthlyBooklet
{
    public class connection
    {
        // Trusted_Connection=True tells SQL Server to use your Windows account to log in safely
        public static SqlConnection con = new SqlConnection("server=(localdb)\\MSSQLLocalDB;Database=Magzine;Trusted_Connection=True;");
    }
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
