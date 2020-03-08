using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Utility.Convertors
{
 public static  class Convertors
    {
        public static string ShowMoney(this int value)
        {
            return value.ToString("#,0");
        }

        public static string ShowMoney(this string value)
        {
            return int.Parse(value).ToString("#,0");
        }

        public static string ToShamsi(this DateTime value)
        {
            var pc = new PersianCalendar();
            return pc.GetYear(value) + "/" + pc.GetMonth(value).ToString("00") + "/"
                                     + pc.GetDayOfMonth(value).ToString("00");
        }

        public static DateTime ToMiladi(this DateTime value)
        {
            return new DateTime(value.Year, value.Month, value.Day, new System.Globalization.PersianCalendar());
        }
    }
}
