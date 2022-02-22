namespace IbanHelper.Validators
{
    internal class Norway : BaseCountry, ICountry
    {
        public string CountryCode => "NO";

        public int Length => 15;

    }
}

