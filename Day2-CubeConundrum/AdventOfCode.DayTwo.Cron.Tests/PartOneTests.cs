using FluentAssertions;

namespace AdventOfCode.DayTwo.Cron.Tests;

public class PartOneTests
{
    private readonly PartOne _partOne;

    public PartOneTests()
    {
        _partOne = new PartOne();
    }

    public class GetGameTests : PartOneTests
    {
        public GetGameTests() : base() {}

        [Theory]
        [MemberData(nameof(TestData))]
        public void RunTestData(string parameter, Game expected)
        {
            var actual = _partOne.GetGame(parameter);

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
                    ColourAndAmount = new Dictionary<string, int>
                    {
                        {"blue", 9},
                        {"red", 5},
                        {"green", 4}
                    }
                });

                return testData;
            }
        }
    }
}