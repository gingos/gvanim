using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GvanimVS
{
    public partial class Hitkashrut : Form
    {
        public Hitkashrut()
        {
            InitializeComponent();
        }

        private void close_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Hitkashrut_Load(object sender, EventArgs e)
        {
            

        }

        private void show_pdf_bt_Click(object sender, EventArgs e)
        {
            try
            {
                String openPDFFile = @"C:\Users\yoadw20\Documents\Visual Studio 2015\Projects\gvanim\resources\hitkashrut.pdf";
                System.IO.File.WriteAllBytes(openPDFFile, global::GvanimVS.Properties.Resources.hitkashrut);
                System.Diagnostics.Process.Start(openPDFFile);
            }
            catch (System.IO.IOException )
            {
                MessageBox.Show("אין אפשרות לפתוח את המסמך." + "\n" + "ייתכן והוא כבר פתוח.", "שגיאה בפתיחת המסמך", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,  MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }
        }
    }
}
