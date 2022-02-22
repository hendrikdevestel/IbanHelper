using System;
using System.Linq;

namespace IbanHelper.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input">The string to update.</param>
        /// <returns>The updated string.</returns>
        public static string RemoveWhiteSpaces(this string input)
        {
            return String.Concat(input.Where(c => !Char.IsWhiteSpace(c)));
        }

        public static bool ContainsOnlyLettersOrDigits(this string input)
        {
            return input.All(char.IsLetterOrDigit);
        }
    }
}
