using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Tests")]
namespace Tasks;

/*
 * Дан отсортированный массив целых чисел. Нужно вернуть отсортированный массив квадратов этих чисел.

Input: nums = [0, 1, 1, 6, 12, 20]
Output: squares = [0, 1, 1, 36, 144, 400]

Input: nums = [-5, -1, -1, 1, 1, 6, 12, 20]
Output: squares = [1, 1, 1, 1, 25, 36, 144, 400]

 */
public static class SortedSquares
{
    public static IReadOnlyList<int> GetSortedSquares(IReadOnlyList<int> nums)
    {
        if (nums.Count == 0)
        {
            return nums;
        }

        if (nums.Count == 1)
        {
            return new[] { nums[0] * nums[0] };
        }

        var indexPositive = GetIndexOfTheSmallestNotNegative(nums);
        if (indexPositive == -1)
        {
            return nums
                .Reverse()
                .Select(i => i * i)
                .ToList();
        }

        if (indexPositive == 0)
        {
            return nums
                .Select(i => i * i)
                .ToList();
        }

        var result = new List<int>();
        var indexNegative = indexPositive - 1;
        while (true)
        {
            if (indexNegative < 0 && indexPositive == nums.Count)
            {
                break;
            }
            
            if (indexNegative >= 0 && indexPositive == nums.Count)
            {
                result.Add(nums[indexNegative] * nums[indexNegative]);
                indexNegative--;
                continue;
            }

            if (indexPositive < nums.Count && indexNegative < 0)
            { 
                result.Add(nums[indexPositive] * nums[indexPositive]);
                indexPositive++;
                continue;
            }

            if (indexNegative >= 0 && nums[indexPositive] > Math.Abs(nums[indexNegative]))
            {
                result.Add(nums[indexNegative] * nums[indexNegative]);
                indexNegative--;
            }
            else
            {
                result.Add(nums[indexPositive] * nums[indexPositive]);
                indexPositive++;
            }
        }

        return result;
    }

    internal static int GetIndexOfTheSmallestNotNegative(IReadOnlyList<int> nums)
    {
        if (nums.Count == 0)
        {
            return -1;
        }

        if (nums[0] >= 0)
        {
            return 0;
        }

        if (nums.Last() <= 0)
        {
            return -1;
        }

        var index = nums.Count / 2;
        var previous = 0;
        while (true)
        {
            if (nums[index] == 0)
            {
                return index;
            }

            if (nums[index] > 0  && index > 0 && nums[index - 1] <= 0)
            {
                return index;
            }

            if (nums[index] < 0 && index < nums.Count && nums[index + 1] >= 0)
            {
                return index + 1;
            }

            if (nums[index] > 0)
            {
                index = index / 2;
            }
            else
            {
                index = (nums.Count + index) / 2;
            }
        }
    }
}