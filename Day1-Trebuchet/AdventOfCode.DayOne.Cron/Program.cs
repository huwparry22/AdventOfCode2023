using System.Runtime.CompilerServices;
using AdventOfCode.DayOne.Cron;


var partOne = new PartOne();

var input = File.ReadAllLines("input.txt");


// var input = new List<string>
// {
//     "two1nine",
//     "eightwothree",
//     "abcone2threexyz",
//     "xtwone3four",
//     "4nineeightseven2",
//     "zoneight234",
//     "7pqrstsixteen"
// };

partOne.Run(input);