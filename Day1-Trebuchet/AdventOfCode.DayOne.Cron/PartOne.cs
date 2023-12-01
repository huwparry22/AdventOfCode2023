namespace AdventOfCode.DayOne.Cron;

public class PartOne
{
    public void Run(IEnumerable<string> input)
    {
        List<int> values = new List<int>();

        foreach(var item in input)
        {
            values.Add(GetFirstAndLastFromWord(item));
        }

        Console.WriteLine(values.Sum());
    }

    public int GetFirstAndLastFromWord(string word)
    {
        var first = word.First(c => char.IsDigit(c));
        var last = word.Last(c => char.IsDigit(c));

        char[] arrNumber = {first, last};

        return Convert.ToInt32(new string(arrNumber));
    }
}
