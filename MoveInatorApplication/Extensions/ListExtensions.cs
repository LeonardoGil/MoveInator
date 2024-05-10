namespace MoveInatorApplication.Extensions
{
    public static class ListExtensions
    {
        public static T GetRandom<T>(this List<T> list)
        {
            if (!list.Any())
                throw new Exception("Lista Vazia");

            return list[new Random().Next(0, list.Count - 1)];
        }
    }
}
