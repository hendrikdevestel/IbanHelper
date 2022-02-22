using IbanHelper.Factories;
using NUnit.Framework;

namespace IbanHelper.Tests
{
    public class CountryFactoryTests
    {
        [Test]
        [TestCase("AL47212110090000000235698741", "Albania")]
        [TestCase("BE68539007547034", "Belgium")]

        public void TestGetCountry(string cardNumber, string expectedType)
        {
            var countryFactory = new CountryFactory();
            var countryType = countryFactory.GetCountry(cardNumber);
            Assert.AreEqual(expectedType, countryType.GetType().Name);
        }
    }
}