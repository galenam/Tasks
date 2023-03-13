namespace Tasks.LeetCode;

public static class LengthWord
{
    public static int LengthOfLastWord(string s)
    {
        var trimmed = s.Trim();
        var words = trimmed.Split(' ');
        return words.LastOrDefault().Length;
    }
}