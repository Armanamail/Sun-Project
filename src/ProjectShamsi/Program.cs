using System;

namespace ProjectShamsi
{
    class Program
    {
        static void Main(string[] args)
        {
            var now = DateTime.Now;
            Console.WriteLine("تاریخ شمسی: " + JalaliDateConverter.ToJalali(now));
            Console.WriteLine("ماه: " + ShamsiCalendar.GetMonthName(now.Month));
            Console.WriteLine("فصل: " + ShamsiCalendar.GetQuarterName(now.Month));
            Console.WriteLine("نیمسال: " + ShamsiCalendar.GetSemester(now.Month));
        }
    }
}
