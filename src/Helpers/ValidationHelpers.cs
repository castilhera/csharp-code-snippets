using System.Text.RegularExpressions;

namespace Helpers
{
    public static partial class ValidationHelpers
    {
        [GeneratedRegex(@"\d{2}\.?\d{3}\.?\d{3}/?\d{4}-?\d{2}")]
        private static partial Regex CnpjRegex();

        [GeneratedRegex(@"\d{3}\.?\d{3}\.?\d{3}-?\d{2}")]
        private static partial Regex CpfRegex();

        public static bool IsValidCnpj(string text)
            => CnpjRegex().IsMatch(text.Trim());

        public static bool IsValidCpf(string text)
            => CpfRegex().IsMatch(text.Trim());
    }
}
