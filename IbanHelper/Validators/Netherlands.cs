namespace IbanHelper.Validators
{
    internal class Netherlands : BaseCountry, ICountry
    {
        public string CountryCode => "NL";

        public int Length => 18;
    }
}

