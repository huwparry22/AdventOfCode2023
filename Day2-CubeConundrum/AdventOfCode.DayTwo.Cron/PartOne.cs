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
            games.Add(GetGame(str));
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

    /// <summary>
    /// E.g Game Input - "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green"
    /// </summary>
    /// <param name="gameInput"></param>
    /// <returns></returns>
    public Game GetGame(string gameInput)
    {
        var game = new Game();
        game.ColourAndAmount = new List<Tuple<string, int>>();

        var splitGame = gameInput.Split(":");
        game.GameId = Convert.ToInt32(splitGame[0].Replace("Game ", "").Trim());

        var cubeSets = splitGame[1].Split(";");
        foreach(var cubeSet in cubeSets)
        {
            var cubes = cubeSet.Split(",");
            foreach(var reveal in cubes)
            {
                var colourAmount = reveal.Trim().Split(" ");
                int amount = Convert.ToInt32(colourAmount[0].Trim());
                string colour = colourAmount[1].Trim();
                
                // if (game.ColourAndAmount.ContainsKey(colour))
                // {
                //     game.ColourAndAmount[colour] = game.ColourAndAmount[colour] + amount;
                // }
                // else
                // {
                //     game.ColourAndAmount.Add(colour, amount);
                // }

                game.ColourAndAmount.Add(Tuple.Create(colour, amount));
            }
        }

        return game;
    }
}
