using System;
using System.Globalization;

namespace ProjectShamsi
{
    public static class JalaliDateConverter
    {
        private static readonly PersianCalendar pc = new PersianCalendar();
        
        public static string ToJalali(DateTime date)
        {
            return $"{pc.GetYear(date)}/{pc.GetMonth(date):00}/{pc.GetDayOfMonth(date):00}";
        }
    }
}
