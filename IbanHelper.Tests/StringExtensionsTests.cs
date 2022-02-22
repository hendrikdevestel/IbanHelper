using NUnit.Framework;
using IbanHelper.Extensions;

namespace IbanHelper.Tests
{
    public class StringExtensionsTests
    {
        [Test]
        [TestCase("This is a test", "Thisisatest")]
        [TestCase(" This is a test ", "Thisisatest")]
        [TestCase("012 345 678 9", "0123456789")]
        [TestCase("     ", "")]
        public void RemoveWhiteSpaces(string input, string expected)
        {
            var result = input.RemoveWhiteSpaces();

            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase("Thisisatest", true)]
        [TestCase("Thisisatest.", false)]
        [TestCase("This-is-a-test", false)]
        [TestCase("Underscore_", false)]
        [TestCase("BE123456789", true)]
        [TestCase("BE 12 34 56 78 9", false)]
        [TestCase("BE.123456789", false)]
        public void ContainsOnlyLettersOrDigits(string input, bool expected)
        {
            var result = input.ContainsOnlyLettersOrDigits();
            Assert.AreEqual(expected, result);
        }
    }
}