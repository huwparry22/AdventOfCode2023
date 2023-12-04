namespace AdventOfCode.DayTwo.Cron;

public class PartTwo
{
    public int Run(IEnumerable<string> input)
    {
        var games = new List<Game>();
        foreach (var str in input)
        {
            games.Add(Game.GetGame(str));
        }

        var powers = new List<int>();

        foreach(var game in games)
        {
            var maxRed = game.ColourAndAmount.Where(x => x.Item1 == "red").Max()?.Item2;
            var maxGreen = game.ColourAndAmount.Where(x => x.Item1 == "green").Max()?.Item2;
            var maxBlue = game.ColourAndAmount.Where(x => x.Item1 == "blue").Max()?.Item2;

            powers.Add(maxRed.Value * maxGreen.Value * maxBlue.Value);
        }

        return powers.Sum();
    }
}
