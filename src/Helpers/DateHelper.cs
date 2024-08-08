using System;

namespace Helpers
{
    public static class DateHelpers
    {
        /// <summary>
        /// Convert DateTime.Today to DateOnly
        /// </summary>
        /// <returns>DateTime.Today as DateOnly</returns>
        public static DateOnly Today()
            => DateOnly.FromDateTime(DateTime.Today);
    }
}
