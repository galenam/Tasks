namespace Tasks.LeetCode;

public static class IncrementDigits
{
    public static int[] PlusOne(int[] digits) {
        if (digits.Length == 0)
        {
            return digits;
        }

        if (digits[^1] < 9)
        {
            digits[^1]++;
            return digits;
        }

        for (var i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] == 9)
            {
                digits[i] = 0;
                if (i == 0)
                {
                    var list = digits.ToList();
                    list.Insert(0, 1);
                    return list.ToArray();
                }
            }
            else
            {
                digits[i]++;
                break;
            }
        }

        return digits;
    }
}