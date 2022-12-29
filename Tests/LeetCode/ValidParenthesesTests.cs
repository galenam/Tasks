using Tasks.LeetCode;
using Xunit;

namespace Tests.LeetCode;

public sealed class ValidParenthesesTests
{
    [Theory]
    [InlineData("()")]
    [InlineData("()[]{}")]
    public void ValidParenthesesIsValid_CorrectString_ShouldTrue(string s)
    {
        var isValid = ValidParentheses.IsValid(s);
        Assert.True(isValid);
    }
    
    [Theory]
    [InlineData("(]")]
    [InlineData("(")]
    public void ValidParenthesesIsValid_IncorrectString_ShouldFalse(string s)
    {
        var isValid = ValidParentheses.IsValid(s);
        Assert.False(isValid);
    }
}