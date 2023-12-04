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
    public bool IsGamePossible(string gameInput)
    {
        var splitGame = gameInput.Split(":");

        var cubeSets = splitGame[1].Split(";");
        foreach(var cubeSet in cubeSets)
        {
            var cubes = cubeSet.Split(",");
            foreach(var reveal in cubes)
            {
                var colourAmount = reveal.Split(" ");
                int amount = Convert.ToInt32(colourAmount[0].Trim());
                string colour = colourAmount[1].Trim();
            }
        }



        return false;
    }
}
