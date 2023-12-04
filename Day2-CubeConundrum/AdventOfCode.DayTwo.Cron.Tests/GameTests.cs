using FluentAssertions;

namespace AdventOfCode.DayTwo.Cron.Tests;

public class GameTests
{
    public class GetGameTests : PartOneTests
    {
        public GetGameTests() : base() {}

        [Theory]
        [MemberData(nameof(TestData))]
        public void RunTestData(string parameter, Game expected)
        {
            var actual = Game.GetGame(parameter);

            actual.Should().BeEquivalentTo(expected);
        }

        public static TheoryData<string, Game> TestData
        {
            get
            {
                var testData = new TheoryData<string, Game>();

                testData.Add("Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green", new Game
                {
                    GameId = 1,
                    ColourAndAmount = new List<Tuple<string, int>>
                    {
                        new Tuple<string, int>("blue", 3),
                        new Tuple<string, int>("red", 4),
                        new Tuple<string, int>("red", 1),
                        new Tuple<string, int>("green", 2),
                        new Tuple<string, int>("blue", 6),
                        new Tuple<string, int>("green", 2),
                    }
                });

                return testData;
            }
        }
    }
}
