namespace BookStore.Core.Utilities.Commands.Helpers
{
    public static class StringHelper
    {
        public static string GetFirstSyllable(this string str) => GetSyllable(str, 0);
        public static string GetSecondSyllable(this string str) => GetSyllable(str, 1);
        public static string GetThirdSyllable(this string str) => GetSyllable(str, 2);
        public static string GetSyllable(this string str, int syllableIndex)
        {
            if (string.IsNullOrWhiteSpace(str)) return default;
            if (!str.Contains(' ')) return default;

            var parts = str.Split(' ');
            if (parts.Length <= syllableIndex) return default;

            return parts[syllableIndex];
        }
    }
}
