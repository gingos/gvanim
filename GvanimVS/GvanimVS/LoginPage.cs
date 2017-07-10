using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GvanimVS
{
    public partial class LoginPage : DBform
    {
        string CONNECTION_STRING = "Data Source= gingos.database.windows.net;Initial Catalog=gvanimDB;Persist Security Info=True;User ID=gingos;Password=wolf20Schneid!";
        public volatile bool connected;
        public DataTable dt;

        public LoginPage(SqlConnection con) : base(con)
        {
            InitializeComponent();
        }
        public LoginPage(Panel panel1) : base()
        {
            InitializeComponent();
            con = new SqlConnection(CONNECTION_STRING);
            connected = false;
        }

        /// <summary>
        /// Verifies that username & password are not empty
        /// </summary>
        private bool verifyFields()
        {
            if (user_tb.Text.Equals(""))
            {
                MessageBox.Show("אנא ציינו תעודת זהות או כתובת אימייל");
                user_tb.Focus();
                return false;
            }
            if (password_tb.Text.Equals(""))
            {
                MessageBox.Show("אנו ציינו סיסמא");
                password_tb.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Compare user-specified Credentials to DB, show welcome message if correct
        /// </summary>
        private void attemptLogin()
        {
            dt = SQLmethods.getDataTable(SQLmethods.USERS, user_tb.Text, password_tb.Text,
                        cmd, da);
            if (dt == null)
                return;
            if (dt.Rows.Count == 0)
                MessageBox.Show("שם משתמש או סיסמא אינם נכונים");
            else
            {
                showWelcomeMessage(dt);
            }
        }

        /// <summary>
        /// Prints user's welcome: full name & position
        /// </summary>
        /// <param name="dt">User row from Employees table</param>
        private void showWelcomeMessage(DataTable dt)
        {
            DataRow dr = dt.Rows[0];
            MessageBox.Show("ברוך הבא\n " +
                dr["firstName"] + " " + dr["lastName"] + "\n" +
                dr["role"].ToString());
            this.Hide();
            openMatchingUserGui(dr);
            login_bt.Enabled = true;
            
            this.Show();
        }

        /// <summary>
        /// Open GUI according to its role
        /// </summary>
        public void openMatchingUserGui(DataRow dr)
        {
            switch (dr["role"].ToString())
            {
                case "region manager":
                    using (var rm = new RegionManager(con, dr["ID"].ToString()))
                    {
                        rm.ShowDialog();
                    }
                    break;
                case "coordinator":
                    using (var c = new Coordinator(con, dr["ID"].ToString()))
                    {
                        c.ShowDialog();
                    }
                    break;
                default:
                    MessageBox.Show("אנא בדקו שוב שם וסיסמא");
                    break;
            }
        }

        /// <summary>
        /// Check for SQL Connection with server
        /// catches no-connection (SQL Exception) and double-attempt (Invalid Operation)
        /// </summary>
        private void CheckInternetConnectionSync()
        {
            
            try
            {
                con.Open();
                connected = true;

            }
            catch (SqlException sqlex)
            {
                
            }
            catch (InvalidOperationException opex)
            {
                
            }

        }
        /*
        private Task<bool> CheckInternetConnectionAsync()
        {
            return Task<bool>.Run(() => {
                if (con.State == ConnectionState.Open)
                    return true;
                try
                {
                    con.Open();
                    return true;
                }
                catch
                {
                    MessageBox.Show("הגישה לשרת אינה אפשרית כרגע" +
                       "\n" +
                       "אנא נסי שוב בעוד מספר רגעים");
                    return false;
                }
            });
        }
        private async void CheckInternetConnection()
        {
            bool hasConnection = await CheckInternetConnectionAsync();
            if (hasConnection)
                successLogin();
        }
        */

        /// <summary>
        /// As login page first shows, test SQL connection, if so, init sql-command and data reader
        /// else, begin busy-wait thread on connection
        /// </summary>
        private void LoginPage_Shown(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                CheckInternetConnectionSync();
                if (connected)
                    connectionSuccess();
                else
                {
                    beginConnectionThread();
                    MessageBox.Show("הגישה לשרת אינה אפשרית כרגע" + "\n" + "אנא נסו שוב בעוד מספר רגעים");
                }
            }
        }

        /// <summary>
        /// If no connection available, begin busy-wait thread
        /// </summary>
        private void beginConnectionThread()
        {
            var th = new Thread(ExecuteInForeground);
           
            th.Start();
            Console.WriteLine("Connection Thread Start");
            
        }

        /// <summary>
        /// This thread runs in the background: 15-sec intervals to retry sql connection
        /// </summary>
        private void ExecuteInForeground()
        {
            do
            {
                Thread.Sleep(15000);
                Console.WriteLine("Connection Thread Woke Up");
                CheckInternetConnectionSync();
                if (connected)
                    connectionSuccess();
                
            } while (!connected);

        }

        /// <summary>
        /// Upon success, initialize sql classes and change indicator led to green
        /// </summary>
        private void connectionSuccess()
        {
            cmd = new SqlCommand();
            cmd.Connection = con;
            da = new SqlDataAdapter();

            this.status_pb.Image = global::GvanimVS.Properties.Resources.green;
        }
 
        private void login_bt_MouseHover(object sender, EventArgs e)
        {
            login_bt.BackColor = Color.RoyalBlue;
        }

        private void login_bt_MouseLeave(object sender, EventArgs e)
        {
            login_bt.BackColor = Color.CornflowerBlue;
        }

        /// <summary>
        /// Occures when "Login" button is clicked.
        /// If username & password are valid, and connection available, will attempt user login.
        /// if no connection available, force retry and then attempt user login
        /// </summary>
        private void login_bt_Click_1(object sender, EventArgs e)
        {
            if (verifyFields())
            {
                if (connected)
                {
                    attemptLogin();
                }
                else
                {
                    login_bt.Enabled = false;

                    MessageBox.Show("קיימת בעיה בחיבור האינטרנט" + "\n" + "התכנית תנסה להתחבר שוב, אנא המתינו");
                    CheckInternetConnectionSync();
                    if (connected)
                    {
                        connectionSuccess();
                        attemptLogin();
                    }
                    else
                        MessageBox.Show("הגישה לשרת אינה אפשרית כרגע" + "\n" + "אנא נסו שוב בעוד מספר רגעים");
                    login_bt.Enabled = true;


                }
            }
        }

        private void user_tb_Click(object sender, EventArgs e)
        {
            user_tb.Text = "";
        }

        private void password_tb_Click(object sender, EventArgs e)
        {
            password_tb.Text = "";
        }
    }
}
