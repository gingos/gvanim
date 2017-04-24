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

namespace GvanimVS                //TODO: add a special table to DB including details and upload pdf function
{
    public partial class PsychiatricCheckUp : DBform
    {
        public PsychiatricCheckUp()
        {
            InitializeComponent();
        }

        public PsychiatricCheckUp(SqlConnection con, string text) : base(con)
        {
            InitializeComponent();
            this.Text = text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(f.FileName);
                MessageBox.Show(sr.ReadToEnd());
                sr.Close();
            }

        }
    }
    
}
