using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using Spire.Doc;
using System.Reflection;
using System.Collections.Generic;

namespace GvanimVS
{
    public partial class Confidentiality : DBform
    {
        byte[] CONF_PDF = global::GvanimVS.Properties.Resources.confidentiality_pdf;
        byte[] CONF_DOC = global::GvanimVS.Properties.Resources.confidentiality_doc_template;

        private string ID;
        string serializedOrganizer, savedFileName, chosenFileName;
        byte[] savedFileBytes, chosenFileBytes;
        SerializableDictionary<string, string> xml_organizer;
        private bool chosenChanged;

        private void close_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        public Confidentiality()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Confidentiality: init form using Mitmoded ID
        /// </summary>
        /// <param name="con"> connection data</param>
        /// <param name="ID"> mitmoded ID</param>
        public Confidentiality(SqlConnection con, string ID) : base(con)
        {
            InitializeComponent();
            this.ID = ID;
            initMembers();
            DataTable MainDT = SQLmethods.getColsFromTable(SQLmethods.MITMODED, "firstName, lastName, confidentialityXML", "ID", this.ID, cmd, da);
            if (MainDT != null)
                initFieldsFromDT(MainDT);
        }

        /// <summary>
        /// init global variables & labels
        /// </summary>
        private void initMembers()
        {
            ID_dynamic_lb.Text = ID;
            xml_organizer = new SerializableDictionary<string, string>();
            savedFileName = null;
            savedFileBytes = null;
            chosenChanged = false;
            chosen_file_lb.Text = "בחרו קובץ חדש להעלות" + "\n" + "Jpeg, Doc, PDF";

        }

        /// <summary>
        /// init labels and file from the DB on the server
        /// </summary>
        /// <param name="dt"> DataTable which holds ID and file info</param>
        private void initFieldsFromDT(DataTable dt)
        {
            name_dynamic_lb.Text = dt.Rows[0]["firstName"].ToString() + " " + dt.Rows[0]["lastName"].ToString();
            initInfoTextBoxes(dt.Rows[0]["confidentialityXML"].ToString());
        }

        /// <summary>
        /// retrieve labels and file from server
        /// </summary>
        /// <param name="OrganzierToDeserialize"> serialized dictionary holds string data </param>
        private void initInfoTextBoxes(string OrganzierToDeserialize)
        {
            string[] fileFromXml;
            if (OrganzierToDeserialize.Equals(""))
            {
                return;
            }
            xml_organizer = Tools.DeserializeXML<SerializableDictionary<string, string>>(OrganzierToDeserialize);

            //not all paramters have to change, checking individually
            if (xml_organizer.ContainsKey("date"))
                last_signed_dynamic_lb.Text = xml_organizer["date"];
            else
                last_signed_dynamic_lb.Text = "חסרה חתימה";

            if (xml_organizer.ContainsKey("file"))
            {
                //file is saved as name@byte[]
                fileFromXml = xml_organizer["file"].Split('@');
                saved_file_lb.Text = savedFileName = fileFromXml[0];
                savedFileBytes = Tools.strToByte(fileFromXml[1]);
            }
            else
                saved_file_lb.Text = "עדיין לא נחתם הסכם סודיות";

            if (xml_organizer.ContainsKey("staff_dgv"))
                deserializeDGV(xml_organizer["staff_dgv"]);


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
                Tools.openTempFile(CONF_PDF, ".pdf");
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
            chosenFileBytes = getFileFromUser();
            chosen_file_lb.Text = chosenFileName;
            chosenChanged = true;
            
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
            addToOrganizer();
            serializedOrganizer = Tools.SerializeXML<SerializableDictionary<string, string>>(xml_organizer);
            if (serializedOrganizer != null)
            {
                if (SQLmethods.upsertConfidentiality(ID, serializedOrganizer, cmd))
                {
                    MessageBox.Show("המידע נשמר בהצלחה");
                    saved_file_lb.Text = chosenFileName.Substring(chosenFileName.LastIndexOf('\\') + 1);
                    last_signed_dynamic_lb.Text = xml_organizer["date"].ToString();
                }
                else
                    MessageBox.Show("אירעה שגיאה בעת שמירת הנתונים");
            }
        }

