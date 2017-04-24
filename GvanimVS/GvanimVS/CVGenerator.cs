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

        public CVGenerator(SqlConnection con, string ID) :base(con)
        {
            InitializeComponent();
            ID_dynamic_lb.Text = ID;
            DataTable dt = SQLmethods.getDataTable(SQLmethods.MITMODED, ID, cmd, da);
            if (dt != null)
                initFieldsFromDT(dt);
            LoadFiles();
        }

        private void initFieldsFromDT(DataTable dt)
        {
            name_dynamic_lb.Text = dt.Rows[0]["firstName"].ToString() + " " + dt.Rows[0]["lastName"].ToString();
        }

        /// <summary>
        /// Open cv1 as full template (no name printed, full sample fields exist)
        /// </summary>
        private void cv1_pb_Click(object sender, EventArgs e)
        {
            try
            {
                Tools.openTempFile(CV1, ".docx");
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("אין אפשרות לפתוח את המסמך." + "\n" + "ייתכן והוא כבר פתוח.", "שגיאה בפתיחת המסמך", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }
        }

        /// <summary>
        /// /// Open cv2 as full template (no name printed, full sample fields exist)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cv2_pb_Click(object sender, EventArgs e)
        {
            try
            {
                Tools.openTempFile(CV2, ".doc");
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("אין אפשרות לפתוח את המסמך." + "\n" + "ייתכן והוא כבר פתוח.", "שגיאה בפתיחת המסמך", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }
        }

        private void Open_CV(string v)
        {
            throw new NotImplementedException();
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
            //open a DOC document
            string fileLoc = BrowseDoc();

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
        private string BrowseDoc()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Word97-2003 files(*.doc)|*.doc|Word2007-2010 files (*.docx)|*.docx|All files (*.*)|*.*";
            dialog.Title = "Select a DOC file";
            dialog.Multiselect = false;
            dialog.InitialDirectory = System.IO.Path.GetFullPath(@"..\..\..\..\..\..\Data");
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    //Load DOC document from file.
                    this.docDocumentViewer1.LoadFromFile(dialog.FileName);
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
                cv_list_dgv.DataSource = dt;
                cv_list_dgv.Columns[0].Visible = false;
                cv_list_dgv.Columns[1].Visible = false;
            }
        }

        private void cv_list_dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = (DataTable)cv_list_dgv.DataSource;
            MemoryStream stream = new MemoryStream((byte[])dt.Rows[e.RowIndex]["Data"]);
            
            docDocumentViewer1.LoadFromStream(stream, Spire.Doc.FileFormat.Auto);
            
        }

        private void cv1_bt_Click(object sender, EventArgs e)
        {

        }
    }
}
