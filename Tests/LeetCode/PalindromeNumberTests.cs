using Tasks.LeetCode;
using Xunit;

namespace Tests.LeetCode;

public class PalindromeNumberTests
{
    [Theory]
    [InlineData(-121)]
    [InlineData(-5)]
    [InlineData(10)]
    public void PalindromeNumber_CorrectData_ShouldReturnFalse(int value)
    {
        var result = PalindromeNumber.IsPalindrome(value);
        Assert.False(result);
    }
    
    [Theory]
    [InlineData(121)]
    [InlineData(110011)]
    [InlineData(5)]
    public void PalindromeNumber_CorrectData_ShouldReturnTrue(int value)
    {
        var result = PalindromeNumber.IsPalindrome(value);
        Assert.True(result);
    }
}