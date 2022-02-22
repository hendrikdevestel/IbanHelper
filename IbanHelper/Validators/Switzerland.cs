namespace IbanHelper.Validators
{
    internal class Switzerland : BaseCountry, ICountry
    {
        public string CountryCode => "CH";

        public int Length => 21;

    }
}

