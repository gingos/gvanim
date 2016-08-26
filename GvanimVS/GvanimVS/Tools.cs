using System;

using System.Text.RegularExpressions;


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
    }
}
