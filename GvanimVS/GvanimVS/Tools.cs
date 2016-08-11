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
                System.Windows.Forms.MessageBox.Show("number cannot be empty");
                return false;
            }
            if (text.Contains("-"))
            {
                System.Windows.Forms.MessageBox.Show("number cannot be negative");
                return false;
            }
            try
            {
                Int32.Parse(text);
            }
            catch (FormatException)
            {
                System.Windows.Forms.MessageBox.Show("{0}: Bad Format", text);
                valid = false;
            }
            catch (OverflowException)
            {
                System.Windows.Forms.MessageBox.Show("{0}: Overflow", text);
                valid = false;
            }

            return valid;
        }
        public static bool IsAlphabets(string inputString)
        {
            Regex r = new Regex("^[a-zA-Z ]+$");
            if (r.IsMatch(inputString))
                return true;
            else
                return false;
        }
    }
}
