using Tasks;
using Xunit;

namespace Tests;

public sealed class SumEquivalentTest
{
    public static IEnumerable<object[]> TestData
        => new List<object[]>
        {
            new object[]
            {
                new[] { 3, 7, 2, 5, 6, 3 },
                3
            },
            new object[]
            {
                new[] { 1, 2, 3 },
                1
            },
            new object[]
            {
                new[] { 3, 2, 1 },
                1
            },
            new object[]
            {
                new object[] { 5, 1, 1, 1, 1, 6, 12, 20 },
                6
            },
            new object[]
            {
                new object[] { 3, 2, 1, 0, 1, 2, 3 },
                3
            },
            new object[]
            {
                new object[] { 1, 1, 2, 3, 4 },
                3
            },
            new object[]
            {
                new object[] { 7, 5, 3, 2, 1, 3 },
                1
            },
            new object[]
            {
                new object[] { 3, 2, 1, 3, 5, 6 },
                4
            },
            new object[]
            {
                new object[] { 7, 2, 3, 4, 5, 5 },
                3
            },
            new object[]
            {
                new object[] { 7, 5, 3, 2, 3 },
                1
            },
            new object[]
            {
                new object[] { 3, 2, 1, 3, 5 },
                3
            },
            new object[]
            {
                new object[] { 7, 2, 3, 5, 5 },
                2
            },
            new object[]
            {
                new object[] { 7, 0, 2, 3, 5, 5 },
                3
            },
            new object[]
            {
                new object[] { 0, 1, 1, 6, 12, 20 },
                4
            }
        };

    [Theory, MemberData(nameof(TestData))]
    public void SumWithMinimumDifference_CorrectData_ShouldReturnIndex(int[] source, int index)
    {
        var result = SumEquivalent.SumWithMinimumDifference(source);
        Assert.Equal(index, result);
    }
}