using IbanHelper.Enums;
using IbanHelper.Extensions;
using IbanHelper.Responses;
using System.Collections.Generic;

namespace IbanHelper.Validators
{
    internal class Belgium
    {
        private const string Code = "BE";
        private const int length = 16;
        private const int checkNumberLength = 2;
        private const int bankCodeLength = 3;
        private const int modulus = 97;

        public ValidationResponse Validate(string input)
        {
            input = input.RemoveWhiteSpaces();
            if (input.ContainsAnySpecialCharacters())
            {
                return new ValidationResponse()
                {
                    IsValid = false,
                    ErrorCode = ErrorCode.InvalidFormat
                };
            }
            if (input.Length != length)
            {
                return new ValidationResponse()
                {
                    IsValid = false,
                    ErrorCode = ErrorCode.InvalidLength
                };
            }

            if (!ValidateNumber(input))
            {
                return new ValidationResponse()
                {
                    IsValid = false,
                    ErrorCode = ErrorCode.InvalidNumber
                };
            }
            return new ValidationResponse()
            {
                IsValid = true,
                BankName = GetBankName(input)
            };
        }

        private bool ValidateNumber(string input)
        {
            var strNumber = input.Substring(4, input.Length - 6);
            var number = double.Parse(strNumber);
            var result = number % modulus;

            var checkNumber = input.Substring(input.Length - 2);
            return result == double.Parse(checkNumber);
        }

        private string GetBankName(string input)
        {
            var bankCode = input.Substring(4, 3);
            var code = int.Parse(bankCode);
            switch (code)
            {
                case 643:
                    return "Aion Bank";
                case 651:
                    return "Keytrade";

                case int n when (IsBelfiusCode(n)):
                    return "Belfius";
                default:
                    return "Unknown";
            }
        }

        private static bool IsBelfiusCode(int code)
        {
            var possibleCodes = new List<int> { 624, 625, 638, 657, 672, 680, 682, 683 };
            return  (code >= 50 && code <= 99) ||
                    (code >= 550 && code <= 560) ||
                    (code >= 562 && code <= 569) ||
                    (code >= 775 && code <= 799) ||
                    (code >= 830 && code <= 839) ||
                    possibleCodes.Contains(code);
        }
    }
}

