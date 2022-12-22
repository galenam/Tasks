using Tasks.Tasks;
using Xunit;

namespace Tests.Tasks;

public sealed class SortedSquaresTests
{
    public static IEnumerable<object[]> TestData
        => new List<object[]>
        {
            new object[]
            {
                new [] {1,2,3},
                new [] {1,4,9}
            },
            new object[]
            {
                new [] {-3, -2, -1},
                new [] {1,4,9}
            },
            new object[]
            {
                new object[] {-5, -1, -1, 1, 1, 6, 12, 20},
                new object[] {1, 1, 1, 1, 25, 36, 144, 400},
            },
            new object[]
            {
                new object[]{-3, -2, -1, 0, 1, 2, 3},
                new object[]{0, 1, 1, 4, 4, 9, 9}
            },
            new object[]
            {
                new object[]{-1, 1, 2, 3, 4},
                new object[]{1, 1, 4, 9, 16}
            },
            new object[]
            {
                new object[]{-7, -5, -3, -2, -1, 3},
                new object[]{1, 4, 9, 9,25,49}
            },
            new object[]
            {
                new object[]{-7, -5, -3, -2, 1, 3},
                new object[]{1, 4, 9,9,25,49}
            },
            new object[]
            {
                new object[]{-3, -2, 1, 3, 5, 6},
                new object[]{1,4,9,9,25,36}
            },
            new object[]
            {
                new object[]{-7, 2, 3, 4, 5, 5},
                new object[]{4,9,16,25,25,49}
            },
            new object[]
            {
                new object[]{-7, -5, -3, -2, 3},
                new object[]{4,9,9,25,49}
            },
            new object[]
            {
                new object[]{-3, -2, 1, 3, 5},
                new object[]{1,4,9,9,25}
            },
            new object[]
            {
                new object[]{-7, 2, 3, 5, 5},
                new object[]{4,9,25,25,49}
            },
            new object[]
            {
                new object[]{-7, 0, 2, 3, 5, 5},
                new object[]{0,4,9,25,25,49}
            },
            new object[]
            {
                new object[]{0, 1, 1, 6, 12, 20},
                new object[]{0, 1, 1, 36, 144, 400}
            }
        };

    [Theory, MemberData(nameof(TestData))]
    public void GetSortedSquares_CorrectData_ShouldReturnSortedList(int[] source, int[] sorted)
    {
        var result = SortedSquares.GetSortedSquares(source);
        Assert.Equal(sorted, result);
    }
    
    
}