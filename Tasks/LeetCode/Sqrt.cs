namespace Tasks.LeetCode;

public static class Sqrt
{
    public static int MySqrt(int x)
    {
        var maxSqrt = 46340;
        switch (x)
        {
            case 0:
                return 0;
            case <= 3:
                return 1;
            case <= 8:
                return 2;
            case >=2147395600:
                return maxSqrt;
        }

        var left = 0;
        var right = Math.Min(maxSqrt, x/2);
        var middle = right / 2;
        while (right - left > 1)
        {
            var power2 = middle * middle;
            var power2Bigger = (middle + 1) * (middle + 1);
            if (power2 <= x && (middle == maxSqrt || power2Bigger >= x))
            {
                return middle;
            }
            
            if (power2 < x)
            {
                left = middle;
            }
            else
            {
                right = middle;
            }
            middle = (left + right) / 2;
        }

        return middle;
    }
}