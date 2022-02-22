using IbanHelper.Extensions;
using System.Collections.Generic;

namespace IbanHelper.Validators
{
    internal class Belgium : BaseCountry, ICountry
    {
        public string CountryCode => "BE";

        public int Length => 16;

        public override string GetBankName(string input)
        {
            var bankCode = input.Substring(4, 3);
            var code = int.Parse(bankCode);
            switch (code)
            {
                case int n when IsAionBank(n):
                    return "Aion Bank";
                case int n when IsAbnAmroCode(n):
                    return "ABN Amro";
                case int n when IsArgentaCode(n):
                    return "Argenta";
                case int n when IsAxaCode(n):
                    return "AXA Bank";
                case int n when IsBelfiusCode(n):
                    return "Belfius";
                case int n when IsBeobank(n):
                    return "Beobank";
                case int n when IsBnpParibasFortis(n):
                    return "BNP Paribas Fortis";
                case int n when IsBpostBank(n):
                    return "Bpost Bank";
                case int n when IsCbcBanque(n):
                    return "CBC Banque";
                case int n when IsCrelan(n):
                    return "Crelan";
                case int n when IsDeutscheBank(n):
                    return "Deutsche Bank";
                case int n when IsINGBelgie(n):
                    return "ING Belgium";
                case int n when IsKeytrade(n):
                    return "Keytrade";
                case int n when IsKbcBank(n):
                    return "KBC Bank";
                case int n when IsMeDirect(n):
                    return "MeDirect";
                case int n when IsNagelMackers(n):
                    return "Nagelmackers";
                case int n when IsRabobank(n):
                    return "Rabobank";
                case int n when IsSantander(n):
                    return "Santander";
                case int n when IsTriodosBank(n):
                    return "Triodos Bank";
                default:
                    return "Unknown";
            }
        }

        private bool IsAionBank(int code)
        {
            return code == 643;
        }

        private bool IsAbnAmroCode(int code)
        {
            var possibleCodes = new List<int>() { 509, 513, 674, 719, 722, 960 };
            return possibleCodes.Contains(code);
        }

        private bool IsArgentaCode(int code)
        {
            var possibleCodes = new List<int>() { 973, 978, 979, 980 };
            return possibleCodes.Contains(code);
        }

        private bool IsAxaCode(int code)
        {
            var possibleCodes = new List<int>() { 963, 975 };
            return possibleCodes.Contains(code) ||
                code.IsBetween(700, 709) ||
                code.IsBetween(750, 774) ||
                code.IsBetween(800, 816);
        }
        private static bool IsBelfiusCode(int code)
        {
            var possibleCodes = new List<int> { 624, 625, 638, 657, 672, 680, 682, 683 };
            return
                possibleCodes.Contains(code) ||
                code.IsBetween(50, 99) ||
                code.IsBetween(550, 560) ||
                code.IsBetween(562, 569) ||
                code.IsBetween(775, 799) ||
                code.IsBetween(830, 839);
        }

        private bool IsBeobank(int code)
        {
            var possibleCodes = new List<int> { 109, 110, 113, 114, 127, 129, 131, 133, 134 };
            return possibleCodes.Contains(code) ||
                code.IsBetween(119, 124) ||
                code.IsBetween(595, 601) ||
                code.IsBetween(950, 959);
        }

        private bool IsBnpParibasFortis(int code)
        {
            var possibleCodes = new List<int> { 137, 508 };
            return possibleCodes.Contains(code) ||
                code.IsBetween(1, 49) ||
                code.IsBetween(140, 149) ||
                code.IsBetween(200, 214) ||
                code.IsBetween(220, 298);
        }

        private bool IsBpostBank(int code)
        {
            var possibleCodes = new List<int> { 0, 299, 679, 873 };
            return possibleCodes.Contains(code) ||
                code.IsBetween(981, 999);
        }

        private bool IsCbcBanque(int code)
        {
            var possibleCodes = new List<int> { 732, 742, 728, 729 };
            return possibleCodes.Contains(code) ||
                code.IsBetween(190, 199);
        }

        private bool IsCrelan(int code)
        {
            var possibleCodes = new List<int> { 859, 860, 862, 863, 865, 866 };
            return possibleCodes.Contains(code) ||
                code.IsBetween(103, 108) ||
                code.IsBetween(850, 853);
        }
        private bool IsDeutscheBank(int code)
        {
            var possibleCodes = new List<int> { 694, 825, 826 };
            return possibleCodes.Contains(code) ||
                code.IsBetween(610, 613);
        }
        private bool IsINGBelgie(int code)
        {
            var possibleCodes = new List<int> { 185, 630, 631, 652, 673, 824, 828, 880, 881, 883, 884, 887, 888, 910, 920, 922, 923, 934, 936, 939, 961, 971, 976 };
            return possibleCodes.Contains(code) ||
                code.IsBetween(300, 399) ||
                code.IsBetween(929, 931);
        }
        private bool IsKeytrade(int code)
        {
            var possibleCodes = new List<int> { 651 };
            return possibleCodes.Contains(code);
        }
        private bool IsKbcBank(int code)
        {
            var possibleCodes = new List<int> { 640, 868 };
            return possibleCodes.Contains(code) ||
                code.IsBetween(400, 499) || 
                code.IsBetween(725, 727) || 
                code.IsBetween(730, 731) ||
                code.IsBetween(733, 741) ||
                code.IsBetween(743, 749);
        }
        private bool IsMeDirect(int code)
        {
            var possibleCodes = new List<int> { 876 };
            return possibleCodes.Contains(code);
        }
        private bool IsNagelMackers(int code)
        {
            var possibleCodes = new List<int> { 132, 871 };
            return possibleCodes.Contains(code) ||
                code.IsBetween(634, 636) ||
                code.IsBetween(646, 647) ||
                code.IsBetween(877, 879);
        }
        private bool IsRabobank(int code)
        {
            var possibleCodes = new List<int> { 172, 173, 844 };
            return possibleCodes.Contains(code);
        }
        private bool IsSantander(int code)
        {
            var possibleCodes = new List<int> { 176 };
            return possibleCodes.Contains(code) ||
                code.IsBetween(590, 594);
        }
        private bool IsTriodosBank(int code)
        {
            var possibleCodes = new List<int> { 523 };
            return possibleCodes.Contains(code);

        }
    }
}

