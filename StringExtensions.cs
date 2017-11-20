namespace NuGetContentFiles
{
    internal static class StringExtensions
    {
        internal static string Suffix(this string value, string suffix)
        {
            return $"{value}-{suffix}";
        }
    }
}