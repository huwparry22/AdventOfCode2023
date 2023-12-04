namespace AdventOfCode.DayTwo.Cron.Tests;

public class PartTwoTests
{
    private readonly PartTwo _partTwo;

    public PartTwoTests()
    {
        _partTwo = new PartTwo();
    }

    public class RunTests : PartTwoTests
    {
        public RunTests() : base() {}

        [Fact]
        public void RunOnInputFile()
        {
            var expected = 83435;

            var input = File.ReadAllLines("input.txt");

            var actual = _partTwo.Run(input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void RunTestData(string[] parameter, int expected)
        {
            var actual = _partTwo.Run(parameter);

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
                }, 2286);

                return testData;
            }
        }
    }
}
