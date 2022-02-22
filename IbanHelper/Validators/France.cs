namespace IbanHelper.Validators
{
    internal class France : BaseCountry, ICountry
    {
        public string CountryCode => "FR";

        public int Length => 27;

    }
}

