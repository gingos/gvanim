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
        volatile bool connected;

        public LoginPage(SqlConnection con) : base(con)
        {
            InitializeComponent();
        }
        public LoginPage() : base()
        {
            InitializeComponent();
            con = new SqlConnection(CONNECTION_STRING);
            connected = false;
        }

        private void exit_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_bt_Click(object sender, EventArgs e)
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
                    signup_bt.Enabled = false;
                    MessageBox.Show("קיימת בעיה בחיבור האינטרנט" + "\n" + "התכנית תנסה להתחבר שוב, אנא המתינו");
                    CheckInternetConnectionSync();
                    if (connected)
                        attemptLogin();
                    else
                        MessageBox.Show("הגישה לשרת אינה אפשרית כרגע" + "\n" + "אנא נסו שוב בעוד מספר רגעים");
                    login_bt.Enabled = true;
                    signup_bt.Enabled = true;

                }
            }
        }
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
        private void attemptLogin()
        {
            DataTable dt = SQLmethods.getDataTable(SQLmethods.USERS, user_tb.Text, password_tb.Text,
                        cmd, da);
            if (dt.Rows.Count == 0)
                MessageBox.Show("שם משתמש או סיסמא אינם נכונים");
            else
            {
                showWelcomeMessage(dt);
            }
        }
        private void showWelcomeMessage(DataTable dt)
        {
            DataRow dr = dt.Rows[0];
            MessageBox.Show("ברוך הבא\n " +
                dr["firstName"] + " " + dr["lastName"] + "\n" +
                dr["role"].ToString());
            this.Hide();
            openMatchingUserGui(dr);
            login_bt.Enabled = true;
            signup_bt.Enabled = true;
            this.Show();
        }
        private void openMatchingUserGui(DataRow dr)
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

        private void beginConnectionThread()
        {
            var th = new Thread(ExecuteInForeground);
           
            th.Start();
            Console.WriteLine("Connection Thread Start");
            
        }

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

        private void connectionSuccess()
        {
            cmd = new SqlCommand();
            cmd.Connection = con;
            da = new SqlDataAdapter();

            this.status_pb.Image = global::GvanimVS.Properties.Resources.green;
        }
    }
}
