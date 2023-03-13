using Tasks.LeetCode;
using Xunit;

namespace Tests.LeetCode;

public sealed class LongestCommonPrefixTests
{
    public static IEnumerable<object[]> TestData
        => new List<object[]>
        {
            new object[]
            {
                new object[]{"flower","flow","flight"},
                "fl"
            },
            new object[]
            {
                new object[]{"dog","racecar","car"},
                ""
            }
        };

    [Theory]
    [MemberData(nameof(TestData))]
    public void Find(string[] strs, string correctResult)
    {
        var result = LongestCommonPrefix.Find(strs);
        Assert.Equal(correctResult, result);
    }
}