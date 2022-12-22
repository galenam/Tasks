namespace Tasks.Tasks;

/*
 * Есть массив целых положительных чисел. Необходимо найти элемент (его позицию) в этом массиве, относительно которого сумма чисел слева и
 * сумма чисел справа будут минимально различаться.

Input: [3,7,2,5,6,3]
Output: 3 (Input[3] = 5, сумма слева 12, справа 9, разница 3)
 */
public static class SumEquivalent
{
    public static int SumWithMinimumDifference(IReadOnlyList<int> source)
    {
        if (source.Count < 3)
        {
            return -1;
        }

        var sum = source.Sum();
        var leftSum = source[0];
        var rightSum = sum - source[0] - source[1];
        var bestIndex = 1;
        var diff = Math.Abs(leftSum - rightSum);
        for (int i = 2; i < source.Count - 1; i++)
        {
            leftSum += source[i - 1];
            rightSum -= source[i];
            if (Math.Abs(leftSum - rightSum) < diff)
            {
                bestIndex = i;
                diff = Math.Abs(leftSum - rightSum);
            }
        }

        return bestIndex;
    }

}