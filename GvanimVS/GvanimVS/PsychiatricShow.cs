﻿using System;
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
    public partial class PsychiatricShow : DBform
    {
        public PsychiatricShow(SqlConnection con, string ID) : base(con)
        {
            InitializeComponent();
            coordinatorID_lb.Text = ID;

        }

        private void close_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fast_search_bt_Click(object sender, EventArgs e)
        {
            DataTable dt = fastSearch();
            if (dt != null)
            {
                followUps_dgv.DataSource = dt;
            }
        }

        //TODO:
        // hide file column causes run-time problems.
        //possible feature: open file on double click.
        /// <summary>
        /// return data on mitmoded by name
        /// </summary>
        /// Performs JOIN on mitmoded and meeting tables on mitmoded ID and name
        /// <returns>all columns from meetingTB by mitmoded name</returns>
        private DataTable fastSearch()
        {
            DataTable dt = new DataTable();
            string cmdText = "";
            #region sqlQuery
            cmdText =
                "SELECT checkup.* FROM PsychiatricCheckUpTB checkup, MitmodedTb mitmoded WHERE checkup.Id = mitmoded.ID " +
                "AND (mitmoded.firstName + mitmoded.lastName LIKE '%' + @pName + '%' OR (mitmoded.lastName + mitmoded.firstName LIKE '%' + @pName + '%')) ";
            cmd.CommandText = cmdText;
            #endregion
            #region addParamaters
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@pName", mitmoded_name_tb.Text);
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

        private void detailed_search_Click(object sender, EventArgs e)
        {
            //TODO:
            /*
            FindPsychiatry find = new FinPsychiatry(con, coordinatorID_lb.Text);
            find.ShowDialog();
            DataTable dt = find.getDetails();
            if (dt != null)
                meetings_dgv.DataSource = dt;
            find.Dispose();
            */
        }

        private void add_psy_followup_bt_Click(object sender, EventArgs e)
        {
            using (PsychiatricCheckUp check = new PsychiatricCheckUp(con, coordinatorID_lb.Text))
            {
                check.ShowDialog();
            }
        }

        private void fast_search_bt_MouseHover(object sender, EventArgs e)
        {
            fast_search_bt.BackColor = Color.RoyalBlue;
        }

        private void fast_search_bt_MouseLeave(object sender, EventArgs e)
        {
            fast_search_bt.BackColor = Color.CornflowerBlue;
        }

        private void detailed_search_MouseHover(object sender, EventArgs e)
        {
            detailed_search_bt.BackColor = Color.RoyalBlue;
        }

        private void detailed_search_MouseLeave(object sender, EventArgs e)
        {
            detailed_search_bt.BackColor = Color.CornflowerBlue;
        }

        private void add_psy_followup_bt_MouseHover(object sender, EventArgs e)
        {
            add_psy_followup_bt.BackColor = Color.RoyalBlue;
        }

        private void add_psy_followup_bt_MouseLeave(object sender, EventArgs e)
        {
            add_psy_followup_bt.BackColor = Color.CornflowerBlue;
        }

        private void close_bt_MouseHover(object sender, EventArgs e)
        {
            close_bt.BackColor = Color.RoyalBlue;
        }

        private void close_bt_MouseLeave(object sender, EventArgs e)
        {
            close_bt.BackColor = Color.CornflowerBlue;
        }
    }
}
