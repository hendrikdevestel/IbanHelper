namespace IbanHelper.Validators
{
    internal class Germany : BaseCountry, ICountry
    {
        public string CountryCode => "DE";

        public int Length => 22;

    }
}

