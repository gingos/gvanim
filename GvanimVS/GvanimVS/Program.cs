using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GvanimVS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginPage login = tryConnection();
            if (login!=null)
                Application.Run(login);
            else
            {
                MessageBox.Show("אין אפשרות לפתוח את מסך ההתחברות");
            }
            
        }
        static LoginPage tryConnection()
        {
            string connectionString = "Data Source= gingos.database.windows.net;Initial Catalog=gvanimDB;Persist Security Info=True;User ID=gingos;Password=wolf20Schneid!";
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
            }
            catch (SqlException e)
            {
                MessageBox.Show("הגישה לשרת אינה אפשרית כרגע" +
                    "\n" +
                    "אנא נסי שוב בעוד מספר רגעים");
                return null;

            }
            return new LoginPage(con);
        }
    }
}
