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
    public partial class RelatedDocs : DBform
    {
        private byte[] currentBytes;
        private string currentName;

        public RelatedDocs(SqlConnection con, string ID) : base(con)
        {
            InitializeComponent();
            id_dynamic_lb.Text = ID;
            DataTable dt = SQLmethods.getDataTable(SQLmethods.MITMODED, ID, cmd, da);
            if (dt != null)
                initFieldsFromDT(dt);
            // fill the list of existing templates
            LoadFiles();
        }

        /// <summary>
        /// Init name and ID labels of user
        /// </summary>
        /// Init according to datatable from server.
        /// <param name="dt"></param>
        private void initFieldsFromDT(DataTable dt)
        {
            name_dynamic_lb.Text = dt.Rows[0]["firstName"].ToString() + " " + dt.Rows[0]["lastName"].ToString();
        }

        /// <summary>
        /// Load all extra files currently on the server (that belong to that user)
        /// </summary>
        private void LoadFiles()
        {
            DataTable dt = SQLmethods.getColsFromTable(SQLmethods.EXTRA, "MitmodedID, Owner, FileName, CreatedDate, FileData", cmd, da);
            if (dt != null)
            {
                //hide the id and byte[] columns
                extra_files_dgv.DataSource = dt;
                extra_files_dgv.Columns[4].Visible = false;
            }
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
            string UserAnswer = Microsoft.VisualBasic.Interaction.InputBox("נא להזין את שם מחבר הקובץ", "בחירת קובץ חדש", "Default Response");

            //open document, get its original location
            string fileLoc = BrowseFile();

            //get file byte[] and name to store in server
            if (fileLoc != null)
            {
                byte[] data = Tools.GetBytes(fileLoc);
                if (AddFile(data, Path.GetFileName(fileLoc), UserAnswer))
                    LoadFiles();
            }
        }

        /// <summary>
        /// Browse for a new general file
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
                    if (isSupportedFile(Path.GetExtension(dialog.FileName)))
                    {
                        MessageBox.Show("לא ניתן להציג קבצי תמונה, אך הקובץ יישמר בבסיס הנתונים", "הערה", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                        return dialog.FileName;
                    }
                    else
                    {
                        MessageBox.Show(ex.Message, "אירעה שגיאה בעת פתיחת הקובץ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }

                }
            }
            return null;

        }

        /// <summary>
        /// Check if extension of file is of image type
        /// </summary>
        /// <param name="getExtension"></param>
        /// <returns></returns>
        private bool isSupportedFile(string extension)
        {
            if (extension.Equals(".jpg") || extension.Equals(".jpeg"))
                return true;
            else if (extension.Equals(".bmp"))
                return true;
            else if (extension.Equals(".gif"))
                return true;
            else if (extension.Equals(".png"))
                return true;
            else if (extension.Equals(".txt"))
                return true;

            else return false;

        }

        /// <summary>
        /// add chosen CV file to database
        /// </summary>
        /// <param name="fileLoc">file path</param>
        private bool AddFile(byte[] fileData, string fileName, string fileOwner)
        {
            if (SQLmethods.InsertExtraFile(id_dynamic_lb.Text, fileName, fileOwner, fileData, cmd))
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
        /// Open file currently viewed in Office Viewer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void export_bt_Click(object sender, EventArgs e)
        {
            Tools.openTempFile(currentBytes, currentName.Substring(currentName.LastIndexOf(".")));
        }

        /// <summary>
        /// When datagrid clicked, open related file to preview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void extra_files_dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = (DataTable)extra_files_dgv.DataSource;
            //save original file information to later export
            currentBytes = (byte[])dt.Rows[e.RowIndex]["FileData"];
            currentName = dt.Rows[e.RowIndex]["FileName"].ToString();

            try
            {
                using (MemoryStream stream = new MemoryStream(currentBytes))
                {
                    officeViewer1.LoadFromStream(stream);
                }
            }
            catch (Exception)
            {
                Tools.openTempFile(currentBytes, currentName.Substring(currentName.LastIndexOf(".")));
            }
        }
    }
}
