using System.Runtime.CompilerServices;
using AdventOfCode.DayOne.Cron;

//var input = File.ReadAllLines("input.txt");

var stringHelpers = new StringHelpers();


var input = new List<string>
{
    "two1nine",
    "eightwothree",
    "abcone2threexyz",
    "xtwone3four",
    "4nineeightseven2",
    "zoneight234",
    "7pqrstsixteen"
};

List<int> values = new List<int>();

foreach(var item in input)
{
    var reduced = stringHelpers.GetReducedNumber(item);

    var first = reduced.First(c => char.IsDigit(c));
    var last = reduced.Last(c => char.IsDigit(c));

    char[] arrNumber = {first, last};

    values.Add(Convert.ToInt32(new string(arrNumber)));
}

Console.WriteLine(values.Sum());