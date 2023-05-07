using Tasks.LeetCode;
using Xunit;

namespace Tests.LeetCode;

public sealed class CalculateBinarySumTests
{
    [Theory]
    [InlineData("11", "1", "100")]
    [InlineData("111", "1", "1000")]
    [InlineData("1010", "1011", "10101")]
    [InlineData("1111", "1111", "11110")]
    [InlineData("100", "110010", "110110")]
    public void Test(string a, string b, string correctResult)
    {
        var result = CalculateBinarySum.AddBinary(a, b); 
        Assert.Equal(result, correctResult);
    }
}