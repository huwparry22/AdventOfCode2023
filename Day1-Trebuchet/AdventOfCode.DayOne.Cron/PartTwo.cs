using System.Text.RegularExpressions;

namespace AdventOfCode.DayOne.Cron;

public class PartTwo
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

    public int Run(IEnumerable<string> input)
    {
        List<int> values = new List<int>();

        foreach(var item in input)
        {
            values.Add(GetFirstAndLastFromWord(item));
        }
        
        return values.Sum();
    }

    public int GetFirstAndLastFromWord(string word)
    {
        var pattern = "(one)|(two)|(three)|(four)|(five)|(six)|(seven)|(eight)|(nine)|[0-9]";

        var first = Regex.Match(word, pattern).Value;
        var last = Regex.Match(word, pattern, RegexOptions.RightToLeft).Value;

        if (first.Length > 1)
            first = numberWords[first];

        if (last.Length > 1)
            last = numberWords[last];

        return Convert.ToInt32(first + last);
    }
}
