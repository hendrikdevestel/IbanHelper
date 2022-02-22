namespace IbanHelper.Validators
{
    internal class Spain : BaseCountry, ICountry
    {
        public string CountryCode => "ES";

        public int Length => 24;

    }
}

