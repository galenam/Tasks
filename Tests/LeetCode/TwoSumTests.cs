using Tasks.LeetCode;
using Xunit;

namespace Tests.LeetCode;

public class TwoSumTests
{
    public static IEnumerable<object[]> TestData
        => new List<object[]>
        {
            new object[]
            {
                new object[]{2,7,11,15},
                9,
                new object[]{0,1}
            },
            new object[]
            {
                new object[]{3,2,4},
                6,
                new object[]{1,2}
            },
            new object[]
            {
                new object[] {3,3},
                6,
                new object[] {0,1}
            },
            new object[]
            {
                new object[] {1,1,1,1,1,4,1,1,1,1,1,7,1,1,1,1,1},
                11,
                new object[] {5, 11}
            }
        };
    
    [Theory, MemberData(nameof(TestData))]
    public void TwoSums_CorrectData_ShouldReturnCorrectIndex(int[] data, int target, int[] indexes)
    {
        var result = TwoSumCalculate.TwoSum(data, target);
        Assert.Equal(indexes, result);
    }
}