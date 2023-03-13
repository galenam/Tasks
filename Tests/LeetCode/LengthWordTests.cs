using Tasks.LeetCode;
using Xunit;

namespace Tests.LeetCode;

public sealed class LengthWordTests
{
    [Theory]
    [InlineData("Hello World", 5)]
    [InlineData("   fly me   to   the moon  ", 4)]
    [InlineData("luffy is still joyboy", 6)]
    public void LengthOfLastWord_ShouldReturnCorrectData(string data, int count)
    {
        var result = LengthWord.LengthOfLastWord(data);
        Assert.Equal(count, result);
    }
}