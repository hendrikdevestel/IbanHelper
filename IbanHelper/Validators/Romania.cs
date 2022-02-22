namespace IbanHelper.Validators
{
    internal class Romania : BaseCountry, ICountry
    {
        public string CountryCode => "RO";

        public int Length => 24;

    }
}

