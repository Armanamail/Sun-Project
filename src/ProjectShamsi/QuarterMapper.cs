namespace ProjectShamsi
{
    public static class QuarterMapper
    {
        public static string MapQuarter(int month)
        {
            return ShamsiCalendar.GetQuarterName(month);
        }
    }
}