        /// <summary>
        /// show file saved on server (updates after each upload)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// deprecated: using addToOrganizer1
        /// </summary>
        /// helper function: determines if a file exists on dictionary
        private void addToOrganizer2()
        {
            string staff_dgv_xml = serializeDGV();
            if (xml_organizer.ContainsKey("file"))
            {
                DialogResult dialogResult = MessageBox.Show("שימו לב: העלאת מסמך חדש תמחוק את המסמך הקודם." + "\n" + "האם ברצונכם להמשיך?", "אישור בחירת קובץ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                if (dialogResult == DialogResult.Yes)
                {

                    string shortName = chosenFileName.Substring(chosenFileName.LastIndexOf('\\') + 1);
                    //save file as: name@[byte representation]
                    xml_organizer["file"] = shortName + "@" + Tools.byteToStr(chosenFileBytes);
                    xml_organizer["date"] = System.DateTime.Now.ToShortDateString();
                    xml_organizer["staff_dgv"] = staff_dgv_xml;
                }
                else
                    return;
            }
            else
            {
                string shortName = chosenFileName.Substring(chosenFileName.LastIndexOf('\\') + 1);
                xml_organizer["file"] = shortName + "@" + Tools.byteToStr(chosenFileBytes);
                xml_organizer["date"] = System.DateTime.Now.ToShortDateString();
                xml_organizer["staff_dgv"] = staff_dgv_xml;
                //save file as: name@[byte representation]
                //xml_organizer.Add("file", shortName + "@" + byteToStr(chosenFileBytes));
                //xml_organizer.Add("date", System.DateTime.Now.ToShortDateString());
                //xml_organizer.Add("staff_dgv", staff_dgv_xml);                
            }
        }

        /// <summary>
        /// helper function: determines if a file exists on dictionary
        /// </summary>
        private void addToOrganizer()
        {
            string staff_dgv_xml = serializeDGV();
            if (xml_organizer.ContainsKey("file"))
            {
                DialogResult dialogResult = MessageBox.Show("שימו לב: העלאת מסמך חדש תמחוק את המסמך הקודם." + "\n" + "האם ברצונכם להמשיך?", "אישור בחירת קובץ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                
            }
            string shortName = chosenFileName.Substring(chosenFileName.LastIndexOf('\\') + 1);
            xml_organizer["file"] = shortName + "@" + Tools.byteToStr(chosenFileBytes);
            xml_organizer["date"] = System.DateTime.Now.ToShortDateString();
            xml_organizer["staff_dgv"] = staff_dgv_xml;
        }

        /// <summary>
        /// opens fileDialog to choose file
        /// returns byteArray of chosen file
        /// </summary>
        /// <returns></returns>
        private byte[] getFileFromUser()
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

        /// <summary>
        /// Generate a temp Confidentiality Document according to datagridview
        /// add DGV data to xml_dictionary and update SQL
        /// </summary>
        private void export_Click(object sender, EventArgs e)
        {

            exportDoc();
            //serialize datagridview
            string staff_dgv_xml = serializeDGV();
            //update serializer
            if (xml_organizer.ContainsKey("staff_dgv"))
                xml_organizer["staff_dgv"] = staff_dgv_xml;
            else
                xml_organizer.Add("staff_dgv", staff_dgv_xml);
            //update SQL
            serializedOrganizer = Tools.SerializeXML<SerializableDictionary<string, string>>(xml_organizer);
            if (SQLmethods.upsertConfidentiality(ID, serializedOrganizer, cmd))
            {
                MessageBox.Show("המידע נשמר בהצלחה");
            }
            else
                MessageBox.Show("אירעה שגיאה בעת שמירת הנתונים");

        }

        /// <summary>
        /// Generate a temporary Confidentiality Document
        /// template is Resources.confidentiality_doc_template.doc
        /// </summary>
        private void exportDoc()
        {
            //initialize word object  
            Document document = new Document();
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "GvanimVS.Resources.confidentiality_doc_template.doc";
            using (Stream loadStream = assembly.GetManifestResourceStream(resourceName))
                //document.LoadFromFile(samplePath);
                document.LoadFromStream(loadStream, FileFormat.Doc);
            //get strings to replace  
            Dictionary <string, string> dictReplace = GetReplaceDictionary();
            //Replace text  
            foreach (KeyValuePair<string, string> kvp in dictReplace)
            {
                document.Replace(kvp.Key, kvp.Value, true, true);
            }
            //Save doc file.  
            //document.SaveToFile("C:\\Users\\yoadw20\\Desktop\\test1-doc.doc", FileFormat.Doc);
            //Convert to stream.
            MemoryStream ms = new MemoryStream();
            document.SaveToStream(ms, FileFormat.Doc);
            MessageBox.Show("עיבוד המסמך הסתיים" + "\n" + "שימו לב, עדיין חסרה חתימה למסמך עצמו", "עיבוד המסמך", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Tools.openTempFile(ms.ToArray(), ".doc");          
            document.Close();
        }

        /// <summary>
        /// Replaces all place-holders with datagridview and form data
        /// </summary>
        /// <returns>A new dictionary containing place-holders</returns>
        private Dictionary<string, string> GetReplaceDictionary()
        {
            Dictionary<string, string> replaceDict = new Dictionary<string, string>();
            int SIGNED_CONFIDANTES = 4;
            for (int i=0; i< SIGNED_CONFIDANTES; i++)
            {
                if (i >= staff_dgv.Rows.Count)
                {
                    replaceDict.Add("#name" + (i + 1) + "#", "");
                    replaceDict.Add("#role" + (i + 1) + "#", "");
                }
                else
                {
                    //replace with actual name\role if exists, else empty string
                    replaceDict.Add("#name" + (i + 1) + "#", staff_dgv.Rows[i].Cells[0].Value != null ?
                        staff_dgv.Rows[i].Cells[0].Value.ToString() : "");
                    replaceDict.Add("#role" + (i + 1) + "#", staff_dgv.Rows[i].Cells[1].Value != null ?
                        staff_dgv.Rows[i].Cells[1].Value.ToString() : "");
                }
                
            }
            
           
            replaceDict.Add("#fullname#", name_dynamic_lb.Text); 
            replaceDict.Add("#id#", ID_dynamic_lb.Text);
            replaceDict.Add("#date#", DateTime.Now.ToShortDateString());
            
            //string isEmployed = this.radio_isEmployed_Yes.Checked ? "Yes" : "No";
            
            return replaceDict;
        }

        /// <summary>
        /// Serialize table of approved staff
        /// </summary>
        /// <returns></returns>
        private string serializeDGV()
        {
            DataTable dt = Tools.GetContentAsDataTable((DataGridView)staff_dgv, true);
            return Tools.SerializeXML<DataTable>(dt);
            
        }

        /// <summary>
        /// Initialize the staff DGV from the xml string representing it
        /// </summary>
        /// <param name="serializedDGV">xml-string representation of DGV</param>
        private void deserializeDGV(string serializedDGV)
        {
            //DataTable dt = Tools.DeserializeXML<DataTable>(serializedDGV);
            //staff_dgv.DataSource = dt;
            Tools.initDataGridFromXML(serializedDGV, staff_dgv);
            if (staff_dgv.RowCount >= 4)
                staff_dgv.AllowUserToAddRows = false;
        }

        /// <summary>
        /// open file: an empty template of hitkashrut form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void show_pdf_bt_Click_1(object sender, EventArgs e)
        {
            try
            {
                Tools.openTempFile(CONF_PDF, ".pdf");
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("אין אפשרות לפתוח את המסמך." + "\n" + "ייתכן והוא כבר פתוח.", "שגיאה בפתיחת המסמך", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }
        }
        
        /// <summary>
        /// Allow a maximum of 4 people here
        /// if more than 4 rows, adding will be disabled
        /// </summary>
        private void staff_dgv_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (staff_dgv.RowCount > 4)
                staff_dgv.AllowUserToAddRows = false;
        }

        /// <summary>
        /// Allow a maximum of 4 people here
        /// if more than 4 rows, adding will be disabled
        /// </summary>
        private void staff_dgv_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (staff_dgv.RowCount <= 4)
                staff_dgv.AllowUserToAddRows = true;
        }
    }
}
