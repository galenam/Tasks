namespace Tasks.LeetCode;

public sealed class ClimbingStaircase
{
    public static int ClimbStairs(int n) {
        switch (n)
        {
            case 0:
                return 0;
            case 1:
                return 1;
            case 2:
                return 2;
        }

        var prevPrevious = 1;
        var previous = 2;
        var result = 0;
        for (int i = 3; i <= n; i++)
        {
            result = previous + prevPrevious;
            prevPrevious = previous;
            previous = result;
        }

        return result;
    }
}