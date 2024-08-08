using System;
using System.Globalization;

namespace Extensions;

public static class DateExtensions
{
    public static bool IsWeekend(this DateTime dateTime) 
        => dateTime.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday;

    public static DateOnly ToFirstDayOfMonth(this DateOnly dateOnly)
        => new(dateOnly.Year, dateOnly.Month, 1);

    public static DateTime ToFirstDayOfMonth(this DateTime dateTime) 
        => dateTime.AddDays(-dateTime.Day + 1);

    public static DateTimeOffset ToFirstDayOfMonth(this DateTimeOffset dateTimeOffset) 
        => dateTimeOffset.AddDays(-dateTimeOffset.Day + 1);

    public static DateOnly ToLastDayOfMonth(this DateOnly date) 
        => new(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));

    public static DateTime ToLastDayOfMonth(this DateTime date) 
        => date.AddDays(DateTime.DaysInMonth(date.Year, date.Month) - date.Day);

    public static DateTimeOffset ToLastDayOfMonth(this DateTimeOffset date) 
        => date.AddDays(DateTime.DaysInMonth(date.Year, date.Month) - date.Day);

    public static int GetIso8601WeekNumber(this DateTime date) 
        => CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
}
