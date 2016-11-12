using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace GvanimVS
{
    public partial class MitmodedCard : DBform
    {
        private byte[] imgByte;
        private bool imgChanged;
        private string ID;
        private DataTable dt, educationDT, empHistoryDT;
        public MemoryStream stream;

        public MitmodedCard(SqlConnection con):base(con)
        {
            InitializeComponent();
            imgChanged = false;
        }
        public MitmodedCard(SqlConnection con, string ID):base(con)
        {
            InitializeComponent();
            this.ID = ID;
            ID_tb.Text = ID;
            imgChanged = false;
            dt = SQLmethods.getDataTable(SQLmethods.MITMODED, ID, cmd, da);
            initDataTables();
            initFieldsFromDT(dt);
        }

        private void initDataTables()
        {
            education_dg.AutoGenerateColumns = false;
            educationDT.TableName = "educationDT";

            employment_dg.AutoGenerateColumns = false;
            empHistoryDT.TableName = "employmentHistoryDT";
        }

        private void initFieldsFromDT(DataTable dt)
        {
            
            foreach (DataRow dr in dt.Rows)
            {
                firstName_tb.Text = dr["firstName"].ToString();
                lastName_tb.Text =  dr["lastName"].ToString();
                birth_dtp.Value = (DateTime)dr["birthday"];
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
            {  
                //update user photo
                if (profile_pb.ImageLocation != null)
                    imgByte = GetPhoto(profile_pb.ImageLocation);
                //null because no new image was selected 
                else
                    imgByte = imageToByteArray(profile_pb.Image);

                //Serialize gridviews: grid -> data table -> serialized ->byte array
                educationDT = Tools.GetContentAsDataTable(education_dg, true);
                stream = Tools.SerializeToStream(educationDT);
                byte[] educ_binary = stream.ToArray();

                empHistoryDT = Tools.GetContentAsDataTable(employment_dg, true);
                stream = Tools.SerializeToStream(empHistoryDT);
                byte[] history_binary = stream.ToArray();

                // ADD EDUC BINARY AND HISTORY BINARY TO SQL QUERY

                //insert data into SQL server
                if (SQLmethods.upsertMitmoded(firstName_tb.Text, lastName_tb.Text, birth_dtp.Value.Date,
                   ID_tb.Text, city_tb.Text, address_tb.Text, phone1_tb.Text, phone2_tb.Text, coordinator_id_tb.Text,
                   imgByte, cmd))
                    MessageBox.Show("המידע נשמר בהצלחה");
                else
                    MessageBox.Show("אירעה שגיאה בעת שמירת הנתונים");
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
            if (!birth_dtp.Checked)
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
            if (coordinator_id_tb.Text.Equals(""))
            {
                MessageBox.Show("נא הכנס תעודת זהות");
                return false;
            }
            else if (!Tools.valid_number(coordinator_id_tb.Text.ToString()))
            {
                MessageBox.Show("על תעודת הזהות להכיל ספרות בלבד");
                return false;
            }
            else if (coordinator_id_tb.Text.ToString().Length != 9)
            {
                MessageBox.Show("על תעודת הזהות להכיל 9 ספרות בדיוק");
                return false;
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

        private void button1_Click(object sender, EventArgs e)
        {


            educationDT = Tools.GetContentAsDataTable(education_dg, true);
            stream = Tools.SerializeToStream(educationDT);

            //MemoryStream streamSer = new MemoryStream();
            //IFormatter formatter = new BinaryFormatter();
            //formatter.Serialize(streamSer, educationDT);

           
            byte[] str1 = stream.ToArray();

            //TODO:
            // Already serielized the file to memory
            // Can i send byte[] to server?
            // if not, have to serliaize to xml
            cmd.CommandText =
            #region sqlQuery

            "INSERT INTO " + SQLmethods.MITMODED + " (ID, phone1, education) "
            + "VALUES (@pID, @pPhone1, @pEducation); ";

            #endregion
            #region addParamters
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@pID", "1111");
            cmd.Parameters.AddWithValue("@pPhone1", "0523");
            cmd.Parameters.Add("@pEducation", SqlDbType.VarBinary, str1.Length).Value = str1;
            #endregion
            #region execute
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            #endregion



            //MemoryStream StreamDe = new MemoryStream(streamSer.ToArray());            
            //StreamDe.Seek(0, SeekOrigin.Begin);
            //DataTable dt2 = (DataTable)formatter.Deserialize(StreamDe);
            

            //educationDT.WriteXml(@"myfile.xml");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt2 = (DataTable)Tools.DeserializeFromStream(stream);
            
            foreach (DataGridViewColumn col in education_dg.Columns)
            {

                col.DataPropertyName = dt2.Columns[col.Name].ColumnName;
            }
            education_dg.DataSource = dt2;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //educationDT.Clear(); // does noting?
            //education_dg.Columns.Clear(); //deleted all colls and all data with them
            education_dg.Rows.Clear();
            //education_dg.DataSource = null;
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
