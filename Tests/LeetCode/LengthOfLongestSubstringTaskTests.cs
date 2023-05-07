using Tasks.LeetCode;
using Xunit;

namespace Tests.LeetCode;

public class LengthOfLongestSubstringTaskTests
{
    [Theory]
    [InlineData("pwwkew", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("abcabcbb",3)]
    [InlineData("abba", 2)]
    public void Test(string s, int maxLength)
    {
        var result = LengthOfLongestSubstringTask.LengthOfLongestSubstring(s);
        Assert.Equal(maxLength, result);
    }
}