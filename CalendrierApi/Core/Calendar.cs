namespace CalendrierApi.Core
{
    /// <summary>
    /// Main class
    /// </summary>
    public class Calendar
    {
        /// <summary>
        /// Returns the number of days by given year and month
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public static IEnumerable<DateTime> GetDaysInMonth(int year, int month)
        {
            if (!(month <= 12 && month > 0))
            {
                throw new ArgumentOutOfRangeException(nameof(month));
            }
            List<DateTime> days = new List<DateTime>();
            for (int i = 1; i <= DateTime.DaysInMonth(year, month); i++)
            {
                days.Add(new DateTime(year, month, i));
            }
            return days;
        }


        /// <summary>
        /// Returns the number of days by given DateTime
        /// </summary>
        /// <param name="date">DateTime object</param>
        /// <returns></returns>
        public static IEnumerable<DateTime> GetDaysInMonth(DateTime date)
        {
            List<DateTime> days = new List<DateTime>();
            for (int i = 1; i <= DateTime.DaysInMonth(date.Year, date.Month); i++)
            {
                days.Add(new DateTime(date.Year, date.Month, i));
            }
            return days;
        }
    }
}