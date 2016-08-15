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
    public partial class MitmodedCard : DBform
    {
        //private string imgLoc;
        private byte[] imgByte;
        private bool imgChanged;
        private string ID;
        public MitmodedCard(SqlConnection con):base(con)
        {
            InitializeComponent();
            Console.Write("MimodedCard-->empty c-tor--> create empty form\n");
            imgChanged = false;
        }
        public MitmodedCard(SqlConnection con, string ID):base(con)
        {
            InitializeComponent();
            this.ID = ID;
            ID_tb.Text = ID;
            imgChanged = false;
            DataTable dt = getDataTable(ID);
            initFieldsFromDT(dt);
        }
        
        private DataTable getDataTable(string ID)
        {
            DataTable dt = new DataTable();
            string cmdText = "SELECT * FROM MitmodedTb WHERE ID = " + ID;
            da.SelectCommand = new SqlCommand(cmdText, con);
            da.Fill(dt);
            return dt;
            
        }
        private void initFieldsFromDT(DataTable dt)
        {
            foreach (DataRow dr in dt.Rows)
            {
                firstName_tb.Text = dr["firstName"].ToString();
                lastName_tb.Text =  dr["lastName"].ToString();
                dateTimePicker1.Value = (DateTime)dr["birthday"];
                city_tb.Text = dr["city"].ToString();
                address_tb.Text = dr["streetAddress"].ToString();
                phone1_tb.Text = dr["phone1"].ToString();
                phone2_tb.Text = dr["phone2"].ToString();
                if (dr["photo"] != null)
                {
                    byte[] bytes = (byte[])dr["photo"];
                    var ms = new System.IO.MemoryStream(bytes);
                    profile_pb.Image = Image.FromStream(ms);
                }
                else
                    profile_pb.Image = Properties.Resources.anonymous_profile;

            }
        }

        private void ok_bt_Click(object sender, EventArgs e)
        {
            
            if (verifyFields())
            {   /*
                cmd.CommandText = SQLmethods.upsertMitmoded(
                    firstName_tb.Text, lastName_tb.Text, dateTimePicker1.Value.Date,
                    ID_tb.Text, city_tb.Text, address_tb.Text,
                    phone1_tb.Text, phone2_tb.Text, imgByte);
                */
                /*
                cmd = new SqlCommand("insert into MitmodedTb" +
                " (ID, firstName ,lastName, birthDay, city, streetAddress, phone1, phone2, photo ) " +
                " values(@pID, @pFirst, @pLast, @pBirthday, @pCity, @pAddress, @pPhone1,@pPhone2, @pPhoto)", con);
                */
                cmd = new SqlCommand(
                    " IF NOT EXISTS (SELECT * FROM " + SQLmethods.MITMODED + " WHERE ID = @pID) "
                    + "INSERT INTO " + SQLmethods.MITMODED + " (ID, firstName,lastName,birthday,city, "
                    + "streetAddress,phone1,phone2, photo) "
                    + "VALUES (@pID, @pFirst, @pLast, @pBirthday, @pCity, "
                    + "@pAddress, @pPhone1, @pPhone2, @pPhoto) "
                    + "ELSE "
                    + "UPDATE " + SQLmethods.MITMODED
                    + " SET firstName = @pFirst, lastName = @pLast, birthday = @pBirthday, city = @pCity, "
                    + "streetAddress = @pAddress, phone1 = @pPhone1, phone2 = @pPhone2, photo = @pPhoto"
                    + " WHERE ID = @pID",con);
                    
                cmd.Parameters.AddWithValue("@pID", ID_tb.Text);
                cmd.Parameters.AddWithValue("@pFirst", firstName_tb.Text);
                cmd.Parameters.AddWithValue("@pLast", lastName_tb.Text);
                cmd.Parameters.Add("@pBirthday", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                cmd.Parameters.AddWithValue("@pCity", city_tb.Text);
                cmd.Parameters.AddWithValue("@pAddress", address_tb.Text);
                cmd.Parameters.AddWithValue("@pPhone1", phone1_tb.Text);
                cmd.Parameters.AddWithValue("@pPhone2", phone2_tb.Text);


                if (profile_pb.ImageLocation != null)
                    imgByte = GetPhoto(profile_pb.ImageLocation);   
                else //null because no new image was selected
                    imgByte = imageToByteArray(profile_pb.Image);
                cmd.Parameters.Add("@pPhoto", SqlDbType.Image, imgByte.Length).Value = imgByte;
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                this.Close();
            }
        }

        private void cancel_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void profile_pb_Click(object sender, EventArgs e)
        {
            var FD = new System.Windows.Forms.OpenFileDialog();
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //string fileToOpen = FD.FileName.ToString();
                //imgLoc = fileToOpen;
                //profile_pb.ImageLocation = imgLoc;
                profile_pb.ImageLocation = FD.FileName.ToString();
                imgByte = GetPhoto(profile_pb.ImageLocation);
                imgChanged = true;
            }
        }
        private bool verifyFields()
        {

            if (firstName_tb.Text.Equals(""))
            {
                MessageBox.Show("נא הכנס שם פרטי");
                return false;
            }
            else if (!Tools.IsAlphabets(firstName_tb.Text.ToString())) {
                MessageBox.Show("שם פרטי יכול להכיל אותיות בלבד");
                return false;
            }

            if (lastName_tb.Text.Equals(""))
            {
                MessageBox.Show("נא הכנס שם משפחה");
                return false;
            }
            else if (!Tools.IsAlphabets(lastName_tb.Text.ToString()))
            {
                MessageBox.Show("שם משפחה יכול להכיל אותיות בלבד");
                return false;
            }
            if (!dateTimePicker1.Checked)
            {
                MessageBox.Show("נא לבחור תאריך לידה");
                return false;
            }

            if (ID_tb.Text.Equals(""))
            {
                MessageBox.Show("נא הכנס תעודת זהות");
                return false;
            }
            else if (!Tools.valid_number(ID_tb.Text.ToString()))
            {
                MessageBox.Show("על תעודת הזהות להכיל ספרות בלבד");
                return false;
            }
            else if (ID_tb.Text.ToString().Length != 9)
            {
                MessageBox.Show("על תעודת הזהות להכיל 9 ספרות בדיוק");
                return false;
            }

            if (city_tb.Text.Equals(""))
            {
                MessageBox.Show("נא הכנס עיר מגורים");
                return false;
            }
            else if (!Tools.IsAlphabets(city_tb.Text.ToString()))
            {
                MessageBox.Show("עיר המגורים יכולה להכיל אותיות בלבד");
                return false;
            }

            if (address_tb.Text.Equals(""))
            {
                MessageBox.Show("נא הכנס כתובת");
                return false;
            }
            if (phone1_tb.Text.Equals(""))
            {
                MessageBox.Show("נא הכנס טלפון");
                return false;
            }
            else if (!Tools.valid_number(phone1_tb.Text.ToString()))
            {
                MessageBox.Show("נא הכנס מספר טלפון תקני");
                return false;
            }
            if (!phone2_tb.Text.Equals(""))
            {
                if (!Tools.valid_number(phone2_tb.Text.ToString()))
                {
                    MessageBox.Show("נא הכנס מספר טלפון תקני");
                    return false;
                }
            }
            if (!imgChanged)
            {
                DialogResult dialogResult = MessageBox.Show("לא נבחרה תמונה. האם ברצונך להמשיך?", "אישור בחירת תמונה", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //continue
                }
                else if (dialogResult == DialogResult.No)
                {
                    return false;
                }
            }
            
            return true;
        }

        private byte[] GetPhoto(string imgLoc)
        {
            FileStream stream = new FileStream(
                imgLoc, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);

            byte[] photo = reader.ReadBytes((int)stream.Length);

            reader.Close();
            stream.Close();

            return photo;
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void MitmodedCard_Load(object sender, EventArgs e)
        {

        }
    }
}
