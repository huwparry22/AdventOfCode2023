namespace AdventOfCode.DayOne.Cron.Test;

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
            var expected = 53539;

            var input = File.ReadAllLines("input.txt");

            var actual = _partTwo.Run(input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void RunTestData(IEnumerable<string> parameter, int expected)
        {
            var actual = _partTwo.Run(parameter);

            Assert.Equal(expected, actual);
        }

        public static TheoryData<string[], int> TestData
        {
            get
            {
                var testData = new TheoryData<string[], int>();

                testData.Add(new string[]{"two1nine", "eightwothree", "abcone2threexyz", "xtwone3four", "4nineeightseven2", "zoneight234", "7pqrstsixteen"}, 281);

                return testData;
            }
        }
    }

    public class GetFirstAndLastFromWordTests : PartTwoTests
    {
        public GetFirstAndLastFromWordTests() : base() {}

        [Theory]
        [MemberData(nameof(TestData))]
        public void GetReducedNumberTests(string parameter, int expected)
        {
            var actual = _partTwo.GetFirstAndLastFromWord(parameter);

            Assert.Equal(expected, actual);
        }

        public static TheoryData<string, int> TestData
        {
            get
            {
                var testData = new TheoryData<string, int>();

                testData.Add("two1nine", 29);
                testData.Add("eightwothree", 83);
                testData.Add("abcone2threexyz", 13);
                testData.Add("xtwone3four", 24);
                testData.Add("4nineeightseven2", 42);
                testData.Add("zoneight234", 14);
                testData.Add("7pqrstsixteen", 76);

                return testData;
            }
        }
    }
}