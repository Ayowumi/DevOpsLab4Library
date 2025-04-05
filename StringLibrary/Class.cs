namespace StringLibrary
{
    public static class StringLibrary
    {
        public static bool StartsWithUpperCase(this string str)
        {
            return !string.IsNullOrWhiteSpace(str) && char.IsUpper(str[0]);
        }
    }
}