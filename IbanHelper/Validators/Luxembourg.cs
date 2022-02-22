namespace IbanHelper.Validators
{
    internal class Luxembourg : BaseCountry, ICountry
    {
        public string CountryCode => "LU";

        public int Length => 20;

    }
}

