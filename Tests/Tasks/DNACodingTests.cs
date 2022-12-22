using Tasks.Tasks;
using Xunit;

namespace Tests.Tasks;

public class DNACodingTests
{

    [Theory]
    [InlineData("aaaabbcaa", "a4b2c1a2")]
    [InlineData("abc", "a1b1c1")]
    public void DNACoding_CorrectData_ShouldProcessedCorrect(
        string source,
        string correctResult)
    {
        var result = DNACoding.Coding(source);
        Assert.Equal(correctResult, result);
    }


    [Theory]
    [InlineData("a", "a1")]
    [InlineData("", "")]
    public void DNACoding_NotCorrectData_ShouldFail(
        string source,
        string correctResult)
    {
        var result = DNACoding.Coding(source);
        Assert.Equal(correctResult, result);
    }
}