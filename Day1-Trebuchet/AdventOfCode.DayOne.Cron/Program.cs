using System.Runtime.CompilerServices;
using AdventOfCode.DayOne.Cron;


var partOne = new PartOne();
var partTwo = new PartTwo();

var input = File.ReadAllLines("input.txt");

Console.WriteLine(partOne.Run(input));
Console.WriteLine(partTwo.Run(input));