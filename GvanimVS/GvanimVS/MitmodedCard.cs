using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GvanimVS
{
    public partial class MitmodedCard : DBform
    {
        private byte[] imgByte;
        private bool imgChanged;
        private string ID;
        private DataTable MainDT;
        private SerializableDictionary<string, SerializableDictionary<string, string>> xml_organizer;


        public MitmodedCard(SqlConnection con) : base(con)
        {
            InitializeComponent();
            imgChanged = false;
        }
        public MitmodedCard(SqlConnection con, string ID) : base(con)
        {
            InitializeComponent();
            this.ID = ID;
            ID_tb.Text = ID;
            imgChanged = false;
            MainDT = SQLmethods.getDataTable(SQLmethods.MITMODED, ID, cmd, da);
            initDataGridViews();
            initFieldsFromDT(MainDT);
        }

        private void initDataGridViews()
        {   
            /*
             * set "Auto Generate Columns" to false
             * now, columns (and data) from data tables will join existing data,
             * not instead of adding the new columns
             */
            education_dgv.AutoGenerateColumns = false;
            employment_dgv.AutoGenerateColumns = false;
            fill_skills();
            init_jobPreferencesDGV();
            fill_jobPreferencesDGV();
            
        }

        private void fill_skills()
        {
            skills_dgv.AutoGenerateColumns = false;
            skills_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            System.Windows.Forms.DataGridViewCellStyle boldStyle = new System.Windows.Forms.DataGridViewCellStyle();
            boldStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);

            skills_dgv.Rows.Add(new string[] { "מיומנויות תקשורת", "" });
            skills_dgv.Rows[0].Cells[0].Style = boldStyle;

            skills_dgv.Rows.Add(new string[] { "קשר עם עובדים אחרים", "" });
            skills_dgv.Rows.Add(new string[] { "קשר עם לקוחות", "" });
            skills_dgv.Rows.Add(new string[] { "קשר עם סמכות / מנהל", "" });

            skills_dgv.Rows.Add(new string[] { "דרישות אישיות", "" });
            skills_dgv.Rows[4].Cells[0].Style = boldStyle;

            skills_dgv.Rows.Add(new string[] { "יכולת לעבודה פיסית", "" });
            skills_dgv.Rows.Add(new string[] { "יכולת קריאה בעברית ושפות אחרות", "" });
            skills_dgv.Rows.Add(new string[] { "יכולת מילולית בעברית ושפות אחרות", "" });
            skills_dgv.Rows.Add(new string[] { "יכולת כתיבה בעברית ושפות אחרות", "" });
            skills_dgv.Rows.Add(new string[] { "יכולת לחישוב מספרים", "" });
            skills_dgv.Rows.Add(new string[] { "יכולת לעבוד עם כספים", "" });
            skills_dgv.Rows.Add(new string[] { "יכולה לעמידה בזמנים", "" });
            skills_dgv.Rows.Add(new string[] { "יכולת לשימוש במחשב", "" });

            skills_dgv.Rows.Add(new string[] { "דרישות אחרות", "" });
            skills_dgv.Rows[13].Cells[0].Style = boldStyle;

            skills_dgv.Rows.Add(new string[] { "יכולת ריכוז", "" });
            skills_dgv.Rows.Add(new string[] { "יוזמה - היכולת לקחת משימה מעבר לנדרש", "" });
            skills_dgv.Rows.Add(new string[] { "יכולת לבצע עבודה עצמאית בהתאם להנחיות", "" });

            skills_dgv.Rows.Add(new string[] { ":התמודדות עם תנאים משתנים" + Environment.NewLine + "לחץ ממצבים חדשים ושינויים-" + Environment.NewLine + "דרישות התפקיד משתנות-" + Environment.NewLine + "תנאי הסביבה משתנים-", "" });
            

            skills_dgv.Rows.Add(new string[] { "יכולת לעבודה מורכבת", "" });
            skills_dgv.Rows.Add(new string[] { "יכולת לקבל סמכות / ביקורת", "" });
            skills_dgv.Rows.Add(new string[] { "יכולת לעבודה בזריזות / מהירות", "" });
            

        }   //fill the category column in the "skills" grid
        private void init_jobPreferencesDGV()
        {
            job_preferences_dgv.AutoGenerateColumns = false;

            job_preferences_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            job_preferences_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            DataGridViewTextBoxColumn location = new DataGridViewTextBoxColumn();
            location.HeaderText = "מקום העבודה ומיקומו";
            location.DataPropertyName = "location";
            location.Name = "location";
            location.ReadOnly = true;

            DataGridViewTextBoxColumn locationInput = new DataGridViewTextBoxColumn();
            locationInput.HeaderText = "אפשרויות";
            locationInput.DataPropertyName = "locationInput";
            locationInput.Name = "locationInput";
            
            DataGridViewTextBoxColumn contents = new DataGridViewTextBoxColumn();
            contents.HeaderText = "תכני העבודה";
            contents.DataPropertyName = "contents";
            contents.Name = "contents";
            contents.ReadOnly = true;

            DataGridViewTextBoxColumn contentsInput = new DataGridViewTextBoxColumn();
            contentsInput.HeaderText = "אפשרויות";
            contentsInput.DataPropertyName = "contentsInput";
            contentsInput.Name = "contentsInput";

            DataGridViewTextBoxColumn type = new DataGridViewTextBoxColumn();
            type.HeaderText = "סוג העבודה";
            type.DataPropertyName = "type";
            type.Name = "type";
            type.ReadOnly = true;

            DataGridViewTextBoxColumn typeInput = new DataGridViewTextBoxColumn();
            typeInput.HeaderText = "אפשרויות";
            typeInput.DataPropertyName = "typeInput";
            typeInput.Name = "typeInput";

            //job_preferences_dg.DataSource = dt;
            job_preferences_dgv.Columns.AddRange(location, locationInput, contents, contentsInput, type, typeInput);
            
        }   //init category and input columns in "job preferences" grid
        private void fill_jobPreferencesDGV()
        {
            job_preferences_dgv.Rows.Add(new string[] { "מקום דינאמי / שקט / רועש", "", "עבודות ניקיון כן / לא", "", "מכירות / שירות לקוחות כן / לא", "" });
            job_preferences_dgv.Rows.Add(new string[] { "עבודה בחוץ / בפנים", "", "עבודה עם חומרים ומים כן / לא", "", "טלפונית / ישירות", "" });
            job_preferences_dgv.Rows.Add(new string[] { "", "", "בעלי חיים כן / לא", "", "מחשב / בלי מחשב", "" });
            job_preferences_dgv.Rows.Add(new string[] { "", "", "צמחייה כן / לא", "", "", "" });
            job_preferences_dgv.Rows.Add(new string[] { "מקום בתוך / מחוץ לעיר", "", "עבודה בישיבה כן / לא", "", "עבודה חרושתית כן / לא", "" });
            job_preferences_dgv.Rows.Add(new string[] { "באזור תעשייה כן / לא", "", "עבודה בעמידה כן / לא", "", "חד-שלבית / מורכבת", "" });
            job_preferences_dgv.Rows.Add(new string[] { "", "", "", "", "בחוץ / בפנים", "" });
            job_preferences_dgv.Rows.Add(new string[] { "בעל רכב פרטי כן / לא", "", "עבודה בקרב אחרים / בודד", "", "עבודה עם מזון כן / לא", "" });
            job_preferences_dgv.Rows.Add(new string[] { "יכול להגיע לעבודה באופן עצמאי כן / לא", "", "עבודה מול אדם / מכונה", "", "מלצור / בישול / מטבח כללי", "" });
            job_preferences_dgv.Rows.Add(new string[] { "עצמאי כן / לא", "", "", "", "בית קפה / מסעדה / קייטרינג", "" });
            job_preferences_dgv.Rows.Add(new string[] { "רישיון כן / לא", "", "", "", "", "" });
            job_preferences_dgv.Rows.Add(new string[] { "", "", "", "", "טיפול באנשים כן / לא", "" });
            job_preferences_dgv.Rows.Add(new string[] { "", "", "", "", "ילדים / קשישים / נכות", "" });


        }   //fill category column in "job preferences" grid

        private void initFieldsFromDT(DataTable dt) //init ALL controls from the data table retrieved from server (represents entire form)
        {

            foreach (DataRow dr in dt.Rows)
            {   
                firstName_tb.Text = dr["firstName"].ToString();
                lastName_tb.Text = dr["lastName"].ToString();
                if (dr["birthday"] != null)
                {
                    birth_dtp.Value = (DateTime)dr["birthday"];
                    birth_dtp.Refresh();
                    birth_dtp.Checked = true;
                }
                else birth_dtp.Value = DateTime.Now;
                city_tb.Text = dr["city"].ToString();
                address_tb.Text = dr["streetAddress"].ToString();
                phone1_tb.Text = dr["phone1"].ToString();
                phone2_tb.Text = dr["phone2"].ToString();
                coordinator_id_tb.Text = dr["coordinatorID"].ToString();

                if (dr["photo"] != null)
                {
                    byte[] bytes = (byte[])dr["photo"];
                    var ms = new System.IO.MemoryStream(bytes);
                    profile_pb.Image = Image.FromStream(ms);
                }
                else
                    profile_pb.Image = Properties.Resources.anonymous_profile;

                Tools.initDataGridFromXML(dr["educationXML"].ToString(), education_dgv);
                Tools.initDataGridFromXML(dr["historyXML"].ToString(), employment_dgv);
                Tools.initDataGridFromXML(dr["jobPreferencesXML"].ToString(), job_preferences_dgv);
                Tools.initDataGridFromXML(dr["skillsXML"].ToString(), skills_dgv);
                initInfoTextBoxes(dr["intec_tabs"].ToString());
                
            }
        }

        private void initInfoTextBoxes(string OrganzierToDeserialize)
        {
            //fill non-necessary text boxes (labeld "xml_*")
            //using dictionary of dictionarys: per tab, and per text controls
            //using custom class - serializable dictionary 
            if (OrganzierToDeserialize.Equals(""))
                return;
            xml_organizer = Tools.DeserializeXML<SerializableDictionary<string, SerializableDictionary<string, string>>>(OrganzierToDeserialize);

            foreach (KeyValuePair<string, SerializableDictionary<string, string>> dic in xml_organizer)
            {
                TabPage page = mitmoded_card_tc.TabPages[dic.Key];
                SerializableDictionary<string, string> xml_tab = dic.Value;
                foreach (KeyValuePair<string, string> textBoxKVP in xml_tab)
                    page.Controls[textBoxKVP.Key].Text = textBoxKVP.Value;
            }
            
        }
        private string textBoxesToDictionary()
        {
            //creates a dictionary of dictionarys, per tab, per text controls
            //using custom class - serializable dictionary 
            //returns the serialization xml as string
            xml_organizer = new SerializableDictionary<string, SerializableDictionary<string, string>>();
            foreach (TabPage page in mitmoded_card_tc.TabPages)
            {
                SerializableDictionary<string, string> xml_tab = new SerializableDictionary<string, string>();
                foreach (Control control in page.Controls)
                {
                    if (control is TextBox)
                        if (control.Name.StartsWith("xml"))
                            xml_tab.Add(control.Name, control.Text);
                        
                }
                xml_organizer.Add(page.Name, xml_tab);
            }
            string serializedOrganizer = Tools.SerializeXML<SerializableDictionary<string, SerializableDictionary<string, string>>>(xml_organizer);
            return serializedOrganizer;

        }

        private void ok_bt_Click(object sender, EventArgs e)
        {

            if (verifyFields())
            {
                //update user photo
                if (profile_pb.ImageLocation != null)
                    imgByte = GetPhoto(profile_pb.ImageLocation);
                //null because no new image was selected 
                else
                    imgByte = imageToByteArray(profile_pb.Image);

                //Serialize gridviews: grid -> data table -> serialized ->XML
                DataTable empEducationDT = Tools.GetContentAsDataTable(education_dgv, true);
                string empEducationXML = Tools.SerializeXML<DataTable>(empEducationDT);

                DataTable empHistoryDT = Tools.GetContentAsDataTable(employment_dgv, true);
                string empHistoryXML = Tools.SerializeXML<DataTable>(empHistoryDT);

                DataTable empJobPreferencesDT = Tools.GetContentAsDataTable(job_preferences_dgv, true);
                string empJobPreferencesXML = Tools.SerializeXML<DataTable>(empJobPreferencesDT);

                DataTable empSkillsDT = Tools.GetContentAsDataTable(skills_dgv, true);
                string empSkillsXML = Tools.SerializeXML<DataTable>(empSkillsDT);

                //Serialize TextBoxes to xml string
                string serializedOrganizer = textBoxesToDictionary();


                //insert data into SQL server
                if (SQLmethods.upsertMitmoded(firstName_tb.Text, lastName_tb.Text, birth_dtp.Value.Date,
                   ID_tb.Text, city_tb.Text, address_tb.Text, phone1_tb.Text, phone2_tb.Text, coordinator_id_tb.Text,
                   imgByte, empEducationXML, empHistoryXML, empJobPreferencesXML, empSkillsXML,
                   serializedOrganizer, cmd))
                    MessageBox.Show("המידע נשמר בהצלחה");
                else
                    MessageBox.Show("אירעה שגיאה בעת שמירת הנתונים");
                this.Close();
            }
        }
        private void cancel_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void profile_pb_Click(object sender, EventArgs e)
        {
            var FD = new System.Windows.Forms.OpenFileDialog();
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                profile_pb.ImageLocation = FD.FileName.ToString();
                imgByte = GetPhoto(profile_pb.ImageLocation);
                imgChanged = true;
            }
        }
        private bool verifyFields()
        {

            if (firstName_tb.Text.Equals(""))
            {
                MessageBox.Show("נא הכנס שם פרטי");
                return false;
            }
            else if (!Tools.IsAlphabets(firstName_tb.Text.ToString()))
            {
                MessageBox.Show("שם פרטי יכול להכיל אותיות בלבד");
                return false;
            }

            if (lastName_tb.Text.Equals(""))
            {
                MessageBox.Show("נא הכנס שם משפחה");
                return false;
            }
            else if (!Tools.IsAlphabets(lastName_tb.Text.ToString()))
            {
                MessageBox.Show("שם משפחה יכול להכיל אותיות בלבד");
                return false;
            }
            if (!birth_dtp.Checked)
            {
                MessageBox.Show("נא לבחור תאריך לידה");
                return false;
            }

            if (ID_tb.Text.Equals(""))
            {
                MessageBox.Show("נא הכנס תעודת זהות");
                return false;
            }
            else if (!Tools.valid_number(ID_tb.Text.ToString()))
            {
                MessageBox.Show("על תעודת הזהות להכיל ספרות בלבד");
                return false;
            }
            else if (ID_tb.Text.ToString().Length != 9)
            {
                MessageBox.Show("על תעודת הזהות להכיל 9 ספרות בדיוק");
                return false;
            }

            if (city_tb.Text.Equals(""))
            {
                MessageBox.Show("נא הכנס עיר מגורים");
                return false;
            }
            else if (!Tools.IsAlphabets(city_tb.Text.ToString()))
            {
                MessageBox.Show("עיר המגורים יכולה להכיל אותיות בלבד");
                return false;
            }

            if (address_tb.Text.Equals(""))
            {
                MessageBox.Show("נא הכנס כתובת");
                return false;
            }
            if (phone1_tb.Text.Equals(""))
            {
                MessageBox.Show("נא הכנס טלפון");
                return false;
            }
            else if (!Tools.valid_number(phone1_tb.Text.ToString()))
            {
                MessageBox.Show("נא הכנס מספר טלפון תקני");
                return false;
            }
            if (!phone2_tb.Text.Equals(""))
            {
                if (!Tools.valid_number(phone2_tb.Text.ToString()))
                {
                    MessageBox.Show("נא הכנס מספר טלפון תקני");
                    return false;
                }
            }
            if (!imgChanged)
            {
                DialogResult dialogResult = MessageBox.Show("לא נבחרה תמונה. האם ברצונך להמשיך?", "אישור בחירת תמונה", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //continue
                }
                else if (dialogResult == DialogResult.No)
                {
                    return false;
                }
            }
            if (coordinator_id_tb.Text.Equals(""))
            {
                MessageBox.Show("נא הכנס תעודת זהות של הרכזת");
                return false;
            }
            else if (!Tools.valid_number(coordinator_id_tb.Text.ToString()))
            {
                MessageBox.Show("על תעודת הזהות להכיל ספרות בלבד");
                return false;
            }
            else if (coordinator_id_tb.Text.ToString().Length != 9)
            {
                MessageBox.Show("על תעודת הזהות להכיל 9 ספרות בדיוק");
                return false;
            }

            return true;
        }
        private byte[] GetPhoto(string imgLoc)
        {
            FileStream stream = new FileStream(
                imgLoc, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            byte[] photo = reader.ReadBytes((int)stream.Length);

            reader.Close();
            stream.Close();
            return photo;
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void MitmodedCard_Load(object sender, EventArgs e)
        {
            
        }

        private void job_preferences_dgv_ColumnDividerDoubleClick(object sender, DataGridViewColumnDividerDoubleClickEventArgs e)
        {

        }
    }
}
