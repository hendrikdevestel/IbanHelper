using IbanHelper.Factories;
using NUnit.Framework;

namespace IbanHelper.Tests
{
    public class IbanValidatorTests
    {
        [Test]
        [TestCase("AX2112345600000785")]
        [TestCase("AL47212110090000000235698741")]
        [TestCase("AD1200012030200359100100")]
        [TestCase("AT611904300234573201")]
        [TestCase("BY13NBRB3600900000002Z00AB00")]
        [TestCase("BE68539007547034")]
        [TestCase("BA391290079401028494")]
        [TestCase("BG80BNBG96611020345678")]
        [TestCase("HR1210010051863000160")]
        [TestCase("CY17002001280000001200527600")]
        [TestCase("CZ6508000000192000145399")]
        [TestCase("DK5000400440116243")]
        [TestCase("EE382200221020145685")]
        [TestCase("FO2000400440116243")]
        [TestCase("FI2112345600000785")]
        [TestCase("FR1420041010050500013M02606")]
        [TestCase("DE89370400440532013000")]
        [TestCase("GI75NWBK000000007099453")]
        [TestCase("GR1601101250000000012300695")]
        [TestCase("GL2000400440116243")]
        [TestCase("HU42117730161111101800000000")]
        [TestCase("IS140159260076545510730339")]
        [TestCase("IE29AIBK93115212345678")]
        [TestCase("IT60X0542811101000000123456")]
        [TestCase("XK051212012345678906")]
        [TestCase("LV80BANK0000435195001")]
        [TestCase("LI21088100002324013AA")]
        [TestCase("LT121000011101001000")]
        [TestCase("LU280019400644750000")]
        [TestCase("MK07250120000058984")]
        [TestCase("MT84MALT011000012345MTLCAST001S")]
        [TestCase("MD24AG000225100013104168")]
        [TestCase("MC5811222000010123456789030")]
        [TestCase("ME25505000012345678951")]
        [TestCase("NL91ABNA0417164300")]
        [TestCase("NO9386011117947")]
        [TestCase("PL61109010140000071219812874")]
        [TestCase("PT50000101231234567890192")]
        [TestCase("RO49AAAA1B31007593840000")]
        [TestCase("SM86U0322509800000000270100")]
        [TestCase("RS35260005601001611379")]
        [TestCase("SK3112000000198742637541")]
        [TestCase("SI56191000000123438")]
        [TestCase("ES9121000418450200051332")]
        [TestCase("SE4550000000058398257466")]
        [TestCase("CH9300762011623852957")]
        [TestCase("GB29NWBK60161331926819")]

        public void TestValidNumbers(string cardNumber)
        {
            var isValidCard = IbanValidator.Validate(cardNumber);
            Assert.IsTrue(isValidCard.IsValid);
        }

    }
}