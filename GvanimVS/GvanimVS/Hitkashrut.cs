using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace GvanimVS
{
    public partial class Hitkashrut : DBform
    {
        /* Hitkashrut Form Summary
         * Upload and Download טופס התקשרות
         * 
         */
        private string ID;
        string serializedOrganizer, savedFileName, chosenFileName;
        byte[] savedFileBytes, chosenFileBytes;
        SerializableDictionary<string, string> xml_organizer;
        private bool chosenChanged;

        /// <summary>
        ///  Hitkashrut Empty c-tor (not used)
        /// </summary>
        public Hitkashrut()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Hitkashrut: init form using Mitmoded ID
        /// </summary>
        /// <param name="con"> connection data</param>
        /// <param name="ID"> mitmoded ID</param>
        public Hitkashrut(SqlConnection con, string ID) : base(con)
        {
            InitializeComponent();
            this.ID = ID;
            ID_dynamic_lb.Text = ID;
            xml_organizer = new SerializableDictionary<string, string>();
            DataTable MainDT = SQLmethods.getColsFromTable(SQLmethods.MITMODED, "firstName, lastName, hitkashrutXML", cmd, da);
            savedFileName = null;
            savedFileBytes = null;
            initFieldsFromDT(MainDT);
            chosen_file_lb.Text = "בחרו קובץ חדש לעלות" + "\n" + "Jpeg, Doc, PDF";
            chosenChanged = false;
            
        }
        
        /// <summary>
        /// init labels and file from the DB on the server
        /// </summary>
        /// <param name="dt"> DataTable which holds ID and file info</param>
        private void initFieldsFromDT(DataTable dt)
        {         
            name_dynamic_lb.Text = dt.Rows[0]["firstName"].ToString() + " " + dt.Rows[0]["lastName"].ToString();
            initInfoTextBoxes(dt.Rows[0]["hitkashrutXML"].ToString());
        }
        
        /// <summary>
        /// retrieve labell and file
        /// </summary>
        /// <param name="OrganzierToDeserialize"> serialized dictionary holds string data </param>
        private void initInfoTextBoxes(string OrganzierToDeserialize)
        {
            if (OrganzierToDeserialize.Equals(""))
            {
                last_signed_dynamic_lb.Text = "חסרה חתימה";
                return;
            }
            xml_organizer = Tools.DeserializeXML<SerializableDictionary<string, string>>(OrganzierToDeserialize);
            last_signed_dynamic_lb.Text = xml_organizer["date"];
            string[] fileFromXml =xml_organizer["file"].Split('@');
            saved_file__lb.Text = savedFileName = fileFromXml[0];
            savedFileBytes = strToByte(fileFromXml[1]);
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
                openTempFile(global::GvanimVS.Properties.Resources.hitkashrut, ".pdf");
            }
            catch (System.IO.IOException )
            {
                MessageBox.Show("אין אפשרות לפתוח את המסמך." + "\n" + "ייתכן והוא כבר פתוח.", "שגיאה בפתיחת המסמך", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,  MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
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
                DialogResult dialogResult = MessageBox.Show("שימו לב: העלאת מסמך חדש תמחוק את המסמך הקודם." + "\n" + "האם ברצונכם להמשיך?", "אישור בחירת קובץ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                if (dialogResult == DialogResult.Yes)
                {
                    chosenFileBytes = getFileFromUser();
                    chosen_file_lb.Text = chosenFileName;
                    chosenChanged = true;

                }
                else return;
            }
            else
            {
                chosenFileBytes = getFileFromUser();
                chosen_file_lb.Text = chosenFileName;
                chosenChanged = true;
            }
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
                openTempFile(chosenFileBytes, suffix);
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
        private void upload_pdf_bt_Click(object sender, EventArgs e)
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
                if (SQLmethods.upsertHitkashrut(ID, serializedOrganizer, cmd))
                {
                    MessageBox.Show("המידע נשמר בהצלחה");
                    saved_file__lb.Text = chosenFileName.Substring(chosenFileName.LastIndexOf('\\') + 1);
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
                openTempFile(savedFileBytes, suffix);
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("אין אפשרות לפתוח את המסמך." + "\n" + "ייתכן והוא כבר פתוח.", "שגיאה בפתיחת המסמך", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }

        }

        /// <summary>
        /// helper function: determines if a file exists on dictionary
        /// </summary>
        private void addToOrganizer()
        {
            if (xml_organizer.ContainsKey("file"))
            {
                DialogResult dialogResult = MessageBox.Show("שימו לב: העלאת מסמך חדש תמחוק את המסמך הקודם." + "\n" + "האם ברצונכם להמשיך?", "אישור בחירת קובץ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                if (dialogResult == DialogResult.Yes)
                {
                    string shortName = chosenFileName.Substring(chosenFileName.LastIndexOf('\\') + 1);
                    xml_organizer["file"] = shortName + "@" + byteToStr(chosenFileBytes);
                    xml_organizer["date"] = System.DateTime.Now.ToShortDateString();
                }
                else
                    return;
            }
            else
            {
                string shortName = chosenFileName.Substring(chosenFileName.LastIndexOf('\\') + 1);
                xml_organizer.Add("file", shortName + "@" + byteToStr(chosenFileBytes));
                xml_organizer.Add("date", System.DateTime.Now.ToShortDateString());
            }

        }

        /// <summary>
        /// returns '-' delimited string representation of the byte array
        /// {32,   0,   0,} --> "20-00-00"
        /// </summary>
        /// <param name="bytes"> byteArray to be converted</param>
        /// <returns></returns>
        private string byteToStr(byte[] bytes)
        {
            return BitConverter.ToString(bytes);   
        }

        /// <summary>
        /// returns the original byteArray from the representing string
        ///  "20-00-00" --> {32,   0,   0,}
        /// </summary>
        /// <param name="str"> byteArray as string</param>
        /// <returns></returns>
        private byte[] strToByte (string str)
        {
            string[] tempAry = str.Split('-');
            byte[] decBytes2 = new byte[tempAry.Length];
            for (int i = 0; i < tempAry.Length; i++)
                decBytes2[i] = Convert.ToByte(tempAry[i], 16);
            return decBytes2;
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
                fileLoc, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            byte[] fileByte = reader.ReadBytes((int)stream.Length);

            reader.Close();
            stream.Close();
            return fileByte;
        }

        /// <summary>
        /// open the file for preview
        /// allocates temp file in \TEMP folder
        /// </summary>
        /// <param name="file"> byteArray of file to be opened</param>
        /// <param name="fileType"> file suffix, to be used by system process</param>
        private void openTempFile(byte[] file, string fileType)
        {
            string tempPath = System.IO.Path.GetTempFileName().Replace(".tmp", fileType);
            System.IO.File.WriteAllBytes(tempPath, file);
            System.Diagnostics.Process.Start(tempPath);
        }

       /// <summary>
       /// close the form
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void close_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
