using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Tests")]
namespace Tasks.Tasks;

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
            return nums.ToArray();
        }

        if (nums.Count == 1)
        {
            return new[] { nums[0] * nums[0] };
        }

        var result = new int[nums.Count];
        var indexResult = nums.Count - 1;

        var indexLeft = 0;
        var indexRight = nums.Count - 1;
        while (indexLeft <= indexRight)
        {
            if (Math.Abs(nums[indexLeft]) < Math.Abs(nums[indexRight]))
            {
                result[indexResult] = nums[indexRight] * nums[indexRight];
                indexRight--;
            }
            else
            {
                result[indexResult] = nums[indexLeft] * nums[indexLeft];
                indexLeft++;
            }

            indexResult--;
        }

        return result;
    } 
}