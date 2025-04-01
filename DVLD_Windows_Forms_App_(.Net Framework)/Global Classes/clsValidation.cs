using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Driving_License_Management
{
    internal class clsValidation
    {
        static public bool IsValideEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return Regex.IsMatch(email, pattern);
        }
        static public bool IsDigitOrControl(char c)
        {
            
            return char.IsDigit(c) || char.IsControl(c);
        }
     

        public static bool IsInteger(string Number)
        {
            var pattern = @"^[0-9]*$";

            var regex = new Regex(pattern);

            return regex.IsMatch(Number);
        }

        public static bool IsFloat(string Number)
        {
            var pattern = @"^[0-9]*(?:\.[0-9]*)?$";

            var regex = new Regex(pattern);

            return regex.IsMatch(Number);
        }

        public static bool IsNumber(string Number)
        {
            return (IsInteger(Number) || IsFloat(Number));
        }
        public static bool IsCurrency(string input) 
        {
            if (decimal.TryParse(input, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal value))
            {
                // Valid money amount
                return true;
            }
            else
            {
                // Invalid money amount
                return false;
            }
            //return Regex.IsMatch(input, @"^\d+(\.\d{1,2})?$"); // Supports up to 2 decimal places
        }
    }
}
