﻿using System;
using System.Data;
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
        public static System.IO.MemoryStream SerializeToStream(object o)
        {
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            System.Runtime.Serialization.IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            formatter.Serialize(stream, o);
            return stream;
        }
        public static object DeserializeFromStream(System.IO.MemoryStream stream)
        {
            System.Runtime.Serialization.IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            stream.Seek(0, System.IO.SeekOrigin.Begin);
            object o = formatter.Deserialize(stream);
            return o;
        }
        public static string SerializeToXML(object item)
        {
            if (item == null)
                return null;

            var stringBuilder = new System.Text.StringBuilder();
            var itemType = item.GetType();

            new XmlSerializer
                (itemType).Serialize(new System.IO.StringWriter(stringBuilder), item);

            return stringBuilder.ToString();

        }

        
    }
}
