namespace Tasks.LeetCode;

public static class LongestPalindromeSubstring
{
    /*
    public static string LongestPalindrome(string s)
    {
        var storage = new Dictionary<char, List<short>>();
        for (short i = 0; i < s.Length; i++)
        {
            var ch = s[i];
            if (!storage.ContainsKey(ch))
            {
                storage.Add(ch, new List<short>{i});
            }
            else
            {
                var indexes = storage[ch];
                indexes.Add(i);
                storage[ch] = indexes;
            }
        }

        string maxPalindrome;
        foreach (var (key, value) in storage)
        {
            if (value.Count > 1)
            {
                var indexBegin = 0;
                var indexEnd = value[^1];
                while (indexEnd > indexBegin)
                {
                    
                }
            }
        }
    }
    */
}