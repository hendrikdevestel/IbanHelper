namespace IbanHelper.Extensions
{
    public static class IntExtensions
    {
        public static bool IsBetween(this int input, int number1, int number2, bool inclusive = true)
        {
            var min = number1 < number2 ? number1 : number2;
            var max = number2 < number1 ? number2 : number1;
            if (inclusive)
                return min <= input && input <= max;
            return min < input && input < max;
        }
    }
}
