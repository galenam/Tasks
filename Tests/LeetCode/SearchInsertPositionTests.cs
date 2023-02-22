using Tasks.LeetCode;
using Xunit;

namespace Tests.LeetCode;

public sealed class SearchInsertPositionTests
{
    public static IEnumerable<object[]> TestData
        => new List<object[]>
        {
            new object[]
            {
                new object[]{1,3,5,6},
                5,
                2
            },
            new object[]
            {
                new object[]{1,3,5,6},
                2,
                1
            },
            new object[]
            {
                new object[]{1,3,5,6},
                7,
                4
            },
            new object[]
            {
                new object[]{1,3},
                3,
                1
            }
        };
    
    [Theory]
    [MemberData(nameof(TestData))]
    public void SearchInsert_ShouldReturn_CorrectPosition(int[] data, int target, int result)
    {
        var index = SearchInsertPosition.SearchInsert(data, target);
        Assert.Equal(result, index);
    }
}