using IbanHelper.Enums;
using IbanHelper.Extensions;
using IbanHelper.Responses;

namespace IbanHelper.Validators
{
    internal class Andorra : BaseCountry, ICountry
    {
        public string CountryCode => "AD";

        public int Length => 24;

    }
}

