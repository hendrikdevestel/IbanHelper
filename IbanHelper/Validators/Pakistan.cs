namespace IbanHelper.Validators
{
    internal class Pakistan : BaseCountry, ICountry
    {
        public string CountryCode => "PK";

        public int Length => 24;

    }
}

