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
    public partial class PsychiatricCheckUp : DBform
    {
        byte[] data;
        string fileLoc;

        public PsychiatricCheckUp()
        {
            InitializeComponent();
        }

        public PsychiatricCheckUp(SqlConnection con, string text) : base(con)
        {
            InitializeComponent();
            this.Text = text;
            data = null;
            fileLoc = null;
            label4.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //open a PDF document
            fileLoc = BrowsePDF();  
        }

        private string BrowsePDF()
        {

            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "PDF file|*.pdf|All files (*.*)|*.*";
            f.Title = "Select a PDF file";
            f.Multiselect = false;
            f.InitialDirectory = System.IO.Path.GetFullPath(@"..\..\..\..\..\..\Data");
            DialogResult result = f.ShowDialog();
            if (result == DialogResult.OK)
            try
            {
                string res = f.FileName;
                return res;
            }
            catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "אירעה שגיאה בעת פתיחת הקובץ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "";
                }
            return "";
        }

       

        private void saveCheckUp_btn_Click(object sender, EventArgs e)
        {
            if (addPDF(fileLoc) == true)
            {
                Close();
            }
            else
            {
                MessageBox.Show("אירעה שגיאה בעת שמירת הנתונים בשרת");
            }
        }

        /// <summary>
        /// add chosen PDF file to database
        /// </summary>
        /// <param name="fileLoc">file path</param>
        private bool addPDF(string fileLoc)
        {
            //Use Tools.GetBytes here; It has extra paramater - FileShare.ReadWrite, might have future effects
            using (var stream = new FileStream(fileLoc, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(stream))
                {
                    data = reader.ReadBytes((int)stream.Length);
                }
            }
            if (SQLmethods.insertPSY(data, this.Text, doctorName_tb.Text, discription_tb.Text, visitDate_dtp.Text, cmd) == true)
            {
                label4.Show();
                return true;
            }
            else
            {
                label4.Text = "אירעה שגיאה בהעלאת הקובץ";
                label4.Show();
                return false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
