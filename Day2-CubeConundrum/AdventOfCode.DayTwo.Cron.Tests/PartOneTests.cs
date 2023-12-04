using FluentAssertions;

namespace AdventOfCode.DayTwo.Cron.Tests;

public class PartOneTests
{
    private readonly PartOne _partOne;

    public PartOneTests()
    {
        _partOne = new PartOne();
    }

    public class RunTests : PartOneTests
    {
        public RunTests() : base(){}

        [Fact]
        public void RunOnInputFile()
        {
            var expected = 2239;

            var input = File.ReadAllLines("input.txt");

            var actual = _partOne.Run(input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void RunTestData(string[] parameter, int expected)
        {
            var actual = _partOne.Run(parameter);

            Assert.Equal(expected, actual);
        }

        public static TheoryData<string[], int> TestData
        {
            get
            {
                var testData = new TheoryData<string[], int>();

                testData.Add(new string[]
                {
                    "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green",
                    "Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue",
                    "Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red",
                    "Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red",
                    "Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green"
                }, 8);

                return testData;
            }
        }
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