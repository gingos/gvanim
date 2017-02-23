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
    public partial class DBform : Form
    {
        protected SqlConnection con;
        protected SqlCommand cmd;
        protected SqlDataAdapter da;

        public DBform()
        {
            InitializeComponent();

        }
        public DBform(SqlConnection con)
        {
            this.con = con;
            cmd = new SqlCommand();
            cmd.Connection = con;
            da = new SqlDataAdapter();
            InitializeComponent();
        }
    }
}
