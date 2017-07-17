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
            /*  LoginPage login = new LoginPage();
              while (true)
              {
                  try
                  {
                      Application.Run(login);
                      break;
                  }
                  catch (TimeoutException)
                  {
                      MessageBox.Show("הקשר עם השרת נותק. אנא בדקו את החיבור ונסו שוב");
                  }
                  catch (SqlException)
                  {
                      MessageBox.Show("הקשר עם השרת נותק. אנא בדקו את החיבור ונסו שוב");
                  }
              }*/
            ShapedForm1 sf = new ShapedForm1();
            LoginPage lp = new LoginPage();
            while (true)
            {
                try
                {
                    Application.Run(lp);
                    break;
                }
                catch (TimeoutException)
                {
                    MessageBox.Show("error");
                }
            }              
        }   
    }
}
