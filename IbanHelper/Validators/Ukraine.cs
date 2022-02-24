namespace IbanHelper.Validators
{
    internal class Ukraine : BaseCountry, ICountry
    {
        public string CountryCode => "UA";

        public int Length => 29;

    }
}

