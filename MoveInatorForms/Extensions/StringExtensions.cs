namespace MoveInatorForms.Extensions
{
    public static class StringExtensions
    {
        public static string OnlyNumber(this string input)
        {
            return new String(input.Where(Char.IsDigit).ToArray());
        }
    }
}
