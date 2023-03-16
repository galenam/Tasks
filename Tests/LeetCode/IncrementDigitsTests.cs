using FluentAssertions;
using Tasks.LeetCode;
using Xunit;

namespace Tests.LeetCode;

public sealed class IncrementDigitsTests
{
    public static IEnumerable<object[]> TestData
        => new List<object[]>
        {
            new object[]
            {
                new object[]{1,2,3},
                new object[]{1,2,4}
            },
            new object[]
            {
                new object[]{4,3,2,1},
                new object[]{4,3,2,2}
            },
            new object[]
            {
                new object[]{9,9,9},
                new object[]{1,0,0,0}
            }
        };
    
    [Theory]
    [MemberData(nameof(TestData))]
    public void Test(int[] digits, int[] correctResult)
    {
        var result = IncrementDigits.PlusOne(digits);
        result.Should().Equal(correctResult);
    }
}