using System;

namespace Extensions
{
    public static class StringExtensions
    {
        public static string Reverse(this string input)
        {
            char[] inputAsArray = input.ToCharArray();
            Array.Reverse(inputAsArray);
            return new string(inputAsArray);
        }
    }
}
