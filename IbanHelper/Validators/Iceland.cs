namespace IbanHelper.Validators
{
    internal class Iceland : BaseCountry, ICountry
    {
        public string CountryCode => "IS";

        public int Length => 26;

    }
}

