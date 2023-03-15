using Tasks.LeetCode;
using Xunit;

namespace Tests.LeetCode;

public sealed class FindTheIndexOfTheFirstOccurrenceInAStringTests
{
    [Theory]
    [InlineData("sadbutsad", "sad", 0)]
    [InlineData("leetcode", "leeto", -1)]
    [InlineData("aaa", "aaaa", -1)]
    [InlineData("mississippi", "issip", 4)]
    [InlineData("abc", "c", 2)]
    public void Test(string needle, string haystack, int correctIndex)
    {
        var index = FindTheIndexOfTheFirstOccurrenceInAString.StrStr(needle, haystack);
        Assert.Equal(correctIndex, index);
    }
}