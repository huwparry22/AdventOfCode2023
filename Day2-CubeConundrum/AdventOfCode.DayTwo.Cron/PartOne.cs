namespace AdventOfCode.DayTwo.Cron;

public class PartOne
{
    public void Run(IEnumerable<string> input)
    {

    }

    /// <summary>
    /// E.g Game Input - "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green"
    /// </summary>
    /// <param name="gameInput"></param>
    /// <returns></returns>
    public Game GetGame(string gameInput)
    {
        var game = new Game();
        game.ColourAndAmount = new Dictionary<string, int>();

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
                
                if (game.ColourAndAmount.ContainsKey(colour))
                {
                    game.ColourAndAmount[colour] = game.ColourAndAmount[colour] + amount;
                }
                else
                {
                    game.ColourAndAmount.Add(colour, amount);
                }
            }
        }

        return game;
    }
}
