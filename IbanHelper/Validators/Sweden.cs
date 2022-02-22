namespace IbanHelper.Validators
{
    internal class Sweden : BaseCountry, ICountry
    {
        public string CountryCode => "SE";

        public int Length => 24;

    }
}

