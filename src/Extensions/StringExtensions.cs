using System.Text;

namespace Extensions;

public static class StringExtensions
{
    public static string Reverse(this string? input)
    {
        if (string.IsNullOrEmpty(input))
            return string.Empty;

        char[] inputAsArray = input.ToCharArray();
        Array.Reverse(inputAsArray);
        return new string(inputAsArray);
    }

    public static string ToSnakeCase(this string? input, bool screaming = false)
    {
        if (string.IsNullOrEmpty(input))
            return string.Empty;

        var stringBuilder = new StringBuilder();

        char previousChar = '\0';

        foreach (char currentChar in input)
        {
            if (char.IsLetterOrDigit(currentChar))
            {
                if (char.IsUpper(currentChar)
                    && (char.IsLower(previousChar) || char.IsDigit(previousChar)))
                {
                    stringBuilder.Append('_');
                }

                stringBuilder.Append(screaming ?
                    char.ToUpper(currentChar) : 
                    char.ToLower(currentChar));

                previousChar = currentChar;
            }
            else if (char.IsSeparator(currentChar)
                     && char.IsLetterOrDigit(previousChar))
            {
                stringBuilder.Append('_');
                previousChar = currentChar;
            }
        }

        if(char.IsSeparator(previousChar))
            stringBuilder.Length--;

        return stringBuilder.ToString();
    }
}