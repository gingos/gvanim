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

namespace GvanimVS
{
    public partial class Unusual_event : DBform
    {
        private SqlConnection con;
        private string mitmodedID;

        public Unusual_event()
        {
            InitializeComponent();
        }

        public Unusual_event(SqlConnection con, string text):base(con)
        {
            this.con = con;
            this.mitmodedID = text;
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label6.Show();
            textBox3.Show();
            label7.Show();
            radioButton2.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label8.Show();
            radioButton3.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            tableLayoutPanel1.Show();

            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Controls.Add(new Label() { Text = "שם" }, 1, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "טלפון" }, 2, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "פרטים נוספים" }, 3, 0);

            // For Add New Row (Loop this code for add multiple rows)
            for (int i=0; i < numericUpDown1.Value; i++)
            {
                tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 1;
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                tableLayoutPanel1.Controls.Add(new Label() { Text = "Street, City, State" }, 1, tableLayoutPanel1.RowCount - 1);
                tableLayoutPanel1.Controls.Add(new Label() { Text = "888888888888" }, 2, tableLayoutPanel1.RowCount - 1);
                tableLayoutPanel1.Controls.Add(new Label() { Text = "xxxxxxx@gmail.com" }, 3, tableLayoutPanel1.RowCount - 1);
            }     
        }
    }
}
