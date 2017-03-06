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
            //imgChanged = false;
        }
        public MitmodedCard(SqlConnection con, string ID) : base(con)
        {
            InitializeComponent();
            this.ID = ID;
            ID_tb.Text = ID;
            //imgChanged = false;
            MainDT = SQLmethods.getDataTable(SQLmethods.MITMODED, ID, cmd, da);
            initDataGridViews();
            //xml_rehab_validity_cb.DataSource = bindDictionary();
            xml_rehab_validity_cb.DataSource = Tools.bindDictionary2<string, int>(new Dictionary<string, int>
                { { "אנא בחרו משך זמן", 0 }, { "3 חודשים", 3 }, {"6 חודשים", 6 }, {"12 חודשים", 12 } },
                xml_rehab_validity_cb);
            initFieldsFromDT(MainDT);
            
        }

        /// <summary>
        /// init the skills datagrid and job preferences datagrid
        /// </summary>
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

        /// <summary>
        /// fill the category column in the "skills" grid
        /// </summary>
        private void fill_skills()
        {
            // avoid column duplicate by disabling auto colomn creation
            skills_dgv.AutoGenerateColumns = false;
            skills_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            skills_dgv.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // change header font style
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
            skills_dgv.Rows.Add(new string[] { "התמודדות עם תנאים משתנים:" + Environment.NewLine + "-לחץ ממצבים חדשים ושינויים" + Environment.NewLine + "-דרישות התפקיד משתנות" + Environment.NewLine + "-תנאי הסביבה משתנים" , "" });
            skills_dgv.Rows.Add(new string[] { "יכולת לעבודה מורכבת", "" });
            skills_dgv.Rows.Add(new string[] { "יכולת לקבל סמכות / ביקורת", "" });
            skills_dgv.Rows.Add(new string[] { "יכולת לעבודה בזריזות / מהירות", "" });



        }

        /// <summary>
        /// fill category column in "job preferences" grid
        /// </summary>
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

            // save existing rows as read only
            /*
            foreach (DataGridViewRow row in job_preferences_dgv.Rows)
                row.ReadOnly = true;
              */


        }   //

        /// <summary>
        /// init category and input columns in "job preferences" grid
        /// </summary>
        private void init_jobPreferencesDGV()
        {
            // avoid column duplicate by disabling auto colomn creation
            job_preferences_dgv.AutoGenerateColumns = false;
            job_preferences_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            job_preferences_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

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
            job_preferences_dgv.Columns.AddRange(location, locationInput, contents, contentsInput, type, typeInput);
            
        }

        /// <summary>
        /// init ALL controls from the data table retrieved from server (represents entire form)
        /// </summary>
        /// <param name="dt">datatable hold form important fields & xml repr</param>
        private void initFieldsFromDT(DataTable dt) 
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

                if (dr["photo"] != DBNull.Value)    //was dr["photo"] != null
                {
                    byte[] bytes = (byte[])dr["photo"];
                    var ms = new System.IO.MemoryStream(bytes);
                    profile_pb.Image = Image.FromStream(ms);
                }
                else
                    profile_pb.Image = Properties.Resources.anonymous_profile;

                //fill the non-critical form controls
                initInfoTextBoxes(dr["intec_tabs"].ToString());
                
            }
        }

        /// <summary> 
        /// fill the non-critical form controls
        /// </summary>
        /// fill non-necessary text boxes (labeld "xml_*") 
        /// using dictionary of dictionarys: per tab, and per text controls
        /// using custom class - serializable dictionary 
        /// <param name="OrganzierToDeserialize">XML representation of non-critical controls</param>
        private void initInfoTextBoxes(string OrganzierToDeserialize)
        {
            
            if (OrganzierToDeserialize.Equals(""))
                return;

            xml_organizer = Tools.DeserializeXML<SerializableDictionary<string, SerializableDictionary<string, string>>>(OrganzierToDeserialize);

            foreach (KeyValuePair<string, SerializableDictionary<string, string>> dic in xml_organizer)
            {
                TabPage page = mitmoded_card_tc.TabPages[dic.Key];
                SerializableDictionary<string, string> xml_tab = dic.Value;
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
                                ((ComboBox)page.Controls[controlKVP.Key]).SelectedIndex = int.Parse (controlKVP.Value);
                            }
                            else if ((page.Controls[controlKVP.Key] is Panel))
                            {
                                //xml_tab.Add(control.Name, ((Panel)control).Controls.OfType<RadioButton>().First(r => r.Checked).Name);
                                RadioButton rb = (RadioButton)((Panel)page.Controls[controlKVP.Key]).Controls[controlKVP.Value]; 
                                rb.Checked = true;
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
        /// bind a "Text:Value" dictionary to committee duration combo box
        /// </summary>
        private BindingSource bindDictionary()
        {
            //for future reference, this is how you (worst case) access the members
            //int monthsToAdd = ((KeyValuePair<string, int>)xml_rehab_validity_cb.SelectedItem).Value;
            Dictionary<string, int> length = new Dictionary<string, int>();
            length.Add("אנא בחרו משך זמן", 0);
            length.Add("1 חודשים", 1);
            length.Add("3 חודשים", 3);
            length.Add("6 חודשים", 6);
            length.Add("12 חודשים", 12);
            xml_rehab_validity_cb.DisplayMember = "Key";
            xml_rehab_validity_cb.ValueMember = "Value";
            return new BindingSource(length, null);
        }


        /// <summary>
        /// creates a dictionary of dictionarys, per tab, per text controls
        /// </summary>
        /// using custom class - serializable dictionary 
        /// returns the serialization xml as string
        /// <returns>XML repr of non-critical controls</returns>
        private string controlsToDictionary()
        {
            xml_organizer = new SerializableDictionary<string, SerializableDictionary<string, string>>();
            foreach (TabPage page in mitmoded_card_tc.TabPages)
            {
                SerializableDictionary<string, string> xml_tab = new SerializableDictionary<string, string>();
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
                            xml_tab.Add(control.Name, ((Panel)control).Controls.OfType<RadioButton>().First(r => r.Checked).Name);
                    }
                    
                    if (control is DataGridView)
                        {
                            DataTable dt = Tools.GetContentAsDataTable((DataGridView)control, true);
                            string dtToXml = Tools.SerializeXML<DataTable>(dt);
                            xml_tab.Add(control.Name, dtToXml);
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

            if (verifyFields())
            {
                //update user photo
                if (profile_pb.ImageLocation != null)
                    imgByte = GetPhoto(profile_pb.ImageLocation);
                //null because no new image was selected 
                else
                    imgByte = imageToByteArray(profile_pb.Image);
                
                //Serialize TextBoxes to xml string
                string serializedOrganizer = controlsToDictionary();

                
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
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
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
            if (e.RowIndex <=20 && e.ColumnIndex % 2 == 0)
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
            if (e.RowIndex <=12 && e.ColumnIndex % 2 == 0)
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

        private void gender_pnl_VisibleChanged(object sender, EventArgs e)
        {
            Console.WriteLine(sender.ToString());
        }
    }
}
