namespace _16.Task1.Extensions
{
    public static class StringExtensions
    {
        public static string Modify(this string str)
        {
            return str.Substring(0, 5) + "...";
        }
    }
}