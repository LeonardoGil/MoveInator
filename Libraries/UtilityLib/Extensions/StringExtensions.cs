namespace UtilityLib.Extensions
{
    public static class StringExtensions
    {
        public static string RandomNumbers(int lenght)
        {
            var random = new Random();
            var result = string.Empty;

            for (int i = 0; i <= lenght - 1; i++)
            {
                result += random.Next(0, 9);
            }

            return result;
        }

        public static bool AllCharsAreEqual(this string value)
        {
            return value.Distinct().Count() == 1;
        }
    }
}
