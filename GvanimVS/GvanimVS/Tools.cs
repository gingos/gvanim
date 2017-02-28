using System;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace GvanimVS
{
    static class Tools
    {
        public static bool valid_number(string input)
        {
            bool valid = true;
            if (input.Equals(""))
            {
                System.Windows.Forms.MessageBox.Show("השדה איננו יכול להיות ריק");
                return false;
            }
            if (input.Contains("-"))
            {
                System.Windows.Forms.MessageBox.Show("המספר איננו יכול להיות שלילי");
                return false;
            }
            try
            {
                Int32.Parse(input);
            }
            catch (FormatException)
            {
                System.Windows.Forms.MessageBox.Show("{0}: שגיאת פורמט", input);
                valid = false;
            }
            catch (OverflowException)
            {
                System.Windows.Forms.MessageBox.Show("{0}: המספר ארוך מדי", input);
                valid = false;
            }

            return valid;
        }
        public static bool IsAlphabets(string input)
        {
            //Regex r = new Regex("^[a-zA-Z ]+$");
            Regex r = new Regex("^[a-zA-Zא-ת ]+$");

            if (r.IsMatch(input))
                return true;
            else
                return false;
        }
        public static bool IsValidEmail(string input)
        {
            // Return true if input is in valid e-mail format.
            return Regex.IsMatch(input, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }
        public static string getID(string input)
        {
            return Regex.Match(input, @"\d+").Value;
        }
        public static DataTable GetContentAsDataTable(DataGridView dgv, bool IgnoreHideColumns = false)
        {
            try
            {
                if (dgv.ColumnCount == 0) return null;
                DataTable dtSource = new DataTable();
                dtSource.TableName = dgv.Name;
                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    if (IgnoreHideColumns & !col.Visible) continue;
                    if (col.Name == string.Empty) continue;
                    //dtSource.Columns.Add(col.Name, col.ValueType);
                    dtSource.Columns.Add(col.Name);
                    dtSource.Columns[col.Name].Caption = col.HeaderText;
                }
                if (dtSource.Columns.Count == 0) return null;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    //if (row.Index == dgv.Rows.Count-1)  //skip last row, added by default
                    if (isEmptyRow(row))
                        continue;
                    DataRow drNewRow = dtSource.NewRow();
                    foreach (DataColumn col in dtSource.Columns)
                    {
                        drNewRow[col.ColumnName] = row.Cells[col.ColumnName].Value;
                    }
                    dtSource.Rows.Add(drNewRow);
                }
                return dtSource;
            }
            catch (Exception ex)
            {
                ex.ToString();
                return null;
            }
        }

        private static bool isEmptyRow(DataGridViewRow row)
        {
            foreach (DataGridViewCell cell in row.Cells)
            {
                if (cell.Value != null)
                    return false;
            }
            return true;
        }

        public static void initDataGridFromXML(string XMLfromSQL, DataGridView dgv)
        {
            if (!XMLfromSQL.Equals(""))
                XmlToDataGrid(XMLfromSQL, dgv);
        }
        private static void XmlToDataGrid(string XMLstring, DataGridView dgv)
        {
            /*
             * gets string that represents XML table, and empty datagrid 
             * fills the datagrid with the table represented by the table
             */
            DataTable dt2 = DeserializeXML<DataTable>(XMLstring);
            foreach (DataGridViewColumn col in dgv.Columns)
            {

                col.DataPropertyName = dt2.Columns[col.Name].ColumnName;
                col.HeaderText = dt2.Columns[col.Name].Caption;
            }
            dgv.DataSource = dt2;
        } 
              
        public static T DeserializeXML<T>(this string toDeserialize)
        {
            /*
             * gets string, returns it in <T> format  
             */
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            StringReader textReader = new StringReader(toDeserialize);
            return (T)xmlSerializer.Deserialize(textReader);
        }

        public static string SerializeXML<T>(this T toSerialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            StringWriter textWriter = new StringWriter();
            xmlSerializer.Serialize(textWriter, toSerialize);
            return textWriter.ToString();
        }


    }
}
