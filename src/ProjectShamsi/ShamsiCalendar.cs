using System;
using System.Globalization;

namespace ProjectShamsi
{
    public static class ShamsiCalendar
    {
        public static string GetMonthName(int month)
        {
            string[] months = {
                "فروردین","اردیبهشت","خرداد","تیر","مرداد","شهریور",
                "مهر","آبان","آذر","دی","بهمن","اسفند"
            };
            return months[month-1];
        }

        public static string GetQuarterName(int month)
        {
            if (month >= 1 && month <= 3) return "بهار";
            if (month >= 4 && month <= 6) return "تابستان";
            if (month >= 7 && month <= 9) return "پاییز";
            return "زمستان";
        }

        public static string GetSemester(int month)
        {
            return (month <= 6) ? "نیمسال اول" : "نیمسال دوم";
        }
    }
}
