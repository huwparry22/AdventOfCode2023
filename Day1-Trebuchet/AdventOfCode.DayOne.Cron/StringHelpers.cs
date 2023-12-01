using System.Text.RegularExpressions;

namespace AdventOfCode.DayOne.Cron;

public class StringHelpers
{
    Dictionary<string, string> numberWords = new Dictionary<string, string>
    {
        {"zero", "0"},
        {"one", "1"},
        {"two", "2"},
        {"three", "3"},
        {"four", "4"},
        {"five", "5"},
        {"six", "6"},
        {"seven", "7"},
        {"eight", "8"},
        {"nine", "9"}
    };

    public string GetReducedNumber(string item)
    {
        var pattern = "(one)|(two)|(three)|(four)|(five)|(six)|(seven)|(eight)|(nine)|[0-9]";

        var first = Regex.Match(item, pattern).Value;
        var last = Regex.Match(item, pattern, RegexOptions.RightToLeft).Value;

        if (first.Length > 1)
            first = numberWords[first];

        if (last.Length > 1)
            last = numberWords[last];

        return first + last;
    }
}
