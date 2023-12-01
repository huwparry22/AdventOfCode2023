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

            testData.Add("two1nine", "29");
            testData.Add("eightwothree", "83");
            testData.Add("abcone2threexyz", "13");
            testData.Add("xtwone3four", "24");
            testData.Add("4nineeightseven2", "42");
            testData.Add("zoneight234", "14");
            testData.Add("7pqrstsixteen", "76");

            return testData;
        }
    }
}