using Tasks.LeetCode;
using Xunit;

namespace Tests.LeetCode;

public sealed class RomanToIntegerTests
{
    [Theory]
    [InlineData("I", 1)]
    [InlineData("II", 2)]
    [InlineData("III", 3)]
    [InlineData("IV", 4)]
    [InlineData("V", 5)]
    [InlineData("VI", 6)]
    [InlineData("VII", 7)]
    [InlineData("VIII", 8)]
    [InlineData("IX", 9)]
    [InlineData("X", 10)]
    [InlineData("XI", 11)]
    [InlineData("L", 50)]
    [InlineData("XL", 40)]
    [InlineData("LX", 60)]
    [InlineData("D", 500)]
    [InlineData("CD", 400)]
    [InlineData("CM", 900)]
    public void RomanToInt_CorrectData_ShouldReturnValue(string data, int figure)
    {
        var result = RomanToInteger.RomanToInt(data);
        Assert.Equal(figure, result);
    }

    [Theory]
    [InlineData("CSD")]
    [InlineData("")]
    [InlineData("KKK")]
    public void RomanToInt_InCorrectData_ShouldReturn0(string data)
    {
        var result = RomanToInteger.RomanToInt(data);
        Assert.Equal(0, result);
    }
}