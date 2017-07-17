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
    public partial class Mitmoded : DBform
    {
        private string coordinatorID;
        private double SCORE = 100;

        public Mitmoded()
        {
            InitializeComponent();
        }
        public Mitmoded(SqlConnection con) : base(con)
        {
            InitializeComponent();
        }
        public Mitmoded(SqlConnection con, string mitmodedID) : base(con)
        {
            InitializeComponent();
            ID_dynamic_lb.Text = mitmodedID;
            DataTable dt = SQLmethods.getDataTable(SQLmethods.MITMODED, mitmodedID, cmd, da);
            if (dt != null)
                initFieldsFromDT(dt);
        }

        /// <summary>
        /// Init dynamic labels with user details
        /// </summary>
        /// Details are name, ID, score; retrieved from DB
        /// <param name="dt"></param>
        private void initFieldsFromDT(DataTable dt)
        {
            name_dynamic_lb.Text = dt.Rows[0]["firstName"].ToString() + " " + dt.Rows[0]["lastName"].ToString();
            coordinatorID = dt.Rows[0]["coordinatorID"].ToString();

            //score_dynamic_lb.Text = dt.Rows[0]["grade"].ToString();
            score_dynamic_lb.Text = SCORE.ToString();
            //TODO:
            //possible query: equal\inner join on "coordinatorID:
            coordinator_dynamic_lb.Text = getCoordinatorName(coordinatorID);
            if (!(dt.Rows[0]["photo"] is DBNull))
            {
                byte[] bytes = (byte[])dt.Rows[0]["photo"];
                var ms = new System.IO.MemoryStream(bytes);
                profile_pb.Image = Image.FromStream(ms);
            }
            else
                profile_pb.Image = Properties.Resources.anonymous_profile;
        }
        private string getCoordinatorName(string coordinatorID)
        {
            DataTable dt = SQLmethods.getColsFromTable(SQLmethods.USERS, "*", "ID", coordinatorID, cmd, da);
            if (dt == null)
                return null;
            return dt.Rows[0]["firstName"].ToString() + " " + dt.Rows[0]["lastName"].ToString();
        }

        private void employment_bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var employmentRec = new EmplyomentRecord(con, ID_dynamic_lb.Text, name_dynamic_lb.Text))
            {
                employmentRec.ShowDialog();
            }
            this.Show();
        }
        private void show_reports_bt_Click(object sender, EventArgs e)
        {

        }
        private void info_bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var mitCard = new MitmodedCard(con, ID_dynamic_lb.Text, coordinatorID))
            {
                mitCard.ShowDialog();
            }
            this.Show();
        }
        private void close_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void change_coordinator_bt_Click(object sender, EventArgs e)
        {
            //TODO
            MessageBox.Show("Not Implemented Yet");
        }

        private void add_report_bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var report = new ReportAdd(con, coordinatorID, ID_dynamic_lb.Text))
            {
                report.ShowDialog();
            }
            this.Show();
        }

        private void btn_tochnit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("דף זה נמצא בפיתוח");
            //this.Hide();
            //using (var tochnit = new PersonalPlan(con, ID_dynamic_lb.Text))
            //{
            //    tochnit.ShowDialog();
            //}
            //this.Show();
        }

        private void open_hitkashrut_bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var hit = new Hitkashrut(con, ID_dynamic_lb.Text))
            {
                hit.ShowDialog();
            }
            this.Show();
        }

        private void confidentiality_bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var conf = new Confidentiality(con, ID_dynamic_lb.Text))
            {
                conf.ShowDialog();
            }
            this.Show();
        }

        private void cv_generator_bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var cv = new CVGenerator(con, ID_dynamic_lb.Text))
            {
                cv.ShowDialog();
            }
            this.Show();
        }

        private void addPsychiatricCheckUp_btn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            using (RelatedDocs related = new RelatedDocs(con, ID_dynamic_lb.Text))
            {
                related.ShowDialog();
            }
            this.Show();
        }

        private void showPsyCheckUps_btn_Click(object sender, EventArgs e)
        {

        }


        private void add_employment_bt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("יש לעדכן קוד עבור אפשרות זו");
        }


        private void keyword_bt_Click(object sender, EventArgs e)
        {
            //open Intec form
            MitmodedCard card = new MitmodedCard(con, ID_dynamic_lb.Text, coordinatorID);
            //apply Intec.scan() with supplied BOW vector
            SCORE = card.CalculateIntecScore(100);
            score_dynamic_lb.Text = SCORE.ToString();
            if (SCORE <= 60)
            {
                MessageBox.Show("מתמודד בטווח האדום, יש לבדוק את הכרטיס האישי שלו");
                score_dynamic_lb.ForeColor = Color.Red;
            }
            else if (SCORE > 60 && SCORE <= 80)
            {
                MessageBox.Show("מתמודד בטווח הצהוב, יש לבדוק את הכרטיס האישי שלו");
                score_dynamic_lb.ForeColor = Color.Orange;
            }
        }

        private void unusual_event_bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Unusual_event ue = new Unusual_event(con, ID_dynamic_lb.Text))
            {
                ue.ShowDialog();
            }
            this.Show();
        }

        private void unusual_event_serch_bt_click(object sender, EventArgs e)
        {
            this.Hide();
            using (unusualEventSearch ues = new unusualEventSearch(con, ID_dynamic_lb.Text))
            {
                ues.ShowDialog();
            }
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Alerts al = new Alerts(con, ID_dynamic_lb.Text))
            {
                al.ShowDialog();
            }
            this.Show();
        }

        private void show_meetings_bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (MeetingShow show = new MeetingShow(con, coordinatorID, ID_dynamic_lb.Text))
            {
                show.ShowDialog();
            }
            this.Show();
        }

        private void change_coordinator_bt_MouseHover(object sender, EventArgs e)
        {
            change_coordinator_bt.BackColor = Color.RoyalBlue;
        }

        private void change_coordinator_bt_MouseLeave(object sender, EventArgs e)
        {
            change_coordinator_bt.BackColor = Color.CornflowerBlue;
        }

        private void close_bt_MouseHover(object sender, EventArgs e)
        {
            close_bt.BackColor = Color.RoyalBlue;
        }

        private void close_bt_MouseLeave(object sender, EventArgs e)
        {
            close_bt.BackColor = Color.CornflowerBlue;
        }

        private void info_bt_MouseHover(object sender, EventArgs e)
        {
            info_bt.BackColor = Color.RoyalBlue;
        }

        private void info_bt_MouseLeave(object sender, EventArgs e)
        {
            info_bt.BackColor = Color.CornflowerBlue;
        }

        private void tochnit_bt_MouseHover(object sender, EventArgs e)
        {
            tochnit_bt.BackColor = Color.RoyalBlue;
        }

        private void tochnit_bt_MouseLeave(object sender, EventArgs e)
        {
            tochnit_bt.BackColor = Color.CornflowerBlue;
        }

        private void open_hitkashrut_bt_MouseHover(object sender, EventArgs e)
        {
            open_hitkashrut_bt.BackColor = Color.RoyalBlue;
        }

        private void open_hitkashrut_bt_MouseLeave(object sender, EventArgs e)
        {
            open_hitkashrut_bt.BackColor = Color.CornflowerBlue;
        }

        private void confidentiality_bt_MouseHover(object sender, EventArgs e)
        {
            confidentiality_bt.BackColor = Color.RoyalBlue;
        }

        private void confidentiality_bt_MouseLeave(object sender, EventArgs e)
        {
            confidentiality_bt.BackColor = Color.CornflowerBlue;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.RoyalBlue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.CornflowerBlue;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.RoyalBlue;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.CornflowerBlue;
        }

        private void unusual_event_search_bt_MouseHover(object sender, EventArgs e)
        {
            unusual_event_search_bt.BackColor = Color.RoyalBlue;
        }

        private void unusual_event_search_bt_MouseLeave(object sender, EventArgs e)
        {
            unusual_event_search_bt.BackColor = Color.CornflowerBlue;
        }

        private void show_reports_bt_MouseHover(object sender, EventArgs e)
        {
            show_reports_bt.BackColor = Color.RoyalBlue;
        }

        private void show_reports_bt_MouseLeave(object sender, EventArgs e)
        {
            show_reports_bt.BackColor = Color.CornflowerBlue;
        }

        private void add_report_bt_MouseHover(object sender, EventArgs e)
        {
            add_report_bt.BackColor = Color.RoyalBlue;
        }

        private void add_report_bt_MouseLeave(object sender, EventArgs e)
        {
            add_report_bt.BackColor = Color.CornflowerBlue;
        }

        private void show_employment_bt_MouseHover(object sender, EventArgs e)
        {
            show_employment_bt.BackColor = Color.RoyalBlue;
        }

        private void show_employment_bt_MouseLeave(object sender, EventArgs e)
        {
            show_employment_bt.BackColor = Color.CornflowerBlue;
        }

        private void add_employment_bt_MouseHover(object sender, EventArgs e)
        {
            add_employment_bt.BackColor = Color.RoyalBlue;
        }

        private void add_employment_bt_MouseLeave(object sender, EventArgs e)
        {
            add_employment_bt.BackColor = Color.CornflowerBlue;
        }

        private void cv_generator_bt_MouseHover(object sender, EventArgs e)
        {
            cv_generator_bt.BackColor = Color.RoyalBlue;
        }

        private void cv_generator_bt_MouseLeave(object sender, EventArgs e)
        {
            cv_generator_bt.BackColor = Color.CornflowerBlue;
        }

        private void addPsychiatricCheckUp_btn_MouseHover(object sender, EventArgs e)
        {
            addPsychiatricCheckUp_btn.BackColor = Color.RoyalBlue;
        }

        private void addPsychiatricCheckUp_btn_MouseLeave(object sender, EventArgs e)
        {
            addPsychiatricCheckUp_btn.BackColor = Color.CornflowerBlue;
        }

        private void showPsyCheckUps_btn_MouseHover(object sender, EventArgs e)
        {
            showPsyCheckUps_btn.BackColor = Color.RoyalBlue;
        }

        private void showPsyCheckUps_btn_MouseLeave(object sender, EventArgs e)
        {
            showPsyCheckUps_btn.BackColor = Color.CornflowerBlue;
        }

        private void show_meetings_bt_MouseHover(object sender, EventArgs e)
        {
            show_meetings_bt.BackColor = Color.RoyalBlue;
        }

        private void show_meetings_bt_MouseLeave(object sender, EventArgs e)
        {
            show_meetings_bt.BackColor = Color.CornflowerBlue;
        }
    }
 }

