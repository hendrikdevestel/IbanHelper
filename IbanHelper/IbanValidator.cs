using IbanHelper.Enums;
using IbanHelper.Extensions;
using IbanHelper.Factories;
using IbanHelper.Responses;
using IbanHelper.Validators;

namespace IbanHelper
{
    public static class IbanValidator
    {
        public static ValidationResponse Validate(string input)
        {
            input = input.RemoveWhiteSpaces();
            if (!input.ContainsOnlyLettersOrDigits())
            {
                return new ValidationResponse()
                {
                    IsValid = false,
                    ErrorCode = ErrorCode.InvalidFormat
                };
            }

            var countryFactory = new CountryFactory();
            var country = countryFactory.GetCountry(input);
            {
                if (input.Length != country.Length)
                {
                    return new ValidationResponse()
                    {
                        IsValid = false,
                        ErrorCode = ErrorCode.InvalidLength
                    };
                }

                if (!GeneralValidator.ValidateNumber(input))
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
                    BankName = country.GetBankName(input)
                };
            }
        }
    }
}
