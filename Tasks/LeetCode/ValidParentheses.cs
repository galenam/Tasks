namespace Tasks.LeetCode;
/*
 * Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
An input string is valid if:
Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Every close bracket has a corresponding open bracket of the same type.
Example 1:
Input: s = "()"
Output: true
Example 2:
Input: s = "()[]{}"
Output: true
Example 3:
Input: s = "(]"
Output: false
Constraints:
1 <= s.length <= 104
s consists of parentheses only '()[]{}'.
 */
public static class ValidParentheses
{
    public static bool IsValid(string s)
    {
        var stack = new Stack<char>();
        var openSymbols = new[] { '(', '{', '[' };
        var closedSymbols = new[] { ')', '}', ']' };
        for (var i = 0; i < s.Length; i++)
        {
            if (openSymbols.Contains(s[i]))
            {
                stack.Push(s[i]);
            }

            if (closedSymbols.Contains(s[i]))
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                var ch = stack.Pop();
                var indexOpened = Array.IndexOf(openSymbols, ch);
                if (indexOpened == -1)
                {
                    return false;
                }

                var indexClosed = Array.IndexOf(closedSymbols, s[i]);
                if (indexClosed == -1)
                {
                    return false;
                }

                if (indexClosed != indexOpened)
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}