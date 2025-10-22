using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Bus_Insurance_Library.Logics
{
    public static class InputValidation
    {
        public static bool InputHasValue(string input)
        {
            if (string.IsNullOrEmpty(input) ||
                string.IsNullOrWhiteSpace(input))
            {
                return false;

            }
            else
            {
                return true;
            }
        }
        private static int GetMonth(MaterialSkin.Controls.MaterialSingleLineTextField inputDate)
        {
            string result = inputDate.Text.Substring(inputDate.Text.IndexOf("/") + 1);
            result = result.Remove(result.IndexOf("/"));

            if (result.Length.Equals(1))
                inputDate.Text = inputDate.Text.Insert(inputDate.Text.IndexOf("/") + 1, "0");

            try
            {
                return int.Parse(result);
            }
            catch (Exception)
            {
                return - 1;
            }
        }

        public static bool DateValidation(MaterialSkin.Controls.MaterialSingleLineTextField inputDate)
        {
            if (InputValidation.InputHasValue(inputDate.Text) &&
                inputDate.Text.Length >= 8)
            {
                DateTime startDate = new DateTime();
  
                int inputMonth = GetMonth(inputDate);
                if ((DateTime.TryParseExact(inputDate.Text.Trim(), "yyyy/mm/dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out startDate)) &&
                    ((inputMonth) < 13 && (inputMonth) > 0))
                    if (startDate.Day < 31)
                        return true;
                    else return false;
                else
                    return false;
            }
            else
            {
                return false;
            }
        
        }

        public static bool PreventInjection(MaterialSkin.Controls.MaterialSingleLineTextField input)
        {
            Regex persian = new Regex(@"^[\u0600-\u06FF\s\0-9\\]+$");
            Regex eng = new Regex(@"^^[A-Za-z]+$");

            if (persian.IsMatch(input.Text) && !eng.IsMatch(input.Text))
                return true;

            else
            {
                input.Clear();
                return false;
            }
        }
    }
}
