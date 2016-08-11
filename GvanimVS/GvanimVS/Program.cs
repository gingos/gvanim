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
            
            RegionManager rm = tryConnection();
            if (rm!=null)
                Application.Run(rm);
            else
            {
                MessageBox.Show("Could not open Login Screen");
            }
            
        }
        static RegionManager tryConnection()
        {
            string connectionString = "Data Source= gingos.database.windows.net;Initial Catalog=gvanimDB;Persist Security Info=True;User ID=gingos;Password=wolf20Schneid!";
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
                return null;

            }
            return new RegionManager(con);
        }
    }
}
