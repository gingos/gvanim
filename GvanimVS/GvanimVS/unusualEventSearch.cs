using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GvanimVS
{
    public partial class unusualEventSearch : DBform
    {
        private SqlConnection con;
        DataTable dt;

        public unusualEventSearch()
        {
            InitializeComponent();
        }

        public unusualEventSearch(SqlConnection con, string text)
        {
            this.con = con;
            Text = text;
            dt = new DataTable();
            InitializeComponent();
        }

        private void unusualEventSearch_Load(object sender, EventArgs e)
        {

        }

        private void close_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchEvent_bt_Click(object sender, EventArgs e)
        {
            //TODO: show datagrid view with unusualEvents
            dt = DetailedSearch();
            if (dt != null)
            {
                events_dgv.DataSource = dt;
            }

        }

        private DataTable DetailedSearch()
        {
            //get coordinatorId
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt1 = new DataTable();
            dt1 = SQLmethods.getCoordinatorId(this.Text, da, cmd);
            string coordinatorId = dt1.Rows[0]["coordinatorId"].ToString();

            //create search command
            string cmdText = "";
            #region sqlQuery
            cmdText =
                "SELECT UnusualEventTB.* FROM UnusualEventTB events WHERE events.MitmodedID = " + this.Text +
                "AND events.Place LIKE '%' + @pPlace + '%' " +
                "AND events.Address LIKE '%' + @pAddress + '%' " +
                "AND events.Date BETWEEN @pStartDate AND @pEndDate " +
                "AND events.CoordinatorID = @pCoordinatorID";
            cmd.CommandText = cmdText;
            #endregion
            #region addParamaters
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@pPlace", place_tb.Text);
            cmd.Parameters.AddWithValue("@pAddress", address_tb.Text);
            cmd.Parameters.Add("@pStartDate", SqlDbType.Date).Value = start_date_dtp.Checked ? start_date_dtp.Value.ToString() : new DateTime(1900, 1, 1).ToString();
            cmd.Parameters.Add("@pEndDate", SqlDbType.Date).Value = end_date_dtp.Checked ? end_date_dtp.Value.ToString() : DateTime.Now.ToString();
            cmd.Parameters.AddWithValue("@pCoordinatorID", coordinatorId);
            #endregion
            #region execute
            da.SelectCommand = cmd;
            try
            {
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                return null;
            }
            catch (TimeoutException)
            {
                System.Windows.Forms.MessageBox.Show("משך הזמן התקין ליצירת קשר עם השרת עבר." + "\n"
                    + "אנא בדקו את חיבור האינטרנט ונסו שוב", "שגיאת חיבור", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error, System.Windows.Forms.MessageBoxDefaultButton.Button1,
                    System.Windows.Forms.MessageBoxOptions.RightAlign | System.Windows.Forms.MessageBoxOptions.RtlReading);
                return null;
            }
            #endregion
            return dt;
        }

        private void extendedSerarch_bt_Click(object sender, EventArgs e)
        {
            place_tb.Show();
            address_tb.Show();
            address_lb.Show();
            start_date_dtp.Show();
            start_date_lb.Show();
            end_date_dtp.Show();
            end_date_lb.Show();
            city_lb.Show();
            searchEvent_bt.Show();
        }

        private void fastSearch_bt_Click(object sender, EventArgs e)
        {
            dt = fastSearch();
            if (dt != null)
            {
                events_dgv.DataSource = dt;
            }
        }

        private DataTable fastSearch()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            #region sqlQuery
            cmd.CommandText =
                "SELECT Place, Address, Date, CheckedSubjects FROM UnusualEventTB events";
            #endregion
            #region execute
            da.SelectCommand = cmd;
            try
            {
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                return null;
            }
            catch (TimeoutException)
            {
                System.Windows.Forms.MessageBox.Show("משך הזמן התקין ליצירת קשר עם השרת עבר." + "\n"
                    + "אנא בדקו את חיבור האינטרנט ונסו שוב", "שגיאת חיבור", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error, System.Windows.Forms.MessageBoxDefaultButton.Button1,
                    System.Windows.Forms.MessageBoxOptions.RightAlign | System.Windows.Forms.MessageBoxOptions.RtlReading);
                return null;
            }
            #endregion
            foreach (DataRow dataRow in dt.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    MessageBox.Show(item.ToString());
                }
            }
            return dt;
        }

        private void events_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
