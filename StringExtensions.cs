namespace Our.Umbraco.Extensions;

public static class StringExtensions
{
    public static bool AnyNullOrWhiteSpace(this IEnumerable<string> input)
    {
        return input.Any(string.IsNullOrWhiteSpace);
    }
}
