using IbanHelper.Enums;

namespace IbanHelper.Responses
{
    public class ValidationResponse
    {
        public bool IsValid { get; set; }
        public string BankName { get; set; }
        public ErrorCode? ErrorCode { get; set; }
    }
}
