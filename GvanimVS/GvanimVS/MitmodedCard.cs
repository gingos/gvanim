using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace GvanimVS
{
    public partial class MitmodedCard : DBform
    {
        byte[] PERSONAL_PDF = global::GvanimVS.Properties.Resources.personal_details;
        byte[] PERSONAL_DOC = global::GvanimVS.Properties.Resources.personal_details_template;


        private byte[] imgByte, chosenFileBytes, savedFileBytes;
        //private bool imgChanged;
        private string mitmodedID, chosenFileName, savedFileName;
        private DataTable MainDT;
        private SerializableDictionary<string, SerializableDictionary<string, string>> xml_organizer;
        private bool chosenChanged;

        public MitmodedCard(SqlConnection con) : base(con)
        {
            InitializeComponent();
            //imgChanged = false;
        }
        public MitmodedCard(SqlConnection con, string mitmodedID, string coordinatorID) : base(con)
        {
            InitializeComponent();

            if (!coordinatorID.Equals(""))
                coordinator_id_tb.Text = coordinatorID;

            if (mitmodedID.Equals(""))
            {    
                this.mitmodedID = mitmodedID;
                InitMembers();
                //imgChanged = false;
                MainDT = SQLmethods.getDataTable(SQLmethods.MITMODED, mitmodedID, cmd, da);
                InitDataGridViews();
                //xml_rehab_validity_cb.DataSource = bindDictionary();
                if (MainDT != null)
                    InitFieldsFromDT(MainDT);

                // change header font style
                // TODO: resets at form show. unknown bug.
                boldRows();
            }
        }

        /// <summary>
        /// Confidentiality: init form using Mitmoded ID
        /// </summary>
        /// <param name="con"> connection data</param>
        /// <param name="ID"> mitmoded ID</param>
        private void InitMembers()
        {
            ID_tb.Text = mitmodedID;
            chosenChanged = false;
            xml_rehab_validity_cb.DataSource = Tools.bindDictionary2<string, int>(new Dictionary<string, int>
                { { "אנא בחרו משך זמן", 0 }, { "3 חודשים", 3 }, {"6 חודשים", 6 }, {"12 חודשים", 12 } },
                xml_rehab_validity_cb);
        }

        /// <summary>
        /// init the skills datagrid and job preferences datagrid
        /// </summary>
        private void InitDataGridViews()
        {
            /*
             * set "Auto Generate Columns" to false
             * now, columns (and data) from data tables will join existing data,
             * not instead of adding the new columns
             */
            xml_education_dgv.AutoGenerateColumns = false;
            xml_employment_dgv.AutoGenerateColumns = false;
            FillSkills();
            InitJobPreferencesDGV();
            FillJobPreferencesDGV();

        }

        /// <summary>
        /// fill the category column in the "skills" grid
        /// </summary>
        private void FillSkills()
        {
            // avoid column duplicate by disabling auto colomn creation
            xml_skills_dgv.AutoGenerateColumns = false;
            xml_skills_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            xml_skills_dgv.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            

            xml_skills_dgv.Rows.Add(new string[] { "מיומנויות תקשורת", "" });
            xml_skills_dgv.Rows.Add(new string[] { "קשר עם עובדים אחרים", "" });
            xml_skills_dgv.Rows.Add(new string[] { "קשר עם לקוחות", "" });
            xml_skills_dgv.Rows.Add(new string[] { "קשר עם סמכות / מנהל", "" });
            xml_skills_dgv.Rows.Add(new string[] { "דרישות אישיות", "" });
            xml_skills_dgv.Rows.Add(new string[] { "יכולת לעבודה פיסית", "" });
            xml_skills_dgv.Rows.Add(new string[] { "יכולת קריאה בעברית ושפות אחרות", "" });
            xml_skills_dgv.Rows.Add(new string[] { "יכולת מילולית בעברית ושפות אחרות", "" });
            xml_skills_dgv.Rows.Add(new string[] { "יכולת כתיבה בעברית ושפות אחרות", "" });
            xml_skills_dgv.Rows.Add(new string[] { "יכולת לחישוב מספרים", "" });
            xml_skills_dgv.Rows.Add(new string[] { "יכולת לעבוד עם כספים", "" });
            xml_skills_dgv.Rows.Add(new string[] { "יכולה לעמידה בזמנים", "" });
            xml_skills_dgv.Rows.Add(new string[] { "יכולת ריכוז", "" });
            xml_skills_dgv.Rows.Add(new string[] { "יוזמה - היכולת לקחת משימה מעבר לנדרש", "" });
            xml_skills_dgv.Rows.Add(new string[] { "יכולת לבצע עבודה עצמאית בהתאם להנחיות", "" });
            xml_skills_dgv.Rows.Add(new string[] { "התמודדות עם תנאים משתנים:" + Environment.NewLine + "-לחץ ממצבים חדשים ושינויים" + Environment.NewLine + "-דרישות התפקיד משתנות" + Environment.NewLine + "-תנאי הסביבה משתנים", "" });
            xml_skills_dgv.Rows.Add(new string[] { "יכולת לעבודה מורכבת", "" });
            xml_skills_dgv.Rows.Add(new string[] { "יכולת לקבל סמכות / ביקורת", "" });
            xml_skills_dgv.Rows.Add(new string[] { "יכולת לעבודה בזריזות / מהירות", "" });

            // change header font style
            boldRows();

        }

        private void boldRows()
        {
            xml_skills_dgv.EnableHeadersVisualStyles = true;
            System.Windows.Forms.DataGridViewCellStyle boldStyle = new System.Windows.Forms.DataGridViewCellStyle();
            boldStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);

            xml_skills_dgv.Rows[0].Cells[0].Style = boldStyle;
            xml_skills_dgv.Rows[4].Cells[0].Style = boldStyle;
            xml_skills_dgv.Rows[13].Cells[0].Style = boldStyle;
        }

        /// <summary>
        /// fill category column in "job preferences" grid
        /// </summary>
        private void FillJobPreferencesDGV()
        {
            xml_job_preferences_dgv.Rows.Add(new string[] { "מקום דינאמי / שקט / רועש", "", "עבודות ניקיון כן / לא", "", "מכירות / שירות לקוחות כן / לא", "" });
            xml_job_preferences_dgv.Rows.Add(new string[] { "עבודה בחוץ / בפנים", "", "עבודה עם חומרים ומים כן / לא", "", "טלפונית / ישירות", "" });
            xml_job_preferences_dgv.Rows.Add(new string[] { "", "", "בעלי חיים כן / לא", "", "מחשב / בלי מחשב", "" });
            xml_job_preferences_dgv.Rows.Add(new string[] { "", "", "צמחייה כן / לא", "", "", "" });
            xml_job_preferences_dgv.Rows.Add(new string[] { "מקום בתוך / מחוץ לעיר", "", "עבודה בישיבה כן / לא", "", "עבודה חרושתית כן / לא", "" });
            xml_job_preferences_dgv.Rows.Add(new string[] { "באזור תעשייה כן / לא", "", "עבודה בעמידה כן / לא", "", "חד-שלבית / מורכבת", "" });
            xml_job_preferences_dgv.Rows.Add(new string[] { "", "", "", "", "בחוץ / בפנים", "" });
            xml_job_preferences_dgv.Rows.Add(new string[] { "בעל רכב פרטי כן / לא", "", "עבודה בקרב אחרים / בודד", "", "עבודה עם מזון כן / לא", "" });
            xml_job_preferences_dgv.Rows.Add(new string[] { "יכול להגיע לעבודה באופן עצמאי כן / לא", "", "עבודה מול אדם / מכונה", "", "מלצור / בישול / מטבח כללי", "" });
            xml_job_preferences_dgv.Rows.Add(new string[] { "עצמאי כן / לא", "", "", "", "בית קפה / מסעדה / קייטרינג", "" });
            xml_job_preferences_dgv.Rows.Add(new string[] { "רישיון כן / לא", "", "", "", "", "" });
            xml_job_preferences_dgv.Rows.Add(new string[] { "", "", "", "", "טיפול באנשים כן / לא", "" });
            xml_job_preferences_dgv.Rows.Add(new string[] { "", "", "", "", "ילדים / קשישים / נכות", "" });

            // save existing rows as read only
            /*
            foreach (DataGridViewRow row in job_preferences_dgv.Rows)
                row.ReadOnly = true;
              */


        }   //

        /// <summary>
        /// init category and input columns in "job preferences" grid
        /// </summary>
        private void InitJobPreferencesDGV()
        {
            // avoid column duplicate by disabling auto colomn creation
            xml_job_preferences_dgv.AutoGenerateColumns = false;
            xml_job_preferences_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            xml_job_preferences_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            DataGridViewTextBoxColumn location = new DataGridViewTextBoxColumn();
            location.HeaderText = "מקום העבודה ומיקומו";
            location.DataPropertyName = "location";
            location.Name = "location";
            //location.ReadOnly = true;

            DataGridViewTextBoxColumn locationInput = new DataGridViewTextBoxColumn();
            locationInput.HeaderText = "אפשרויות";
            locationInput.DataPropertyName = "locationInput";
            locationInput.Name = "locationInput";

            DataGridViewTextBoxColumn contents = new DataGridViewTextBoxColumn();
            contents.HeaderText = "תכני העבודה";
            contents.DataPropertyName = "contents";
            contents.Name = "contents";
            //contents.ReadOnly = true;

            DataGridViewTextBoxColumn contentsInput = new DataGridViewTextBoxColumn();
            contentsInput.HeaderText = "אפשרויות";
            contentsInput.DataPropertyName = "contentsInput";
            contentsInput.Name = "contentsInput";

            DataGridViewTextBoxColumn type = new DataGridViewTextBoxColumn();
            type.HeaderText = "סוג העבודה";
            type.DataPropertyName = "type";
            type.Name = "type";
            //type.ReadOnly = true;

            DataGridViewTextBoxColumn typeInput = new DataGridViewTextBoxColumn();
            typeInput.HeaderText = "אפשרויות";
            typeInput.DataPropertyName = "typeInput";
            typeInput.Name = "typeInput";

            //job_preferences_dg.DataSource = dt;
            xml_job_preferences_dgv.Columns.AddRange(location, locationInput, contents, contentsInput, type, typeInput);

        }

        /// <summary>
        /// init ALL controls from the data table retrieved from server (represents entire form)
        /// </summary>
        /// <param name="dt">datatable hold form important fields & xml repr</param>
        private void InitFieldsFromDT(DataTable dt)
        {

            foreach (DataRow dr in dt.Rows)
            {
                ID_dynamic_lb.Text = mitmodedID;
                firstName_tb.Text = dr["firstName"].ToString();
                lastName_tb.Text = dr["lastName"].ToString();
                name_dynamic_lb.Text = firstName_tb.Text + " " + lastName_tb.Text;
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

                if (dr["photo"] != DBNull.Value)    //was dr["photo"] != null
                {
                    byte[] bytes = (byte[])dr["photo"];
                    var ms = new System.IO.MemoryStream(bytes);
                    profile_pb.Image = Image.FromStream(ms);
                }
                else
                    profile_pb.Image = Properties.Resources.anonymous_profile;

                //fill the non-critical form controls
                InitInfoTextBoxes(dr["intecXML"].ToString());

            }
        }

        /// <summary> 
        /// fill the non-critical form controls
        /// </summary>
        /// fill non-necessary text boxes (labeld "xml_*") 
        /// using dictionary of dictionarys: per tab, and per text controls
        /// using custom class - serializable dictionary 
        /// <param name="OrganzierToDeserialize">XML representation of non-critical controls</param>
        private void InitInfoTextBoxes(string OrganzierToDeserialize)
        {

            if (OrganzierToDeserialize.Equals(""))
                return;

            xml_organizer = Tools.DeserializeXML<SerializableDictionary<string, SerializableDictionary<string, string>>>(OrganzierToDeserialize);

            foreach (KeyValuePair<string, SerializableDictionary<string, string>> dic in xml_organizer)
            {
                TabPage page = mitmoded_card_tc.TabPages[dic.Key];

                SerializableDictionary<string, string> xml_tab = dic.Value;
                if (page.Name.Equals("mitmoded_print_tab"))
                {
                    LoadFileTab(xml_tab);
                    continue;
                }
                foreach (KeyValuePair<string, string> controlKVP in xml_tab)
                {
                    if (controlKVP.Key.StartsWith("xml"))
                    {
                        if (page.Controls.ContainsKey(controlKVP.Key))
                        {
                            if (page.Controls[controlKVP.Key] is TextBox)
                                page.Controls[controlKVP.Key].Text = controlKVP.Value;
                            else if ((page.Controls[controlKVP.Key] is DateTimePicker))
                            {
                                ((DateTimePicker)page.Controls[controlKVP.Key]).Checked = true;
                                ((DateTimePicker)page.Controls[controlKVP.Key]).Value =
                                    DateTime.Parse(controlKVP.Value); //DateTime.ParseExact("dd/MM/yyyy", controlKVP.Value, System.Globalization.CultureInfo.InvariantCulture);
                            }
                            else if ((page.Controls[controlKVP.Key] is ComboBox))
                            {
                                page.Controls[controlKVP.Key].Enabled = true;
                                ((ComboBox)page.Controls[controlKVP.Key]).SelectedIndex = int.Parse(controlKVP.Value);
                            }
                            else if ((page.Controls[controlKVP.Key] is Panel))
                            {
                                //xml_tab.Add(control.Name, ((Panel)control).Controls.OfType<RadioButton>().First(r => r.Checked).Name);
                                RadioButton rb = (RadioButton)((Panel)page.Controls[controlKVP.Key]).Controls[controlKVP.Value];
                                rb.Checked = true;
                            }
                            else if ((page.Controls[controlKVP.Key] is DataGridView))
                            {
                                if (page.Controls.ContainsKey(controlKVP.Key))
                                    Tools.initDataGridFromXML(controlKVP.Value, (DataGridView)page.Controls[controlKVP.Key]);
                            }


                        }

                    }
                    else if (controlKVP.Key.Contains("dgv"))
                    {
                        if (page.Controls.ContainsKey(controlKVP.Key))
                            Tools.initDataGridFromXML(controlKVP.Value, (DataGridView)page.Controls[controlKVP.Key]);
                    }
                }
            }

        }

        /// <summary>
        /// creates a dictionary of dictionarys, per tab, per text controls
        /// </summary>
        /// using custom class - serializable dictionary 
        /// returns the serialization xml as string
        /// <returns>XML repr of non-critical controls</returns>
        private string ControlsToDictionary()
        {
            xml_organizer = new SerializableDictionary<string, SerializableDictionary<string, string>>();
            SerializableDictionary<string, string> xml_tab;
            foreach (TabPage page in mitmoded_card_tc.TabPages)
            {
                if (page.Name.Equals("mitmoded_print_tab"))
                {
                    if (chosenFileBytes != null)
                        SaveFileTab();
                    continue;
                }
                xml_tab = new SerializableDictionary<string, string>();
                foreach (Control control in page.Controls)
                {
                    if (control.Name.StartsWith("xml"))
                    {
                        if (control is TextBox)
                            xml_tab.Add(control.Name, control.Text);
                        else if (control is DateTimePicker && ((DateTimePicker)control).Checked)
                            xml_tab.Add(control.Name, ((DateTimePicker)control).Value.ToShortDateString());
                        else if (control is ComboBox)
                            xml_tab.Add(control.Name, ((ComboBox)control).SelectedIndex.ToString()); //was selected value
                        else if (control is Panel)
                        {
                            if (((Panel)control).Controls.OfType<RadioButton>().Any(r => r.Checked))
                                xml_tab.Add(control.Name, ((Panel)control).Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name);
                        }
                        else if (control is DataGridView)
                        {
                            DataTable dt = Tools.GetContentAsDataTable((DataGridView)control, true);
                            string dtToXml = Tools.SerializeXML<DataTable>(dt);
                            xml_tab.Add(control.Name, dtToXml);
                        }
                    }
                }
                xml_organizer.Add(page.Name, xml_tab);
            }
            string serializedOrganizer = Tools.SerializeXML<SerializableDictionary<string, SerializableDictionary<string, string>>>(xml_organizer);
            return serializedOrganizer;

        }

        /// <summary>
        /// save all information to database
        /// </summary>
        private void ok_bt_Click(object sender, EventArgs e)
        {

            if (VerifyFields())
            {
                //update user photo
                if (profile_pb.ImageLocation != null)
                    imgByte = GetPhoto(profile_pb.ImageLocation);
                //null because no new image was selected 
                else
                    imgByte = ImageToByteArray(profile_pb.Image);

                //Serialize TextBoxes to xml string
                string serializedOrganizer = ControlsToDictionary();


                //insert data into SQL server
                if (SQLmethods.upsertMitmoded(firstName_tb.Text, lastName_tb.Text, birth_dtp.Value.Date,
                   ID_tb.Text, city_tb.Text, address_tb.Text, phone1_tb.Text, phone2_tb.Text, coordinator_id_tb.Text,
                   imgByte, serializedOrganizer, cmd))
                    MessageBox.Show("המידע נשמר בהצלחה");
                else
                    MessageBox.Show("אירעה שגיאה בעת שמירת הנתונים");

                this.Close();
            }
        }

        /// <summary>
        /// Verify all critical fields before save
        /// </summary>
        /// <returns>true if all are valid, false if one or more not</returns>
        private bool VerifyFields()
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
            /*
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
            */
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

            if (xml_rehab_committee_dtp.Checked && xml_rehab_validity_cb.SelectedIndex == 0)
            {
                MessageBox.Show("יש לבחור משך תוקף לאישור ההעסקה");
                return false;
            }

            return true;
        }

        /// <summary>
        /// close form
        /// </summary>
        private void cancel_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// change user photo
        /// </summary>
        private void profile_pb_Click(object sender, EventArgs e)
        {
            var FD = new System.Windows.Forms.OpenFileDialog();
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                profile_pb.ImageLocation = FD.FileName.ToString();
                imgByte = GetPhoto(profile_pb.ImageLocation);
                //imgChanged = true;
            }
        }

        /// <summary>
        /// convert chose path to image byte[]
        /// </summary>
        /// <param name="imgLoc">path of image on user pc</param>
        /// <returns>byte[] representation of image</returns>
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

        /// <summary>
        /// convert image resource from Image type to byte[]
        /// </summary>
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        /// <summary>
        /// only allow delete of rows with index >20
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skills_dgv_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row.Index <= 20)
                e.Cancel = true;

        }

        /// <summary>
        /// only allow delete of user content cells
        /// </summary>
        /// ignore action if cell changed is from system column (all even columns)
        private void skills_dgv_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex <= 20 && e.ColumnIndex % 2 == 0)
                e.Cancel = true;
        }

        /// <summary>
        /// only allow delete of rows with index >12
        /// </summary>        
        private void job_preferences_dgv_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row.Index <= 12)
                e.Cancel = true;
        }

        /// <summary>
        /// only allow delete of user content cells
        /// </summary>
        /// ignore action if cell changed is from system column (all even columns)
        private void job_preferences_dgv_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex <= 12 && e.ColumnIndex % 2 == 0)
                e.Cancel = true;
        }

        /// <summary>
        /// add selected duration (in months) to committee's deadline
        /// </summary>
        private void xml_rehab_validity_cm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (xml_rehab_validity_cb.SelectedIndex != 0)
            {
                DateTime expires = xml_rehab_committee_dtp.Value;
                int monthsToAdd = (int)xml_rehab_validity_cb.SelectedValue;
                xml_rehab_validity_expires_lb.Text = expires.AddMonths(monthsToAdd).ToShortDateString();
            }
        }

        /// <summary>
        /// make the duration combo box "Enabled" only when committee approval date is chosen
        /// </summary>
        private void rehab_committee_dtp_ValueChanged(object sender, EventArgs e)
        {
            xml_rehab_validity_cb.Enabled = xml_rehab_committee_dtp.Checked ? true : false;
        }

        /// <summary>
        /// open file: an empty template of hitkashrut form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void show_pdf_bt_Click(object sender, EventArgs e)
        {
            try
            {
                Tools.openTempFile(PERSONAL_PDF, ".pdf");
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("אין אפשרות לפתוח את המסמך." + "\n" + "ייתכן והוא כבר פתוח.", "שגיאה בפתיחת המסמך", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }
        }

        /// <summary>
        /// opens dialog box to choose which file to upload
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void choose_file_bt_Click(object sender, EventArgs e)
        {
            if (chosenChanged)
            {
                DialogResult dialogResult = MessageBox.Show("שימו לב: נבחר קובץ זמני. האם להחליפו?", "אישור בחירת קובץ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                if (dialogResult == DialogResult.No)
                    return;
            }
            chosenFileBytes = GetFileFromUser();
            chosen_file_lb.Text = chosenFileName;
            chosenChanged = true;
        }

        /// <summary>
        /// opens fileDialog to choose file
        /// returns byteArray of chosen file
        /// </summary>
        /// <returns></returns>
        private byte[] GetFileFromUser()
        {
            var FD = new System.Windows.Forms.OpenFileDialog();
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                chosenFileName = FD.FileName.ToString();
                return GetBytes(chosenFileName);
            }
            else
                return null;
        }

        /// <summary>
        /// return the byteArray of chosen file
        /// </summary>
        /// <param name="fileLoc"> file full path, to be converted to byteArray</param>
        /// <returns></returns>
        private byte[] GetBytes(string fileLoc)
        {
            FileStream stream = new FileStream(
                fileLoc, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            BinaryReader reader = new BinaryReader(stream);
            byte[] fileByte = reader.ReadBytes((int)stream.Length);

            reader.Close();
            stream.Close();
            return fileByte;
        }

        private void preview_saved_bt_Click(object sender, EventArgs e)
        {
            if (savedFileBytes == null)
            {
                MessageBox.Show("יש לשמור קובץ");
                return;
            }

            string suffix = savedFileName.Substring(savedFileName.LastIndexOf("."));
            try
            {
                Tools.openTempFile(savedFileBytes, suffix);
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("אין אפשרות לפתוח את המסמך." + "\n" + "ייתכן והוא כבר פתוח.", "שגיאה בפתיחת המסמך", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }
        }

        private void export_bt_Click(object sender, EventArgs e)
        {
            ExportDoc();
            //serialize datagridview
            //string staff_dgv_xml = serializeDGV();

            //update serializer
            //xml_organizer["staff_dgv"] = staff_dgv_xml;

            //update SQL
            /*
            serializedOrganizer = Tools.SerializeXML<SerializableDictionary<string, string>>(xml_organizer);
            if (SQLmethods.updateXMLFormInDB(SQLmethods.MITMODED, "confidentialityXML", "ID", ID, serializedOrganizer, cmd))
            {
                MessageBox.Show("המידע נשמר בהצלחה");
            }
            else
                MessageBox.Show("אירעה שגיאה בעת שמירת הנתונים");\
            */
        }

        /// <summary>
        /// preview selected file (warns user if not chosen)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void preview_selected_bt_Click(object sender, EventArgs e)
        {
            if (chosenFileBytes == null)
            {
                MessageBox.Show("יש לבחור קובץ");
                return;
            }
            // get suffix to decide file type   
            string suffix = chosenFileName.Substring(chosenFileName.LastIndexOf("."));
            try
            {
                Tools.openTempFile(chosenFileBytes, suffix);
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("אין אפשרות לפתוח את המסמך." + "\n" + "ייתכן והוא כבר פתוח.", "שגיאה בפתיחת המסמך", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }

        }

        /// <summary>
        /// update dictionary and upload it to SQL. can only hold one record!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void upload_file_bt_Click(object sender, EventArgs e)
        {
            if (chosenFileBytes == null)
            {
                MessageBox.Show("יש לבחור קובץ קודם");
                return;
            }
            if (xml_organizer.ContainsKey("mitmoded_print_tab"))
            {
                DialogResult dialogResult = MessageBox.Show("שימו לב: העלאת מסמך חדש תמחוק את המסמך הקודם." + "\n" + "האם ברצונכם להמשיך?", "אישור בחירת קובץ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }

            //add "file and print" tab to organizer
            SaveFileTab();
            string serializedOrganizer = Tools.SerializeXML<SerializableDictionary<string, SerializableDictionary<string, string>>>(xml_organizer);
            if (serializedOrganizer != null)
            {
                if (SQLmethods.updateXMLFormInDB(SQLmethods.MITMODED, "intecXML", "ID", mitmodedID, serializedOrganizer, cmd))
                {
                    MessageBox.Show("המידע נשמר בהצלחה");
                    xml_saved_file_lb.Text = chosenFileName.Substring(chosenFileName.LastIndexOf('\\') + 1);
                    xml_last_signed_dynamic_lb.Text = xml_organizer["mitmoded_print_tab"]["xml_last_signed_dynamic_lb"].ToString();
                }
                else
                    MessageBox.Show("אירעה שגיאה בעת שמירת הנתונים");
            }
        }

        /// <summary>
        /// add "file and print" tab to xml organizer
        /// </summary>
        private void SaveFileTab()
        {
            string shortName = chosenFileName.Substring(chosenFileName.LastIndexOf('\\') + 1);
            savedFileBytes = chosenFileBytes;

            SerializableDictionary<string, string> print_tab = new SerializableDictionary<string, string>();
            print_tab["savedfilebytes"] = Tools.byteToStr(chosenFileBytes);
            print_tab["xml_saved_file_lb"] = shortName;
            print_tab["xml_last_signed_dynamic_lb"] = System.DateTime.Now.ToShortDateString();

            xml_organizer["mitmoded_print_tab"] = print_tab;
        }

        /// <summary>
        /// load "file and print" tab info from dictionary
        /// </summary>
        /// <param name="dic"></param>
        private void LoadFileTab(Dictionary<string, string> dic)
        {
            savedFileBytes = Tools.strToByte(dic["savedfilebytes"]);
            xml_saved_file_lb.Text = savedFileName = dic["xml_saved_file_lb"];
            xml_last_signed_dynamic_lb.Text = dic["xml_last_signed_dynamic_lb"];
        }

        /// <summary>
        /// Generate a temporary MitmodedCard Document
        /// template is Resources.personal_details_template.doc
        /// </summary>
        private void ExportDoc()
        {
            //initialize word object  
            Document document = new Document();
            //Support right to left fields
            document.IsUpdateFields = true;
            
            Assembly assembly = Assembly.GetExecutingAssembly();
            string resourceName = "GvanimVS.Resources.personal_details_template.doc";
            using (Stream loadStream = assembly.GetManifestResourceStream(resourceName))
                //document.LoadFromFile(samplePath);
                document.LoadFromStream(loadStream, FileFormat.Doc);

            //replace all "#placeholder#" with form text box values
            ReplacePlaceHoldersWithTextBoxes(document);

            //replace all "#placeholder#" with datagrids
            ReplacePlaceHoldersWithDataGrid(document, "#"+xml_education_dgv.Name+"#", xml_education_dgv);
            ReplacePlaceHoldersWithDataGrid(document, "#" + xml_employment_dgv.Name + "#", xml_employment_dgv);
            ReplacePlaceHoldersWithDataGrid(document, "#" + xml_job_preferences_dgv.Name + "#", xml_job_preferences_dgv);
            ReplacePlaceHoldersWithDataGrid(document, "#" + xml_skills_dgv.Name + "#", xml_skills_dgv);


            //Save doc file.  
            //document.SaveToFile("C:\\Users\\yoadw20\\Desktop\\test1-doc.doc", FileFormat.Doc);
            //Convert to stream.
            MemoryStream ms = new MemoryStream();
            document.SaveToStream(ms, FileFormat.Doc);
            MessageBox.Show("עיבוד המסמך הסתיים" + "\n" + "שימו לב, עדיין חסרה חתימה למסמך עצמו", "עיבוד המסמך", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            Tools.openTempFile(ms.ToArray(), ".doc");
            document.Close();
        }

        /// <summary>
        /// Replace a placeholder with table from dgv
        /// </summary>
        /// <param name="document">Opened working document</param>
        /// <param name="placeHolder">format "#name#" in document</param>
        /// <param name="dgv">datagridview table in form</param>
        private void ReplacePlaceHoldersWithDataGrid(Document document, string placeHolder, DataGridView dgv)
        {
            //Return TextSection by finding the key placeholder string
            Section section = document.Sections[0];
            TextSelection selection = document.FindString(placeHolder, true, true);

            //Return TextRange from TextSection, then get OwnerParagraph through TextRange.
            Spire.Doc.Fields.TextRange range = selection.GetAsOneRange();
            Paragraph paragraph = range.OwnerParagraph;

            //Return the zero-based index of the specified paragraph.
            Body body = paragraph.OwnerTextBody;
            int index = body.ChildObjects.IndexOf(paragraph);

            //Create a new empty table.
            Table table = section.AddTable(true);
            table.ResetCells(dgv.RowCount+1, dgv.ColumnCount);

            //Fill table.
            fillDocumentTable(table, dgv);

            //Remove the paragraph and insert table into the collection at the specified index.
            body.ChildObjects.Remove(paragraph);
            body.ChildObjects.Insert(index, table);            

        }

        /// <summary>
        /// Fill table according to specified datagridview
        /// </summary>
        /// <param name="table">Table in working document</param>
        /// <param name="dgv">Datagridview in form</param>
        private void fillDocumentTable(Table table, DataGridView dgv)
        {
            //DataTable dt = Tools.GetContentAsDataTable(dgv);
            //Header Row
            TableRow FRow = table.Rows[0];
            FRow.IsHeader = true;
            //Row Height
            FRow.Height = 23;
            //Header Format
            FRow.RowFormat.BackColor = Color.White;
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                //Cell Alignment
                Paragraph p = FRow.Cells[i].AddParagraph();
                FRow.Cells[i].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                p.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                p.Format.IsBidi = true;
                //Data Format
                Spire.Doc.Fields.TextRange TR = p.AppendText(dgv.Columns[dgv.ColumnCount - i - 1].HeaderText);
                TR.CharacterFormat.FontName = "Arial";
                TR.CharacterFormat.FontSize = 14;
                TR.CharacterFormat.Bidi = true;
            }

            //Data Row
            for (int r = 0; r < dgv.RowCount -1 ; r++)
            {
                TableRow DataRow = table.Rows[r + 1];
                //Row Height
                DataRow.Height = 20;
                //C Represents Column.
                for (int c = 0; c < dgv.ColumnCount; c++)
                {
                    //Cell Alignment
                    DataRow.Cells[c].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                    //Fill Data in Rows
                    Paragraph p2 = DataRow.Cells[c].AddParagraph();
                    p2.Format.IsBidi = true;
                    Spire.Doc.Fields.TextRange TR2 = p2.AppendText(dgv[dgv.ColumnCount - c -1 , r].Value.ToString());
                    TR2.CharacterFormat.Bidi = true;
                    //Format Cells
                    p2.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                    TR2.CharacterFormat.FontName = "Arial";
                    TR2.CharacterFormat.FontSize = 12;
                }
            }

        }
        
        /// <summary>
        /// Replace all placeholders with values from text boxes
        /// </summary>
        /// <param name="document">Open working document</param>
        private void ReplacePlaceHoldersWithTextBoxes(Document document)
        {
            //get strings to replace  
            Dictionary<string, string> dictReplace = GetReplaceDictionary();
            //Replace text  
            foreach (KeyValuePair<string, string> kvp in dictReplace)
            {
                //deprecated: document.Replace(kvp.Key, kvp.Value, true, true);
                Paragraph paragraph = new Paragraph(document);
                paragraph.Format.IsBidi = true;
                Spire.Doc.Fields.TextRange tr = paragraph.AppendText(kvp.Value);
                tr.CharacterFormat.Bidi = true;
                TextSelection ts = new TextSelection(paragraph, 0, kvp.Value.Length);
                document.Replace(kvp.Key, ts, true, true);
            }
        }

        /// <summary>
        /// Define all Key-Value Pairs in "replacement dicionary"
        /// </summary>
        private Dictionary<string, string> GetReplaceDictionary()
        {
            Dictionary<string, string> replaceDict = new Dictionary<string, string>();

            replaceDict["#firstname#"] = firstName_tb.Text;
            replaceDict["#lastname#"] = lastName_tb.Text;
            replaceDict["#id#"] = mitmodedID;
            replaceDict["#dateofbirth#"] = birth_dtp.Value.ToShortDateString();
            try
            {
                replaceDict["#gender#"] = xml_gender_pnl.Controls.OfType<RadioButton>().First(r => r.Checked).Text;
            }
            catch (InvalidOperationException)
            {
                replaceDict["#gender#"] = "";
            }
            replaceDict["#familystatus#"] = xml_family_status_tb.Text;
            replaceDict["#street#"] = address_tb.Text;
            replaceDict["#city#"] = city_tb.Text ;
            replaceDict["#phone1#"] = phone1_tb.Text;
            replaceDict["#phone2#"] = phone2_tb.Text;
            replaceDict["#familycontactname#"] = xml_family_contact_name_tb.Text;
            replaceDict["#familycontactphone#"] = xml_family_contact_phone_tb.Text;
            replaceDict["#emergency1name#"] = xml_emergency_contact1_name_tb.Text;
            replaceDict["#emergency2name#"] = xml_emergency_contact2_name_tb.Text;
            replaceDict["#emergency3name#"] = xml_emergency_contact3_name_tb.Text;
            replaceDict["#emergency1phone#"] = xml_emergency_contact1_phone_tb.Text;
            replaceDict["#emergency2phone#"] = xml_emergency_contact2_phone_tb.Text;
            replaceDict["#emergency3phone#"] = xml_emergency_contact3_phone_tb.Text;
            replaceDict["#referalname#"] = xml_referer_tb.Text ;
            replaceDict["#referalphone#"] = xml_referer_phone_tb.Text ;
            replaceDict["#communityname#"] = xml_community_name_tb.Text;
            replaceDict["#communityphone#"] = xml_community_phone_tb.Text ;
            replaceDict["#psychiatricname#"] = xml_psychiatrist_name_tb.Text;
            replaceDict["#psychiatricphone#"] = xml_psychiatrist_phone_tb.Text ;
            replaceDict["#generalinfo#"] = xml_general_info_tb.Text;
            replaceDict["#addictions#"] = xml_addictions_tb.Text ;
            replaceDict["#violence#"] = xml_violence_tb.Text ;
            replaceDict["#suicide#"] = xml_homicidal_tb.Text;
            replaceDict["#medicalissues#"] = xml_medical_issues_tb.Text;
            replaceDict["#psychiatricfollowup#"] = xml_psych_track_tb.Text;
            replaceDict["#meds#"] = xml_meds_tb.Text;
            replaceDict["#army#"] = xml_military_tb.Text;
            replaceDict["#recreational#"] = xml_rec_activity_tb.Text;
            replaceDict["#employmentreason#"] = xml_reason_tb.Text;
            replaceDict["#employmentdream1#"] = xml_dream_tb.Text;
            replaceDict["#strengths#"] = xml_strengths_tb.Text;
            replaceDict["#weaknesses#"] = xml_weakness_tb.Text ;
            replaceDict["#employmentdream2#"] = xml_dream_todo_tb.Text;
            replaceDict["#toaquire#"] = xml_skills_improve_tb.Text;
            replaceDict["#jobscope#"] = xml_job_scope_tb.Text;
            replaceDict["#jobdays#"] = xml_job_days_tb.Text;
            replaceDict["#dayoff#"] = xml_job_day_off_tb.Text;
            replaceDict["#maxhours#"] = xml_job_max_hours_tb.Text;
            replaceDict["#jobhours#"] = xml_job_hours_tb.Text;
            replaceDict["#jobexpectations#"] = xml_job_sal_expc_tb.Text;
            replaceDict["#jobdiffculties#"] = xml_job_previous_hardships_tb.Text;
            replaceDict["#supertarget#"] = xml_job_target_tb.Text;
            replaceDict["#jobimportant#"] = xml_job_free_text_tb.Text;
            replaceDict["#firstgoals#"] = xml_job_first_targets_tb.Text;
            replaceDict["#chaperon#"] = "";
            replaceDict["#employee#"] = "";
            replaceDict["#date#"] = DateTime.Now.ToShortDateString();


            //string isEmployed = this.radio_isEmployed_Yes.Checked ? "Yes" : "No";

            return replaceDict;
        }

        /// <summary>
        /// Calculate Mitmoded Score
        /// </summary>
        /// Scans free text for key words, number of past jobs, and strong\weak points
        /// <param name="score">initial score = 100</param>
        /// <returns>updated mitmoded score</returns>
        internal double CalculateIntecScore(double score)
        {
            score = ScanBagOfWords(score);
            score = ScanJobs(score);
            score = ScanEducation(score);
            score = ScanAttributes(score);
            return score;
        }

        /// <summary>
        /// Scan all textboxes for free text containing key words
        /// </summary>
        /// <param name="score"></param>
        /// <returns></returns>
        private double ScanBagOfWords(double score)
        {
            Dictionary<string, double> bag = CreateBagOfWords();
            foreach (TabPage page in mitmoded_card_tc.TabPages)
            {
                foreach (Control control in page.Controls)
                {
                    if (control is TextBox)
                    {
                        foreach (string key in bag.Keys)
                        {
                            if (control.Text.Contains(key))
                            {
                                score -= bag[key];
                                Console.WriteLine("found word: " + key + ", new score is " + score);
                            }
                        }
                    }
                }
            }
            return score;
        }

        /// <summary>
        /// Calculate Score by number of different jobs or too little employment total time
        /// </summary>
        /// <param name="score"></param>
        /// <returns></returns>
        private double ScanJobs (double score)
        {
            double yearsEmployed =0;
            int differentJobs = xml_employment_dgv.Rows.Count;
            if (differentJobs > 10)
            {
                Console.WriteLine("Above {} different jobs, not steady", differentJobs);
                score -= 5;
            }
            else if (differentJobs < 3)
            {
                for (int i=0; i < xml_employment_dgv.Rows.Count -1; i++ ){
                    DataGridViewRow row = xml_employment_dgv.Rows[i];
                    // try to calculate time spent according to year column
                    // if text is range, calculate it
                    string exp = row.Cells[0].Value.ToString();
                    if (exp.Contains("-"))
                    {
                        var sum = (new DataTable().Compute(exp, ""));
                        Decimal dsum = Convert.ToDecimal(sum);
                        dsum = Math.Abs(dsum);
                        Console.WriteLine("spent {0} years at job {1}", dsum, row.Cells[1].Value);
                        yearsEmployed += Convert.ToDouble(dsum);
                    }
                    //if only specified one year or empty
                    else
                        yearsEmployed += 1;
                }
                if (yearsEmployed < 3)
                {
                    Console.WriteLine("total years employed is {0}, too few", yearsEmployed);
                    score -= 10;
                }
            }

            return score;
        }

        private void choose_file_bt_MouseHover(object sender, EventArgs e)
        {
            choose_file_bt.BackColor = Color.RoyalBlue;
        }

        private void choose_file_bt_MouseLeave(object sender, EventArgs e)
        {
            choose_file_bt.BackColor = Color.CornflowerBlue;
        }

        private void preview_selected_bt_MouseHover(object sender, EventArgs e)
        {
            preview_selected_bt.BackColor = Color.RoyalBlue;
        }

        private void preview_selected_bt_MouseLeave(object sender, EventArgs e)
        {
            preview_selected_bt.BackColor = Color.CornflowerBlue;
        }

        private void upload_file_bt_MouseHover(object sender, EventArgs e)
        {
            upload_file_bt.BackColor = Color.RoyalBlue;
        }

        private void upload_file_bt_MouseLeave(object sender, EventArgs e)
        {
            upload_file_bt.BackColor = Color.CornflowerBlue;
        }

        private void preview_saved_bt_MouseHover(object sender, EventArgs e)
        {
            preview_saved_bt.BackColor = Color.RoyalBlue;
        }

        private void preview_saved_bt_MouseLeave(object sender, EventArgs e)
        {
            preview_saved_bt.BackColor = Color.CornflowerBlue;
        }

        private void show_pdf_bt_MouseHover(object sender, EventArgs e)
        {
            show_pdf_bt.BackColor = Color.RoyalBlue;
        }

        private void show_pdf_bt_MouseLeave(object sender, EventArgs e)
        {
            show_pdf_bt.BackColor = Color.CornflowerBlue;
        }

        private void export_bt_MouseHover(object sender, EventArgs e)
        {
            export_bt.BackColor = Color.RoyalBlue;
        }

        private void export_bt_MouseLeave(object sender, EventArgs e)
        {
            export_bt.BackColor = Color.CornflowerBlue;
        }

        private void ok_bt_MouseHover(object sender, EventArgs e)
        {
            ok_bt.BackColor = Color.RoyalBlue;
        }

        private void ok_bt_MouseLeave(object sender, EventArgs e)
        {
            ok_bt.BackColor = Color.CornflowerBlue;
        }

        private void cancel_bt_MouseHover(object sender, EventArgs e)
        {
            cancel_bt.BackColor = Color.RoyalBlue;
        }

        private void cancel_bt_MouseLeave(object sender, EventArgs e)
        {
            cancel_bt.BackColor = Color.CornflowerBlue;
        }

        private void mitmoded_personal_tab_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Calculate score by number of education institutes
        /// </summary>
        /// Increases score by 10 if university found, decrease by 5 if not
        /// Also decrease if less than 2 institutes
        /// <param name="score"></param>
        /// <returns></returns>
        private double ScanEducation (double score)
        {
            //string[] column0Array = new string[xml_education_dgv.Rows.Count];
            int numOfEduPlaces;
            var query = xml_education_dgv.Rows.
                Cast<DataGridViewRow>().
                Where(r => r.Cells["education_dg_edu_col"].Value !=null &&
                r.Cells["education_dg_edu_col"].Value.ToString().Equals("אוניברסיטה"))
                .ToArray();
            
            if ( query.Length!= 0)
            {
                score += 10;
                Console.WriteLine("university found, score + 10");
            }
            else
            {
                score -= 5;
                Console.WriteLine("university not found, score - 5");
                // also not enough education institues
                // it is possible for university to be the only institute - that's a good thing
                numOfEduPlaces = xml_education_dgv.Rows.Count;
                //less than 3, actually checks for 2, always an empty row is present in datagrid
                if (numOfEduPlaces < 3)
                {
                    score -= 5;
                    Console.WriteLine("only {0} education institutes found, score is now {1}", numOfEduPlaces, score);
                }
            }
                return score;
        }

        /// <summary>
        /// Scan skills for low and medium abilities
        /// </summary>
        /// <param name="score"></param>
        /// <returns></returns>
        private double ScanAttributes (double score)
        {
            //Make a list <string> of the column "skill description" in the skills datagrid
            List<string> list = xml_skills_dgv.Rows
                             .OfType<DataGridViewRow>()
                             .Where(r => r.Cells["notes_col"].Value != null)
                             .Select(r => r.Cells["notes_col"].Value.ToString())
                             .ToList();
            Dictionary<string, double> skillsIndex = CreateSkillIndex();
            foreach (var item in list)
            {
                if (item.Contains("נמוך") || item.Contains("נמוכה"))
                {
                    score -= 2.5;
                    Console.WriteLine("low skill, score-= 2.5, is now {0}", score);
                }
                else if (item.Contains("בינונית") || item.Contains("בינונית"))
                {
                    score -= 1.0;
                    Console.WriteLine("medium skill, score-= 1.0, is now {0}", score);
                }

            }
            return score;
        }

        private Dictionary<string, double> CreateBagOfWords()
        {
            return new Dictionary<string, double> { { "עצוב", 1.5 }, { "דכאון", 2.5 }, { "אכזבה", 2.5 }, {"קשה",1.5 },
                {"מתקשה",2.25 } };
        }

        private Dictionary<string, double> CreateSkillIndex()
        {
            return new Dictionary<string, double> { { "נמוך", 2.5 }, { "נמוכה", 2.5 }, { "בינוני", 1.0 }, {"בינונית",1.0 },
                 };
        }
    }
}
