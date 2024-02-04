using System.Drawing;

namespace UtilityLib.Extensions
{
    public static class FloatExtensions
    {
        public static float Around(this float value, float weight) => Convert.ToSingle(Math.Round(value / weight) * weight);
    }
}
