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
    public partial class RegionManager : DBform
    {
        public RegionManager():base()
        {
            InitializeComponent();
        }
        public RegionManager(SqlConnection con) : base(con)
        {
            InitializeComponent();
        }

        private void addMitmoded_bt_Click(object sender, EventArgs e)
        {
            using (var mitCard = new MitmodedCard())
            {
                mitCard.ShowDialog();
            }
        }

        private void ok_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
