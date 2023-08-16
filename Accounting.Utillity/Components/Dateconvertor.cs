using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Accounting.Utillity.Components
{
   public static class Dateconvertor
    {
        public static string ToShamsi(this DateTime value)
        {
            PersianCalendar date = new PersianCalendar();

            return date.GetYear(value) +"/"+ date.GetMonth(value).ToString("00")+"/" + date.GetDayOfMonth(value).ToString("00");
        }
        public static DateTime ToMiladi(DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, new PersianCalendar());
        }
    }
}
