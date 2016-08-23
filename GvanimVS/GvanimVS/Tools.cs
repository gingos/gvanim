using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GvanimVS
{
    static class Tools
    {
        public static bool valid_number(string text)
        {
            bool valid = true;
            if (text.Equals(""))
            {
                System.Windows.Forms.MessageBox.Show("השדה איננו יכול להיות ריק");
                return false;
            }
            if (text.Contains("-"))
            {
                System.Windows.Forms.MessageBox.Show("המספר איננו יכול להיות שלילי");
                return false;
            }
            try
            {
                Int32.Parse(text);
            }
            catch (FormatException)
            {
                System.Windows.Forms.MessageBox.Show("{0}: שגיאת פורמט", text);
                valid = false;
            }
            catch (OverflowException)
            {
                System.Windows.Forms.MessageBox.Show("{0}: המספר ארוך מדי", text);
                valid = false;
            }

            return valid;
        }
        public static bool IsAlphabets(string inputString)
        {
            //Regex r = new Regex("^[a-zA-Z ]+$");
            Regex r = new Regex("^[a-zA-Zא-ת ]+$");
           
            if (r.IsMatch(inputString))
                return true;
            else
                return false;
        }
        public static bool IsValidEmail(string strIn)
        {
            // Return true if strIn is in valid e-mail format.
            return Regex.IsMatch(strIn, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }
    }
}
