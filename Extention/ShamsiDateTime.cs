using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiHacoupian
{
    public static partial class DateTimeExtensions
    {
        public static string ToShamsi(this DateTime dateTime)
        {
            PersianCalendar pc = new();
            return pc.GetYear(dateTime).ToString() + "/" + (pc.GetMonth(dateTime) < 10 ? "0" + pc.GetMonth(dateTime).ToString() : pc.GetMonth(dateTime).ToString()) + "/" + (pc.GetDayOfMonth(dateTime) < 10 ? "0" + pc.GetDayOfMonth(dateTime).ToString() : pc.GetDayOfMonth(dateTime).ToString());
        }
    }
}
