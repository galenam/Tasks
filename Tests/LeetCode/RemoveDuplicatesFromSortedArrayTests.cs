using Tasks.LeetCode;
using Xunit;

namespace Tests.LeetCode;

public sealed class RemoveDuplicatesFromSortedArrayTests
{
    public static IEnumerable<object[]> TestData
        => new List<object[]>
        {
            new object[]
            {
                new object[]{1,1,2},
                2,
                new object[]{1,2}
            }
        };
    
    [Theory]
    [MemberData(nameof(TestData))]
    public void Test(int[] data, int count, int[] proccessed)
    {
        var result = RemoveDuplicatesFromSortedArray.RemoveDuplicates(data);
        Assert.Equal(count, result);
        int[] part = data.Take(new Range(0, count)).ToArray();
        Assert.Equal(proccessed, part);
    }
}