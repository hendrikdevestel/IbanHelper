namespace IbanHelper.Validators
{
    internal class Netherlands : BaseCountry, ICountry
    {
        public string CountryCode => "NL";

        public int Length => 18;


        /// <summary>
        /// Get the bank name by the code
        /// Source: https://www.iban.nl/bic-nummers-en-nederlandse-bankcodes/
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public override string GetBankName(string input)
        {
            var bankCode = input.Substring(4, 4);
            switch (bankCode)
            {
                case "AABN":
                    return "Abn Amro Trading As Kendu";
                case "ABNA":
                    return "Abn Amro Bank";
                case "FTSB":
                    return "Abn Amro (Ex Fortis)";
                case "ABNC": 
                    return "Abn Amro Clearing Bank N.V.";
                case "ADYB": 
                    return "Adyen";
                case "AEGO": 
                    return "Aegon Bank";
                case "ANDL": 
                    return "Anadolubank";
                case "ARBN": 
                    return "Achmea Bank";
                case "ARSN": 
                    return "Argenta Spaarbank";
                case "ASNB": 
                    return "Asn Bank";
                case "ATBA": 
                    return "Amsterdam Trade Bank";
                case "BARC": 
                    return "Barclays Bank";
                case "BCDM": 
                    return "Banque Chaabi Du Maroc";
                case "BCIT": 
                    return "Intesa Sanpaolo";
                case "BICK": 
                    return "Binckbank";
                case "BINK": 
                    return "Binckbank, Prof";
                case "BITS": 
                    return "Bitsafe Payments";
                case "BKCH": 
                    return "Bank Of China";
                case "BKMG": 
                    return "Bank Mendes Gans";
                case "BLGW": 
                    return "BLG Wonen";
                case "BMEU": 
                    return "BMCE Euroservices";
                case "BNDA": 
                    return "Brand New Day Bank";
                case "BNGH": 
                    return "Bank Nederlandse Gemeenten";
                case "BNPA": 
                    return "BNP Paribas";
                case "BOFA": 
                    return "Bank Of America";
                case "BOFS": 
                    return "Bank Of Scotland, Amsterdam";
                case "BOTK": 
                    return "MUFG Bank";
                case "BUNQ": 
                    return "Bunq";
                case "CHAS": 
                    return "JPMorgan Chase";
                case "CITC": 
                    return "Citco Bank";
                case "CITI": 
                    return "Citibank International";
                case "COBA": 
                    return "Commerzbank";
                case "DELE": 
                    return "Oyens & Van Eeghen - Part Of Delen Private Bank";
                case "DEUT": 
                    return "Deutsche Bank (Bij Alle Sepa-Transacties)";
                case "DHBN": 
                    return "Demir-Halk Bank";
                case "DLBK": 
                    return "Delta Lloyd Bank";
                case "DNIB": 
                    return "NIBC";
                case "EBUR": 
                    return "Ebury Netherlands";
                case "FBHL": 
                    return "Credit Europe Bank";
                case "FLOR": 
                    return "De Nederlandsche Bank";
                case "FRNX": 
                    return "Franx";
                case "FVLB": 
                    return "Van Lanschot";
                case "GILL": 
                    return "Insingergilissen";
                case "HAND": 
                    return "Svenska Handelsbanken";
                case "HHBA": 
                    return "Hof Hoorneman Bankiers";
                case "HSBC": 
                    return "HSBC Bank";
                case "ICBC": 
                    return "Mega International Commercial Bank";
                case "ICBK": 
                    return "Industrial & Commercial Bank Of China";
                case "INGB": 
                    return "ING";
                case "ISAE": 
                    return "Caceis Bank, Netherlands Branch";
                case "ISBK": 
                    return "Isbank";
                case "KABA": 
                    return "Yapi Kredi Bank";
                case "KASA": 
                    return "Kas Bank";
                case "KNAB": 
                    return "KNAB";
                case "KOEX": 
                    return "Keb Hana Bank";
                case "KRED": 
                    return "KBC Bank";
                case "LOCY": 
                    return "Lombard Odier Darier Hentsch & Cie";
                case "LOYD": 
                    return "Lloyds Tsb Bank";
                case "LPLN": 
                    return "Leaseplan Corporation";
                case "MHCB": 
                    return "Mizuho Bank Europe Nv";
                case "MOYO": 
                    return "Moneyou";
                case "NNBA": 
                    return "Nationale-Nederlanden Bank";
                case "NWAB": 
                    return "Nederlandse Waterschapsbank";
                case "PCBC": 
                    return "China Construction Bank, Amsterdam Branch";
                case "RABO": 
                    return "Rabobank";
                case "RBRB": 
                    return "Regiobank";
                case "SNSB": 
                    return "SNS";
                case "SOGE": 
                    return "Societe Generale";
                case "TRIO": 
                    return "Triodos Bank";
                case "UGBI": 
                    return "Garantibank International";
                case "VOWA": 
                    return "Volkswagen Bank";
                case "ZWLB": 
                    return "SNS ( Ex Zwitserlevenbank)";
                default:
                    return "Unknown";
            }
        }
    }
}

