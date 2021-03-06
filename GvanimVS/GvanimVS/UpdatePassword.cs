﻿using System;
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
    public partial class UpdatePassword : DBform
    {
        
        private string coordinatorID;

        public UpdatePassword()
        {
            InitializeComponent();
        }

        public UpdatePassword(SqlConnection con, string coordinatorID)
        {
            this.con = con;
            this.coordinatorID = coordinatorID;
            InitializeComponent();
        }

        private void cancel_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok_bt_Click(object sender, EventArgs e)
        {
            if (!verifyFields())
            {
                label3.Show();
            }
            else
            {
                //TODO: send new password to database
            }
        }

        private bool verifyFields()
        {
            throw new NotImplementedException("not implemented yet");
        }

        private void ok_bt_MouseHover(object sender, EventArgs e)
        {
            ok_bt.BackColor = Color.RoyalBlue;
        }

        private void ok_bt_MouseLeave(object sender, EventArgs e)
        {
            ok_bt.BackColor = Color.CornflowerBlue;
        }

        private void cancel_bt_MouseHover(object sender, EventArgs e)
        {
            cancel_bt.BackColor = Color.RoyalBlue;
        }

        private void cancel_bt_MouseLeave(object sender, EventArgs e)
        {
            cancel_bt.BackColor = Color.CornflowerBlue;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }
    }
}
