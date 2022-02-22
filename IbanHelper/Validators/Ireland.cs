namespace IbanHelper.Validators
{
    internal class Ireland : BaseCountry, ICountry
    {
        public string CountryCode => "IE";

        public int Length => 22;

    }
}

