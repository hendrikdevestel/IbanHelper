using IbanHelper.Responses;

namespace IbanHelper.Validators
{
    public interface ICountry
    {
        string CountryCode { get; } 
        int Length { get; }

        string GetBankName(string input);
    }
}
