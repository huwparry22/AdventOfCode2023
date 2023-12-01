namespace AdventOfCode.DayOne.Cron.Test;

public class StringHelpersTests
{
    private readonly StringHelpers _stringHelpers;

    public StringHelpersTests()
    {
        _stringHelpers = new StringHelpers();
    }

    [Theory]
    [MemberData(nameof(TestData))]
    public void GetReducedNumberTests(string parameter, string expected)
    {
        var actual = _stringHelpers.GetReducedNumber(parameter);

        Assert.Equal(expected, actual);
    }

    public static TheoryData<string, string> TestData
    {
        get
        {
            var testData = new TheoryData<string, string>();

            testData.Add("two1nine", "219");
            testData.Add("eightwothree", "8wo3");
            testData.Add("abcone2threexyz", "abc123xyz");
            testData.Add("xtwone3four", "x2ne34");
            testData.Add("4nineeightseven2", "49872");
            testData.Add("zoneight234", "z1ight234");
            testData.Add("7pqrstsixteen", "7pqrst16");

            return testData;
        }
    }
}