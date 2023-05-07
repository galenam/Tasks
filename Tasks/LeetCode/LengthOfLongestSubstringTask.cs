namespace Tasks.LeetCode;

public static class LengthOfLongestSubstringTask
{
    public static int LengthOfLongestSubstring(string s)
    {
        if (s.Length <= 1)
        {
            return s.Length;
        }

        var storage = new Dictionary<char, int>();
        var indexBegin = 0;
        var indexEnd = 0;
        var length = 0;
        var maxLength = 0;
        for (var i =0; i< s.Length; i++)
        {
            var ch = s[i];
            if (!storage.ContainsKey(ch))
            {
                storage.Add(ch, i);
                indexEnd++;
                length++;
                if (maxLength < length)
                {
                    maxLength = length;
                }
            }
            else
            {
                indexBegin = Math.Max(indexBegin, storage[ch] + 1);
                indexEnd++;
                length = indexEnd - indexBegin;
                if (maxLength < length)
                {
                    maxLength = length;
                }

                storage[ch] = i;
            }
        }

        return maxLength;
    }   
}