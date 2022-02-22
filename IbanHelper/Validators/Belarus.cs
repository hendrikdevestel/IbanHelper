namespace IbanHelper.Validators
{
    internal class Belarus : BaseCountry, ICountry
    {
        public string CountryCode => "BY";

        public int Length => 28;
    }
}

