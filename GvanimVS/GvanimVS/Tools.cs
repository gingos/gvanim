using Spire.Doc;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;
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

        /// <summary>
        /// bind a dictionary to committee duration combo box, using templates
        /// </summary>
        public static BindingSource bindDictionary2<TKey, TValue>(Dictionary<TKey, TValue> dic, Control control)
        {
            //for future reference, this is how you (worst case) access the members
            //int monthsToAdd = ((KeyValuePair<string, int>)xml_rehab_validity_cb.SelectedItem).Value;
            ((ComboBox)control).DisplayMember = "Key";
            ((ComboBox)control).ValueMember = "Value";
            return new BindingSource(dic, null);
        }

        /// <summary>
        /// open the file for preview
        /// allocates temp file in \TEMP folder
        /// </summary>
        /// <param name="file"> byteArray of file to be opened</param>
        /// <param name="fileType"> file suffix, to be used by system process</param>
        public static void openTempFile(byte[] file, string fileType)
        {
            string tempPath = System.IO.Path.GetTempFileName().Replace(".tmp", fileType);
            System.IO.File.WriteAllBytes(tempPath, file);
            System.Diagnostics.Process.Start(tempPath);
        }

        /// <summary>
        /// returns '-' delimited string representation of the byte array
        /// {32,   0,   0,} --> "20-00-00"
        /// </summary>
        /// <param name="bytes"> byteArray to be converted</param>
        /// <returns></returns>
        public static string byteToStr(byte[] bytes)
        {
            return BitConverter.ToString(bytes);
        }

        /// <summary>
        /// returns the original byteArray from the representing string
        ///  "20-00-00" --> {32,   0,   0,}
        /// </summary>
        /// <param name="str"> byteArray as string</param>
        /// <returns></returns>
        public static byte[] strToByte(string str)
        {
            string[] tempAry = str.Split('-');
            byte[] decBytes2 = new byte[tempAry.Length];
            for (int i = 0; i < tempAry.Length; i++)
                decBytes2[i] = Convert.ToByte(tempAry[i], 16);
            return decBytes2;
        }

        /// <summary>
        /// Generate a temporary MitmodedCard Document
        /// template is Resources.personal_details_template.doc
        /// </summary>
        /// <param name="resourceName"> file name as specified in Resources.resx</param>
        /// <param name="resourceFormat"> file format must be ".<format>" (with preceding dot!)  </param>
        /// <param name="dictReplace"> dictionary used to replace placeholders </param>
        public static void exportDoc(string resourceName, string resourceFormat, Dictionary<string,string> dictReplace)
        {
            FileFormat format = FileFormat.Auto;
            if (resourceFormat.Equals(".doc"))
                format = FileFormat.Doc;
            else if (resourceFormat.Equals(".pdf"))
                format = FileFormat.PDF;
            //initialize word object  
            Document document = new Document();
            var assembly = Assembly.GetExecutingAssembly();
            //var resourceName = "GvanimVS.Resources.personal_details_template.doc";
            using (Stream loadStream = assembly.GetManifestResourceStream(resourceName))
                //document.LoadFromFile(samplePath);
                document.LoadFromStream(loadStream, format);
            //get strings to replace  
            //Dictionary<string, string> dictReplace = GetReplaceDictionary();
            //Replace text  
            foreach (KeyValuePair<string, string> kvp in dictReplace)
            {
                document.Replace(kvp.Key, kvp.Value, true, true);
            }
            //Save doc file.  
            //document.SaveToFile("C:\\Users\\yoadw20\\Desktop\\test1-doc.doc", FileFormat.Doc);
            //Convert to stream.
            MemoryStream ms = new MemoryStream();
            document.SaveToStream(ms, format);
            MessageBox.Show("עיבוד המסמך הסתיים" + "\n" + "שימו לב, עדיין חסרה חתימה למסמך עצמו", "עיבוד המסמך", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Tools.openTempFile(ms.ToArray(), resourceFormat);
            document.Close();
        }
    }
}
