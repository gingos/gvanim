﻿using System;
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


        public static bool upsertMitmoded(string first, string last, DateTime date, string ID, string city,
            string address, string phone1, string phone2, string coordinatorID, byte[] photo,
            string educationXML, string historyXML, string serializedOrganizer, SqlCommand cmd)
        {
           
            cmd.CommandText =
            #region sqlQuery
            " IF NOT EXISTS (SELECT * FROM " + SQLmethods.MITMODED + " WHERE ID = @pID) "
            + "INSERT INTO " + SQLmethods.MITMODED + " (ID, firstName,lastName,birthday,city, "
            + "streetAddress,phone1,phone2,coordinatorID, photo, educationXML, historyXML, intec_tabs ) "
            + "VALUES (@pID, @pFirst, @pLast, @pBirthday, @pCity, @pAddress, "
            + "@pPhone1, @pPhone2, @pCoordinatorID, @pPhoto, @pEducation, @pHistory, @pIntec_tabs) "
            + "ELSE "
            + "UPDATE " + SQLmethods.MITMODED
            + " SET firstName = @pFirst, lastName = @pLast, birthday = @pBirthday, city = @pCity, "
            + "streetAddress = @pAddress, phone1 = @pPhone1, phone2 = @pPhone2, coordinatorID=@pCoordinatorID, "
            + "photo = @pPhoto, educationXML = @pEducation, historyXML = @pHistory, intec_tabs = @pIntec_tabs"
            + " WHERE ID = @pID";
            #endregion
            #region addParamters
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@pID", ID);
            cmd.Parameters.AddWithValue("@pFirst", first);
            cmd.Parameters.AddWithValue("@pLast", last);
            cmd.Parameters.Add("@pBirthday", SqlDbType.Date).Value = date;
            cmd.Parameters.AddWithValue("@pCity", city);
            cmd.Parameters.AddWithValue("@pAddress", address);
            cmd.Parameters.AddWithValue("@pPhone1", phone1);
            cmd.Parameters.AddWithValue("@pPhone2", phone2);
            cmd.Parameters.AddWithValue("@pCoordinatorID", coordinatorID);
            cmd.Parameters.Add("@pPhoto", SqlDbType.Image, photo.Length).Value = photo;
            cmd.Parameters.Add("@pEducation", SqlDbType.Xml, educationXML.Length).Value = educationXML;
            cmd.Parameters.Add("@pHistory", SqlDbType.Xml, historyXML.Length).Value = historyXML;
            cmd.Parameters.Add("@pIntec_tabs", SqlDbType.Xml, serializedOrganizer.Length).Value = serializedOrganizer;

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
        public static bool upsertReport (string reportID, string mitmodedID, string firstName, string lastName, DateTime date, string report, string actions, string coordinatorID, SqlCommand cmd)
        {
            cmd.CommandText =
            #region sqlQuery
            " IF NOT EXISTS (SELECT * FROM " + REPORTS + " WHERE Id = @pReportID) "
           + "INSERT INTO " + REPORTS + " (Id, mitmodedID, firstName, lastName, Created, Report, actions, coordinatorID) "
           + "VALUES (@pReportID, @pMitmodedID, @pFirstName, @pLastName, @pCreated, @pReport, @pActions, @pCoordinatorID) "
           + "ELSE "
           + "UPDATE " + REPORTS
           + " SET firstName = @pFirstName, lastName = @pLastName, Created = @pCreated, Report = @pReport, actions = @pActions, coordinatorID = @pCoordinatorID "
           + " WHERE Id = @pReportID";
            #endregion
            #region addParamters
            cmd.Parameters.AddWithValue("@pReportID", reportID);
            cmd.Parameters.AddWithValue("@pFirstName", firstName);
            cmd.Parameters.AddWithValue("@pLastName", lastName);
            cmd.Parameters.AddWithValue("@pMitmodedID", mitmodedID);
            cmd.Parameters.Add("@pCreated", SqlDbType.Date).Value = date;
            cmd.Parameters.AddWithValue("@pReport", report);
            cmd.Parameters.AddWithValue("@pActions", actions);
            cmd.Parameters.AddWithValue("@pCoordinatorID", coordinatorID); 
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
            //OVERLOAD: used for mimoded (and more, not login)
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
            //OVERLOAD: used for users login
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
        public static DataTable getColsFromTable(string table, string cols, SqlCommand cmd, SqlDataAdapter da)
        {
            DataTable dt = new DataTable();
            string cmdText = "";
            #region sqlQuery
            cmdText = "SELECT " + cols + " FROM " + table;
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
        public static DataTable getColsFromTable(string table, string cols, string key, string value, SqlCommand cmd, SqlDataAdapter da)
        {
            DataTable dt = new DataTable();
            string cmdText = "";
            #region sqlQuery
            cmdText = "SELECT " + cols + " FROM " + table
                + " WHERE " + key + " = @pValue";
            #endregion
            #region addParameters
            cmd.CommandText = cmdText;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@pValue", value);
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
            cmdText = "SELECT employer, dateStart, dateEnd, description, " +
                "responsibilities, achievements FROM " + RECORDS +
                " WHERE ID = @pID";
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
        public static DataTable searchUsersInTable(string table, string ID, string firstName, string lastName, string city, SqlCommand cmd, SqlDataAdapter da)
        {
            DataTable dt = new DataTable();
            #region sqlQuery
            if (ID.Equals(""))
            {
                cmd.CommandText = "SELECT ID, firstName, lastName, city, phone1 FROM " + table
                    + " WHERE ((firstName LIKE '%' + @pFirstName + '%' AND lastName LIKE '%' + @pLastName + '%') "
                    + " AND city LIKE '%' + @pCity + '%');";
            }
            else
                cmd.CommandText = "SELECT ID, firstName, lastName, city, phone1 FROM " + table
                    + " WHERE ID = @pID;";
            #endregion
            #region addParamters
            cmd.Parameters.Clear();
            if (ID.Equals(""))
            {
                cmd.Parameters.AddWithValue("@pFirstName", firstName);
                cmd.Parameters.AddWithValue("@pLastName", lastName);
                cmd.Parameters.AddWithValue("@pCity", city);
            }
            else
                cmd.Parameters.AddWithValue("@pID", ID);
            #endregion
            #region execute
            da.SelectCommand = cmd;
            da.Fill(dt);
            #endregion
            return dt;
        }
        public static DataTable findReport(string id, string mitmodedID, DateTime date, SqlCommand cmd, SqlDataAdapter da)
        {
            DataTable dt = new DataTable();

            cmd.CommandText = "SELECT * FROM " + REPORTS + "WHERE Id = @pID AND MitmodedID = @pMitmoded AND Created = @pDate";

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@pID", id);
            cmd.Parameters.Add("@pDate", SqlDbType.Date).Value = date;
            cmd.Parameters.AddWithValue("@pMitmoded", mitmodedID);

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
        /*
        if we don't want to edit reports.coordinatorID
        SELECT ReportsTB.Id, ReportsTB.mitmodedID, ReportsTB.firstName, ReportsTB.lastName
        FROM 
        ReportsTB JOIN MitmodedTb
        ON ReportsTB.mitmodedID=MitmodedTb.ID
        where ReportsTB.mitmodedID = '222222222'
        AND MitmodedTb.coordinatorID = '379184302';
        */
        
        /// <summary>
        /// update table in database using table name, column, row, key and data to insert
        /// </summary>
        /// <param name="table"></param>
        /// <param name="column"></param>
        /// <param name="row"></param>
        /// <param name="key"></param>
        /// <param name="XMLinfo"></param>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public static bool updateXMLFormInDB(string table, string column, string row, string key, string XMLinfo, SqlCommand cmd)
        {
           cmd.CommandText =
            #region sqlQuery
           "UPDATE " + table
           + " SET "+column+" = "+XMLinfo
           + " WHERE "+row+" = "+key;
            #endregion
            #region addParameters
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
    }
}
