namespace AdventOfCode.DayOne.Cron.Test;

public class PartOneTests
{
    private readonly PartOne _partOne;

    public PartOneTests()
    {
        _partOne = new PartOne();
    }

    public class RunTests : PartOneTests
    {
        public RunTests() : base() {}

        [Fact]
        public void RunOnInputFile()
        {
            var expected = 55017;

            var input = File.ReadAllLines("input.txt");

            var actual = _partOne.Run(input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void RunTestData(IEnumerable<string> parameter, int expected)
        {
            var actual = _partOne.Run(parameter);

            Assert.Equal(expected, actual);
        }

        public static TheoryData<string[], int> TestData
        {
            get
            {
                var testData = new TheoryData<string[], int>();

                testData.Add(new string[] {"1abc2", "pqr3stu8vwx", "a1b2c3d4e5f", "treb7uchet"}, 142);

                return testData;
            }
        }
    }

    public class GetFirstAndLastFromWordTests : PartOneTests
    {
        public GetFirstAndLastFromWordTests() : base() {}

        [Theory]
        [MemberData(nameof(TestData))]
        public void RunTestData(string parametrer, int expected)
        {
            var actual = _partOne.GetFirstAndLastFromWord(parametrer);

            Assert.Equal(expected, actual);
        }

        public static TheoryData<string, int> TestData
        {
            get
            {
                var testData = new TheoryData<string, int>();

                testData.Add("1abc2", 12);
                testData.Add("pqr3stu8vwx", 38);
                testData.Add("a1b2c3d4e5f", 15);
                testData.Add("treb7uchet", 77);

                return testData;
            }
        }
    }
}
