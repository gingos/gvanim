using Spire.Doc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GvanimVS
{
    public partial class CVGenerator : DBform
    {
        byte[] CV1 = global::GvanimVS.Properties.Resources.cv1;
        byte[] CV2 = global::GvanimVS.Properties.Resources.cv2;
        byte[] currentBytes;
        string currentName;

        public CVGenerator(SqlConnection con, string ID) :base(con)
        {
            InitializeComponent();
            ID_dynamic_lb.Text = ID;
            DataTable dt = SQLmethods.getDataTable(SQLmethods.MITMODED, ID, cmd, da);
            if (dt != null)
                initFieldsFromDT(dt);
            // fill the list of existing templates
            LoadFiles();
        }

        private void initFieldsFromDT(DataTable dt)
        {
            name_dynamic_lb.Text = dt.Rows[0]["firstName"].ToString() + " " + dt.Rows[0]["lastName"].ToString();
        }
        
        private void close_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Browse for a new CV file to upload
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void browse_bt_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("האם ברצונכם להעלות קובץ קורות חיים נוסף?", "אישור בחירת קובץ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            //open document, get its original location
            //string fileLoc = BrowseDoc();
            string fileLoc = BrowseFile();

            //get file byte[] and name to store in server
            if (fileLoc != null)
            {
                byte[] data = Tools.GetBytes(fileLoc);
                if (AddCV(data, Path.GetFileName(fileLoc)))
                    LoadFiles();
            }            
        }
               
        /// <summary>
        /// Browse for a new CV file
        /// </summary>
        /// <returns>file path</returns>
        private string BrowseFile()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Word97-2003 files(*.doc)|*.doc|Word2007-2010 files (*.docx)|*.docx|PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            dialog.Title = "Select a file";
            dialog.Multiselect = false;
            dialog.InitialDirectory = System.IO.Path.GetFullPath(@"..\..\..\..\..\..\Data");
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    //Load document from file.
                    using (MemoryStream fileStream = new MemoryStream(Tools.GetBytes(dialog.FileName)))
                    {
                        //load result                   
                        this.officeViewer1.LoadFromStream(fileStream);
                    }
                    //this.docDocumentViewer1.LoadFromFile(dialog.FileName);
                    return dialog.FileName;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "אירעה שגיאה בעת פתיחת הקובץ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return null;

        }

        /// <summary>
        /// Convert file bytes to PDF
        /// </summary>
        /// called when file is NOT standard PDF format: DOC, DOCX etc
        /// <param name="fileBytes">Byte[], byte representation of the file</param>
        /// <returns>PDF stream of file</returns>
        private MemoryStream convertToPDF(byte[] fileBytes)
        {
            Document document = new Document();
            //byte[] fileBytes = Tools.GetBytes(fileName);
            using (Stream fileToStream = new MemoryStream(fileBytes))
            {
                document.LoadFromStream(fileToStream, FileFormat.Auto);
            }
            MemoryStream streamToFile = new MemoryStream();
            document.SaveToStream(streamToFile, FileFormat.PDF);
            return streamToFile;
                        
        }

        /// <summary>
        /// add chosen CV file to database
        /// </summary>
        /// <param name="fileLoc">file path</param>
        private bool AddCV(byte[] fileData, string fileName)
        {
            if (SQLmethods.InsertCV(fileData, fileName, cmd))
            {
                return true; 
            }
            else
            {
                MessageBox.Show("אירעה שגיאה בעת שמירת הנתונים בשרת");
                return false;
            }
        }

        /// <summary>
        /// Load all CV files currently on the server
        /// </summary>
        private void LoadFiles()
        {
            DataTable dt = SQLmethods.getColsFromTable(SQLmethods.CV, "*", cmd, da);
            if (dt != null)
            {
                //hide the id and byte[] columns
                cv_list_dgv.DataSource = dt;
                cv_list_dgv.Columns[0].Visible = false;
                cv_list_dgv.Columns[1].Visible = false;
            }
        }

        /// <summary>
        /// Occurs when user double clicks in part of row in the templates list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cv_list_dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = (DataTable)cv_list_dgv.DataSource;
            //save original file information to later export
            currentBytes = (byte[])dt.Rows[e.RowIndex]["Data"];
            currentName = dt.Rows[e.RowIndex]["Name"].ToString();
            
            using (MemoryStream stream = new MemoryStream(currentBytes))
            {
                officeViewer1.LoadFromStream(stream);
            }
        }

        /// <summary>
        /// Open file currently viewed in Office Viewer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void export_bt_Click(object sender, EventArgs e)
        {
            Tools.openTempFile(currentBytes, currentName.Substring(currentName.LastIndexOf(".")));
        }
    }
}
