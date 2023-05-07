using Tasks.LeetCode;
using Xunit;

namespace Tests.LeetCode;

public sealed class ClimbingStaircaseTests
{
    [Theory]
    [InlineData(1,1)]
    [InlineData(2,2)]
    [InlineData(3,3)]
    [InlineData(4,5)]
    [InlineData(5,8)]
    public void Test(int input, int output)
    {
        var result = ClimbingStaircase.ClimbStairs(input);
        Assert.Equal(output, result);
    }
}