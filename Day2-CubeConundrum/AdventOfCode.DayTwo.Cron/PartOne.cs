namespace AdventOfCode.DayTwo.Cron;

public class PartOne
{
    private readonly Dictionary<string, int> MAX_CUBES = new Dictionary<string, int>
    {
        {"red", 12},
        {"green", 13},
        {"blue", 14}
    };

    public int Run(IEnumerable<string> input)
    {
        var games = new List<Game>();
        foreach (var str in input)
        {
            games.Add(Game.GetGame(str));
        }

        var possibleGameIds = new List<int>();
        foreach(var game in games)
        {
            bool gamePossible = true;
            
            foreach(var max in MAX_CUBES)
            {
                if (game.ColourAndAmount.Any(x => x.Item1 == max.Key && x.Item2 > max.Value))
                {
                    gamePossible = false;
                    break;
                }
            }
            
            if (gamePossible)
            {
                possibleGameIds.Add(game.GameId);
            }
        }

        return possibleGameIds.Sum();
    }
}
