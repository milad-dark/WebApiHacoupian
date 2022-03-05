using System;
using System.Globalization;

namespace WebApiHacoupian
{
    public static partial class DateTimeExtensions
    {
        public static string ToShamsi(this DateTime dateTime)
        {
            PersianCalendar pc = new();
            return pc.GetYear(dateTime).ToString() + "/" + (pc.GetMonth(dateTime) < 10 ? "0" + pc.GetMonth(dateTime).ToString() : pc.GetMonth(dateTime).ToString()) + "/" + (pc.GetDayOfMonth(dateTime) < 10 ? "0" + pc.GetDayOfMonth(dateTime).ToString() : pc.GetDayOfMonth(dateTime).ToString());
        }

        public static DateTime ToGregorianDate(this string date)
        {
            try
            {
                return new PersianCalendar().ToDateTime(int.Parse(date.Substring(0, 4)), int.Parse(date.Substring(5, 2)), int.Parse(date.Substring(8, 2)), 0, 0, 0, 0);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
