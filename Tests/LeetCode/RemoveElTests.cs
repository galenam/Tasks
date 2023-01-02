using Tasks.LeetCode;
using Xunit;

namespace Tests.LeetCode;

public sealed class RemoveElTests
{
    public static IEnumerable<object[]> TestData
        => new List<object[]>
        {
            new object[]
            {
                new object[]{1,1,2},
                1,
                1,
                new object[]{2}
            },
            new object[]
            {
                new object[]{3,2,2, 3},
                3,
                2,
                new object[]{2,2}
            },
            new object[]
            {
                new object[]{1},
                1,
                0,
                new object[]{}
            }
        };
    
    [Theory]
    [MemberData(nameof(TestData))]
    public void RemoveElement(int[] data, int val, int count, int[] processed)
    {
        var result = RemoveEl.RemoveElement(data, val);
        Assert.Equal(count, result);
        int[] part = data.Take(new Range(0, count)).ToArray();
        Assert.Equal(processed, part);
    }
}