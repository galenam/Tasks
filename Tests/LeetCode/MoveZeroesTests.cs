using Tasks.LeetCode;
using Xunit;

namespace Tests.LeetCode;

public sealed class MoveZeroesTests
{
    public static IEnumerable<object[]> TestData
        => new List<object[]>
        {
            new object[]
            {
                new object[]{0,1,0,3,12},
                new object[]{1,3,12,0,0}
            },
            new object[]
            {
                new object[]{0},
                new object[]{0}
            },
            new object[]
            {
                new object[]{0,0,0,0,1,0,3,12},
                new object[]{1,3,12,0,0,0,0,0}
            },
            new object[]
            {
                new object[]{1,3,12},
                new object[]{1,3,12}
            },
            new object[]
            {
                new object[]{45192,0,-659,-52359,-99225,-75991,0,-15155,27382,59818,0,-30645,-17025,81209,887,64648},
                new object[]{45192,-659,-52359,-99225,-75991,-15155,27382,59818,-30645,-17025,81209,887,64648,0,0,0}
            }
        };
    
    [Theory]
    [MemberData(nameof(TestData))]
    public void Test(int[] data, int[] processed)
    {
        MoveZeroesTasks.MoveZeroes(data);
        Assert.Equal(processed, data);
    }
}