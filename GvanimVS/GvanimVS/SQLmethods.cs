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
        public static string USERS = "UsersTB";
        public static string RECORDS = "EmploymentRecordTB";


        public static bool upsertMitmoded(string first, string last, DateTime date, string ID, string city, string address, string phone1, string phone2, byte[] photo, SqlCommand cmd)
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
        public static bool upsertReport (string reportID, string mitmodedID, DateTime date, string report, string actions, SqlCommand cmd)
        {
            cmd.CommandText =
            #region sqlQuery
            " IF NOT EXISTS (SELECT * FROM " + REPORTS + " WHERE Id = @pReportID) "
           + "INSERT INTO " + REPORTS + " (Id, mitmodedID, Created,Report,actions) "
           + "VALUES (@pReportID, @pMitmodedID, @pCreated, @pReport, @pActions) "
           + "ELSE "
           + "UPDATE " + REPORTS
           + " SET Created = @pCreated, Report = @pReport, actions = @pActions "
           + " WHERE Id = @pReportID";
            #endregion
            #region addParamters
            cmd.Parameters.AddWithValue("@pReportID", reportID);
            cmd.Parameters.AddWithValue("@pMitmodedID", mitmodedID);
            cmd.Parameters.Add("@pCreated", SqlDbType.Date).Value = date;
            cmd.Parameters.AddWithValue("@pReport", report);
            cmd.Parameters.AddWithValue("@pActions", actions);
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
            cmd.Parameters.Clear();
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
        public static DataTable getDataTable(string table, string ID, SqlCommand cmd, SqlDataAdapter da)
        {
            DataTable dt = new DataTable();
            string cmdText = "";
            #region sqlQuery
            if (table.Equals(MITMODED))
                cmdText = "SELECT * FROM MitmodedTb WHERE ID =@pID";
            else if (table.Equals(USERS))
                cmdText = "SELECT * FROM UsersTB WHERE ID =@pID";
            cmd.CommandText = cmdText;
            #endregion
            #region addParamaters
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@pID", ID);
            #endregion
            #region execute
            da.SelectCommand = cmd;
            da.Fill(dt);
            #endregion
            return dt;
        }
        public static DataTable getDataTable(string table, string user, string password, SqlCommand cmd, SqlDataAdapter da)
        {
            DataTable dt = new DataTable();
            string cmdText = "";
            #region sqlQuery
            if (table.Equals(USERS))
                cmdText = "SELECT * FROM UsersTB WHERE (ID = @pID OR email = @pEmail) "
                    + "AND password = @pPassword";
            #endregion
            #region addParameters
            cmd.CommandText = cmdText;
            cmd.Parameters.Clear();
            if (Tools.valid_number(user)) //user submitted ID
            {
                cmd.Parameters.AddWithValue("@pID", user);
                cmd.Parameters.AddWithValue("@pEmail", "");
            }
            else                        //user submitted email
            {
                cmd.Parameters.AddWithValue("@pID", 0);
                cmd.Parameters.AddWithValue("@pEmail", user);
            }
            cmd.Parameters.AddWithValue("@pPassword", password);
            #endregion
            #region execute
            da.SelectCommand = cmd;
            da.Fill(dt);
            #endregion
            return dt;
        }
        public static DataTable getDataTable(string table, SqlCommand cmd, SqlDataAdapter da)
        {
            DataTable dt = new DataTable();
            string cmdText = "";
            #region sqlQuery
            cmdText = "SELECT * FROM " + table;
            #endregion
            #region addParameters
            cmd.CommandText = cmdText;
            #endregion
            #region execute
            da.SelectCommand = cmd;
            da.Fill(dt);
            #endregion
            return dt;
        }
        public static DataTable getEmploymentRecordTable(string ID, SqlCommand cmd, SqlDataAdapter da)
        {
            DataTable dt = new DataTable();
            string cmdText = "";
            #region sqlQuery
            cmdText = "SELECT employer, dateStart, dateEnd, decription, " +
                "responsibilities, achievements FROM " + RECORDS +
                "WHERE ID = @pID";
            #endregion
            #region addParameters
            cmd.CommandText = cmdText;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("pID", ID);
            #endregion
            #region execute
            da.SelectCommand = cmd;
            da.Fill(dt);
            #endregion
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
