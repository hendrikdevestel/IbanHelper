using System.Numerics;

namespace IbanHelper.Validators
{
    public static class GeneralValidator
    {
        public static bool ValidateNumber(string input)
        {
            var strNumber = input.Substring(4, input.Length - 4) + input.Substring(0, 2);
            //Replace A = 10, B = 11, C = 12, ...
            var number = GetNumeralValue(strNumber);
            number *= 100;
            var modulusResult = number % 97;
            var result = 98 - modulusResult;

            var checkNumber = input.Substring(2, 2);
            return result == BigInteger.Parse(checkNumber);
        }

        private static BigInteger GetNumeralValue(string input)
        {
            input = input.ToUpper();
            var strNumber = string.Empty;
            foreach (var character in input)
            {
                if (char.IsDigit(character))
                {
                    strNumber += character;
                }
                else
                {
                    var placeAtAlphabet = character - 'A';
                    strNumber += $"{10 + placeAtAlphabet}";
                }
            }
            return BigInteger.Parse(strNumber);
        }
    }
}
