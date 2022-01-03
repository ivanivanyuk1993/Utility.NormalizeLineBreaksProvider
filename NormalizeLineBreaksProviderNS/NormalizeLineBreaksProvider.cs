using System.Text.RegularExpressions;

namespace NormalizeLineBreaksProviderNS;

public static class NormalizeLineBreaksProvider
{
    /// <summary>
    ///     Notice that \\r\\n goes first to match longest first, and not match twice
    ///     Notice that <see cref="NewLineRegex"/> should not be used outside of
    ///     <see cref="NormalizeLineBreaksProvider"/>, because `.` matches `\r`, which breaks
    ///     regexps(like `.+` matches "asd\r" in string "asd\r\n")
    /// </summary>
    private static readonly Regex NewLineRegex = new(pattern: "(?:\\r\\n|\\r|\\n)");

    public static string NormalizeLineBreaks(this string stringToNormalize)
    {
        return NewLineRegex.Replace(
            input: stringToNormalize,
            replacement: "\n"
        );
    }
}