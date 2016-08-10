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
    public partial class MitmodedCard : Form
    {
        public MitmodedCard()
        {
            InitializeComponent();
            Console.Write("MimodedCard-->empty c-tor--> create empty form");            
        }
        public MitmodedCard(string ID)
        {
            InitializeComponent();
            Console.Write("MimodedCard-->got ID--> pull data from DB by ID");
            /*DataTable dt =*/  getDataTable(ID);
            initFieldsFromDT(/*dt*/);
        }
        
        private void getDataTable(string iD)
        {
            throw new NotImplementedException();
        }
        private void initFieldsFromDT(/*DataTable dt*/)
        {
            throw new NotImplementedException();
        }

        private void ok_bt_Click(object sender, EventArgs e)
        {
            Console.Write("MimodedCard-->ok button--> Saving to database...");
            this.Close();
        }

        private void cancel_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
