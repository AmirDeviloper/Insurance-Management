using System;
using System.Globalization;
using System.Windows.Forms;

namespace Bus_Insurance_Library.Logics
{
    public static class DateLogics
    {
        public static string ExpierDate(string entryDate)
        {
            DateTime endDate = new DateTime();
            try
            {
                endDate = (DateTime.ParseExact(entryDate, "yyyy/MM/dd", CultureInfo.InvariantCulture));
            }
            catch (Exception)
            {

            }
            endDate = endDate.AddMonths(11);

            return endDate.ToString("yyyy/MM/dd");
        }
        public static double DaysBettwenDate( string expierDate)
        {
         
            double a = (DateTime.Parse(expierDate) -DateTime.Parse(CurrentPersianDate())).TotalDays; 
            return (DateTime.Parse(expierDate) - DateTime.Parse(CurrentPersianDate())).TotalDays;
        }
        private static string CurrentPersianDate()
        {
            DateTime d = DateTime.Now;
            PersianCalendar pc = new PersianCalendar();
            if (pc.GetDayOfMonth(d) < 31)
                return string.Format("{0}/{1}/{2}", pc.GetYear(d), pc.GetMonth(d), pc.GetDayOfMonth(d));
            else
                return string.Format("{0}/{1}/{2}", pc.GetYear(d), pc.GetMonth(d), 30);

        }
    }
}
