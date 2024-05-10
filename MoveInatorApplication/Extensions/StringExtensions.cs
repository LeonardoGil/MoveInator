using System.Reflection;
using System.Text.Json.Serialization;

namespace MoveInatorApplication.Extensions
{
    public static class StringExtensions
    {
        public static string OnlyNumber(this string input)
        {
            return new string(input.Where(char.IsDigit).ToArray());
        }

        public static string GetJsonPropertyName<T>(this T entity, string property) where T : class
        {
            var prop = typeof(T).GetProperties().FirstOrDefault(x => x.Name == property);

            if (prop is null)
                return string.Empty;

            var jsonPropertyAttribute = prop.GetCustomAttribute<JsonPropertyNameAttribute>();

            return jsonPropertyAttribute is not null ? jsonPropertyAttribute.Name : string.Empty;
        }
    }
}
