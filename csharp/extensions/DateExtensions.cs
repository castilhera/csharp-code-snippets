using System;
using System.Globalization;

namespace Extensions
{
    public static class DateExtensions
    {
        public static DateOnly ToFirstDayOfMonth(this DateOnly dateOnly)
        {
            return new DateOnly(dateOnly.Year, dateOnly.Month, 1);
        }

        public static DateTime ToFirstDayOfMonth(this DateTime dateTime)
        {
            return dateTime.AddDays(-dateTime.Day + 1);
        }

        public static DateTimeOffset ToFirstDayOfMonth(this DateTimeOffset dateTimeOffset)
        {
            return dateTimeOffset.AddDays(-dateTimeOffset.Day + 1);
        }

        public static DateOnly ToLastDayOfMonth(this DateOnly date)
        {
            return new DateOnly(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));
        }

        public static DateTime ToLastDayOfMonth(this DateTime date)
        {
            return date.AddDays(DateTime.DaysInMonth(date.Year, date.Month) - date.Day);
        }

        public static DateTimeOffset ToLastDayOfMonth(this DateTimeOffset date)
        {
            return date.AddDays(DateTime.DaysInMonth(date.Year, date.Month) - date.Day);
        }

        public static int GetIso8601WeekNumber(this DateTime date)
        {
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }
    }
}
