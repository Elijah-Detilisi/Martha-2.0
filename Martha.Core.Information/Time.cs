namespace Martha.Core.Information
{
    public static class Time
    {
        public static string DayOfWeek()
        {
            return DateTime.Today.DayOfWeek.ToString();
        }
        public static TimeOnly CurrentTime()
        {
            return TimeOnly.FromDateTime(DateTime.Now);
        }
        public static DateOnly CurrentDate()
        {
            return DateOnly.FromDateTime(DateTime.Now);
        }
        public static string TimeOfDayText()
        {
            TimeSpan time = DateTime.Now.TimeOfDay;

            return (
                time < TimeSpan.FromHours(12) ? "morning" :
                time < TimeSpan.FromHours(18) ? "afternoon" :
                "evening"
            );
        }
    }
}
