namespace AdventOfCode.DayOne.Cron;

public class StringHelpers
{
    Dictionary<string, int> numberWords = new Dictionary<string, int>
    {
        {"zero", 0},
        {"one", 1},
        {"two", 2},
        {"three", 3},
        {"four", 4},
        {"five", 5},
        {"six", 6},
        {"seven", 7},
        {"eight", 8},
        {"nine", 9},
        {"ten", 10},
        {"eleven", 11},
        {"twelve", 12},
        {"thirteen", 13},
        {"fourteen", 14},
        {"fifteen", 15},
        {"sixteen", 16},
        {"seventeen", 17},
        {"eighteen", 18},
        {"nineteen", 19},
        {"twenty", 20},
        {"thirty",30},
        {"forty",40},
        {"fifty",50},
        {"sixty",60},
        {"seventy",70},
        {"eighty",80},
        {"ninety",90},
        {"hundred",100}
    };

    //"eightwothree" works with reverse
    //"zoneight234" not work with reverse
    public string GetReducedNumber(string item)
    {
        var rtn = item;

        foreach(var entry in numberWords.Reverse())
        {
            rtn = rtn.Replace(entry.Key, entry.Value.ToString());
        }

        // var temp = string.Empty;

        // foreach (var c in item)
        // {
        //     if (char.IsDigit(c))
        //     {
        //         temp = string.Empty;
        //         rtn += c;
        //     }
        //     else
        //     {
        //         temp += c;

        //         if (numberWords.ContainsKey(temp))
        //         {
        //             rtn.Replace(temp, numberWords[temp].ToString());
        //             temp = string.Empty;
        //         }
        //     }
        // }

        return rtn;
    }
}
