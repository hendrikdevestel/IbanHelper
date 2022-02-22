using IbanHelper.Validators;
using System;
using System.Linq;
using System.Reflection;

namespace IbanHelper.Factories
{
    public class CountryFactory
    {
        public ICountry GetCountry(string input)
        {
            var countryCode = input.Substring(0, 2).ToUpper();
            var allCountryTypes = Assembly.GetExecutingAssembly().GetTypes()
                .Where(x => typeof(ICountry).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract).ToList();
            foreach (var countryType in allCountryTypes)
            {
                var country = (ICountry)Assembly.GetExecutingAssembly().CreateInstance(countryType.FullName);
                if (country.CountryCode.ToUpper() == countryCode)
                {
                    return country;
                }
            };
            throw new NotImplementedException("The countrycode doesn't has a validator");
        }
    }
}
