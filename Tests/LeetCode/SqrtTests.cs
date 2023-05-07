using Tasks.LeetCode;
using Xunit;

namespace Tests.LeetCode;

public sealed class SqrtTests
{
    [Theory]
    [InlineData(4,2)]
    [InlineData(8,2)]
    [InlineData(99,9)]
    [InlineData(0,0)]
    [InlineData(3,1)]
    [InlineData(5,2)]
    [InlineData(2147395599, 46339)]
    [InlineData(2147395600, 46340)]
    public void Test(int source, int correctResult)
    {
        var result = Sqrt.MySqrt(source);
        Assert.Equal(correctResult, result);
    }
}