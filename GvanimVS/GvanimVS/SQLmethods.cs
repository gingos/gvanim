using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GvanimVS
{
    static class SQLmethods
    {
        public static string MITMODED = "MitmodedTb";
        public static string MEETINGS = "MeetingsTB";
        public static string REPORTS = "ReportsTB";

      
        public static bool upsertMidmoded(string first, string last, DateTime date, string ID, string city, string address, string phone1, string phone2, byte[] photo, SqlCommand cmd)
        {
           
            cmd.CommandText =
            #region sqlQuery
            " IF NOT EXISTS (SELECT * FROM " + SQLmethods.MITMODED + " WHERE ID = @pID) "
            + "INSERT INTO " + SQLmethods.MITMODED + " (ID, firstName,lastName,birthday,city, "
            + "streetAddress,phone1,phone2, photo) "
            + "VALUES (@pID, @pFirst, @pLast, @pBirthday, @pCity, "
            + "@pAddress, @pPhone1, @pPhone2, @pPhoto) "
            + "ELSE "
            + "UPDATE " + SQLmethods.MITMODED
            + " SET firstName = @pFirst, lastName = @pLast, birthday = @pBirthday, city = @pCity, "
            + "streetAddress = @pAddress, phone1 = @pPhone1, phone2 = @pPhone2, photo = @pPhoto"
            + " WHERE ID = @pID";
            #endregion
            #region addParamters
            cmd.Parameters.AddWithValue("@pID", ID);
            cmd.Parameters.AddWithValue("@pFirst", first);
            cmd.Parameters.AddWithValue("@pLast", last);
            cmd.Parameters.Add("@pBirthday", SqlDbType.Date).Value = date;
            cmd.Parameters.AddWithValue("@pCity", city);
            cmd.Parameters.AddWithValue("@pAddress", address);
            cmd.Parameters.AddWithValue("@pPhone1", phone1);
            cmd.Parameters.AddWithValue("@pPhone2", phone2);
            cmd.Parameters.Add("@pPhoto", SqlDbType.Image, photo.Length).Value = photo;
            #endregion
            #region execute
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                return false;
            }
            #endregion
            return true;
        }

        public static bool findMeeting(int ID, DateTime date, string name, SqlCommand cmd)
        {
            cmd.CommandText =
            #region sqlQuery
                   /*  "DECLARE @id int ='" + ID + "'"
                   + "DECLARE @date datetime = '" + date + "'"
                   + "DECLARE @mitmoded nvarchar(50) = '" + name + "'"
                   +*/ "SELECT FROM " + MEETINGS + "WHERE Id = @pID OR Mitmoded = @pMitmoded OR Date = @pDate";
            #endregion
            #region addParamters
            cmd.Parameters.AddWithValue("@pID", ID);
            cmd.Parameters.Add("@pDate", SqlDbType.Date).Value = date;
            cmd.Parameters.AddWithValue("@pMitmoded", name);
            #endregion
            #region execute
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                return false;
            }
            #endregion
            return true;
        }
        //in the future, perhaps add paramter: table name to look for various data
        public static DataTable getDataTable(string ID, SqlCommand cmd, SqlDataAdapter da)
        {
            DataTable dt = new DataTable();
            string cmdText = "SELECT * FROM MitmodedTb WHERE ID = " + ID;
            cmd.CommandText = cmdText;
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        //DEPRECATED
        private static string findMeeting(int id, DateTime date, string name)
        {
            return
                     "DECLARE @id int ='" + id + "'"
                   + "DECLARE @date datetime = '" + date + "'"
                   + "DECLARE @mitmoded nvarchar(50) = '" + name + "'"
                   + "SELECT FROM " + MEETINGS + "WHERE Id = @id OR mitmoded = @mitmoded OR Date = @date";
        }
        //DEPRECATED
        public static string upsertMitmoded(string first, string last, DateTime date, string ID, string city, string address, string phone1, string phone2, byte[] photo)
        {
            return
                      "DECLARE @first nvarchar(50) = '" + first + "'"
                    + "DECLARE @last nvarchar(50) = '" + last + "'"
                    + "DECLARE @ID int = " + ID + ""
                    + "DECLARE @birthday date = '" + dateConverter(date) + "'"
                    + "DECLARE @city nvarchar(50) = '" + city + "'"
                    + "DECLARE @address nvarchar(100) = '" + address + "'"
                    + "DECLARE @phone1 nvarchar(50) = '" + phone1 + "'"
                    + "DECLARE @phone2 nvarchar(50) = '" + phone2 + "' "
                    + "DECLARE @photo VARBINARY(MAX) = CONVERT (VARBINARY(MAX), '" + photo + "') "
                    + "IF NOT EXISTS (SELECT * FROM " + MITMODED + " WHERE ID = @ID) "
                    + "INSERT INTO " + MITMODED + " (ID, firstName,lastName,birthday,city, "
                    + "streetAddress,phone1,phone2, photo) "
                    + "VALUES (@ID, @first, @last, @birthday, @city, "
                    + "@address, @phone1, @phone2, @photo) "
                    + "ELSE "
                    + "UPDATE " + MITMODED
                    + " SET firstName = @first, lastName = @last, birthday = @birthday, city = @city, "
                    + "streetAddress = @address, phone1 = @phone1, phone2 = @phone2, photo = @photo"
                    + " WHERE ID = @ID";
        }
        //DEPRECATED
        private static string dateConverter(DateTime date)
        {
            return date.Date.ToString("yyyy-MM-dd");
        }
    }
}
