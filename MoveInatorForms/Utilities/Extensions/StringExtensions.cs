namespace MoveInatorForms.Utilities.Extensions
{
    public static class StringExtensions
    {
        public static string OnlyNumber(this string input)
        {
            return new string(input.Where(char.IsDigit).ToArray());
        }
    }
}
