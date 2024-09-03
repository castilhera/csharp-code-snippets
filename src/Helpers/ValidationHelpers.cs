using System.Text.RegularExpressions;

namespace Helpers
{
    public static partial class ValidationHelpers
    {
        [GeneratedRegex(@"^\d{2}\.?\d{3}\.?\d{3}/?\d{4}-?\d{2}$")]
        private static partial Regex CnpjRegex();

        [GeneratedRegex(@"^\d{3}\.?\d{3}\.?\d{3}-?\d{2}$")]
        private static partial Regex CpfRegex();

        private static int GetCnpjVerificationDigit(ReadOnlySpan<char> str)
        {
            var length = str.Length;
            int offset = (int)Math.Floor(length / 2.0) - 1;
            var digit = 0;

            for (var i = 0; i < length; i++)
                digit += (str[i] - '0') * (offset + (i < offset ? 1 - i : 9 - i));

            digit %= 11;

            return digit < 2 ? 0 : 11 - digit;
        }

        private static int GetCpfVerificationDigit(ReadOnlySpan<char> str)
        {
            var length = str.Length;
            var digit = 0;

            for (var i = 0; i < length; i++)
                digit += (str[i] - '0') * (length + 1 - i);

            digit %= 11;

            return digit < 2 ? 0 : 11 - digit;
        }

        public static bool IsValidCnpj(string str)
        {
            str = str.Trim();
            if (!CnpjRegex().IsMatch(str))
                return false;

            var digits = str.Replace(".", string.Empty)
                            .Replace("/", string.Empty)
                            .Replace("-", string.Empty)
                            .AsSpan();

            var digit = GetCnpjVerificationDigit(digits[..12]);

            if (digit != (digits[12] - '0'))
                return false;

            digit = GetCnpjVerificationDigit(digits[..13]);

            return digit == (digits[13] - '0');
        }

        public static bool IsValidCpf(string str)
        {
            str = str.Trim();

            if (!CpfRegex().IsMatch(str))
                return false;

            var digits = str.Replace(".", string.Empty)
                            .Replace("-", string.Empty)
                            .AsSpan();

            var digit = GetCpfVerificationDigit(digits[..9]);

            if (digit != (digits[9] - '0'))
                return false;

            digit = GetCpfVerificationDigit(digits[..10]);

            return digit == (digits[10] - '0');
        }
    }
}
