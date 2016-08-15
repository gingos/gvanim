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
    public partial class Coordinator : DBform
    {
        public Coordinator(SqlConnection con):base(con)
        {
            InitializeComponent();
        }

        private void writeReport_bt_Click(object sender, EventArgs e)
        {
            Report r = new Report();
            r.Activate();
        }

        private void Coordinator_Load(object sender, EventArgs e)
        {

        }

        private void editReport_bt_Click(object sender, EventArgs e)
        {
            FindReport fr = new FindReport();
            fr.Activate();
        }

        private void addMeeting_bt_Click(object sender, EventArgs e)
        {
            AddMeeting am = new AddMeeting();
            am.Activate();
        }

        private void editMeeting_bt_Click(object sender, EventArgs e)
        {
            FindMeeting fm = new FindMeeting();
            fm.Activate();
        }
    }
}
