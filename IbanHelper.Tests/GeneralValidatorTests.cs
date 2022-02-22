using IbanHelper.Validators;
using NUnit.Framework;

namespace IbanHelper.Tests
{
    public class GeneralValidatorTests
    {
        [Test]
        [TestCase("GF4120041010050500013M02606")]
        [TestCase("AL47212110090000000235698741")]
        [TestCase("AD1200012030200359100100")]
        [TestCase("AT611904300234573201")]
        [TestCase("AZ21NABZ00000000137010001944")]
        [TestCase("BH67BMAG00001299123456")]
        [TestCase("BY13NBRB3600900000002Z00AB00")]
        [TestCase("BE68539007547034")]
        [TestCase("BA391290079401028494")]
        [TestCase("BR1800000000141455123924100C2")]
        [TestCase("BG80BNBG96611020345678")]
        [TestCase("CR05015202001026284066")]
        [TestCase("HR1210010051863000160")]
        [TestCase("CY17002001280000001200527600")]
        [TestCase("CZ6508000000192000145399")]
        [TestCase("DK5000400440116243")]
        [TestCase("DO28BAGR00000001212453611324")]
        [TestCase("SV62CENR00000000000000700025")]
        [TestCase("EE382200221020145685")]
        [TestCase("FO2000400440116243")]
        [TestCase("FI2112345600000785")]
        [TestCase("FR1420041010050500013M02606")]
        [TestCase("PF5720041010050500013M02606")]
        [TestCase("TF2120041010050500013M02606")]
        [TestCase("DE89370400440532013000")]
        [TestCase("GI75NWBK000000007099453")]
        [TestCase("GR1601101250000000012300695")]
        [TestCase("GL2000400440116243")]
        [TestCase("GT82TRAJ01020000001210029690")]
        [TestCase("HU42117730161111101800000000")]
        [TestCase("IS140159260076545510730339")]
        [TestCase("IR081234123412341234123412")]
        [TestCase("IQ98NBIQ850123456789012")]
        [TestCase("IE29AIBK93115212345678")]
        [TestCase("IL620108000000099999999")]
        [TestCase("IT60X0542811101000000123456")]
        [TestCase("JO94CBJO0010000000000131000302")]
        [TestCase("KZ86125KZT5004100100")]
        [TestCase("XK051212012345678906")]
        [TestCase("KW81CBKU0000000000001234560101")]
        [TestCase("LV80BANK0000435195001")]
        [TestCase("LB62099900000001001901229114")]
        [TestCase("LI21088100002324013AA")]
        [TestCase("LT121000011101001000")]
        [TestCase("LU280019400644750000")]
        [TestCase("MK07250120000058984")]
        [TestCase("MT84MALT011000012345MTLCAST001S")]
        [TestCase("MQ5120041010050500013M02606")]
        [TestCase("MR1300020001010000123456753")]
        [TestCase("MU17BOMM0101101030300200000MUR")]
        [TestCase("MD24AG000225100013104168")]
        [TestCase("MC5811222000010123456789030")]
        [TestCase("ME25505000012345678951")]
        [TestCase("NL91ABNA0417164300")]
        [TestCase("NO9386011117947")]
        [TestCase("PK36SCBL0000001123456702")]
        [TestCase("PS92PALS000000000400123456702")]
        [TestCase("PL61109010140000071219812874")]
        [TestCase("PT50000101231234567890192")]
        [TestCase("QA73BBME000000000004056677001")]
        [TestCase("RO49AAAA1B31007593840000")]
        [TestCase("SM86U0322509800000000270100")]
        [TestCase("ST68000100010051845310112")]
        [TestCase("SA0380000000608010167519")]
        [TestCase("RS35260005601001611379")]
        [TestCase("SK3112000000198742637541")]
        [TestCase("SI56191000000123438")]
        [TestCase("ES9121000418450200051332")]
        [TestCase("LC55HEMM000100010012001200023015")]
        [TestCase("SE4550000000058398257466")]
        [TestCase("CH9300762011623852957")]
        [TestCase("TN5910006035183598478831")]
        [TestCase("TR330006100519786457841326")]
        [TestCase("UA213996220000026007233566001")]
        [TestCase("AE070331234567890123456")]
        [TestCase("GB29NWBK60161331926819")]
        [TestCase("VG96VPVG0000012345678901")]

        public void TestValidNumbers(string cardNumber)
        {
            var isValidCard = GeneralValidator.ValidateNumber(cardNumber);
            Assert.IsTrue(isValidCard);
        }

        [Test]
        [TestCase("GF4120041010050500013M02605")]
        [TestCase("AL47212110090000000235698740")]
        [TestCase("AD1200012030200359100109")]
        [TestCase("AT611904300234573200")]
        [TestCase("AZ21NABZ00000000137010001943")]
        [TestCase("BH67BMAG00001299123455")]
        [TestCase("BY13NBRB3600900000002Z00AB01")]
        [TestCase("BE68539007547033")]
        public void TestInvalidNumbers(string cardNumber)
        {
            var isValidCard = GeneralValidator.ValidateNumber(cardNumber);
            Assert.IsFalse(isValidCard);
        }

    }
}