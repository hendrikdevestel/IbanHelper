namespace IbanHelper.Validators
{
    internal class Austria : BaseCountry, ICountry
    {
        public string CountryCode => "AT";

        public int Length => 20;

    }
}

