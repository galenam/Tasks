namespace Tasks.LeetCode;


public static class PalindromeNumber
{
    /*
     * Given an integer x, return true if x is a 
        palindrome, and false otherwise.
        Example 1:
        Input: x = 121
        Output: true
        Explanation: 121 reads as 121 from left to right and from right to left.
        Example 2:
        Input: x = -121
        Output: false
        Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
        Example 3:
        Input: x = 10
        Output: false
        Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
     */
    public static bool IsPalindrome(int x)
    {
        var quotient = x / 10;
        if (quotient == 0)
        {
            if (x >= 0)
            {
                return true;
            }
            return false;
        }

        int value = x ;
        int reverse = 0;
        while (value > 0)
        {
            var reminder = value % 10;
            value /= 10;
            reverse = reverse * 10 + reminder;
        }

        return reverse == x;
    }
}