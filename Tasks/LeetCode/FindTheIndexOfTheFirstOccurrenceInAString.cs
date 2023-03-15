namespace Tasks.LeetCode;

public static class FindTheIndexOfTheFirstOccurrenceInAString
{
    public static int StrStr(string haystack, string needle)
    {
        if (haystack.Length < needle.Length)
        {
            return -1;
        }

        if (haystack.Length == needle.Length)
        {
            if (haystack == needle)
            {
                return 0;
            }

            return -1;
        }

        for (int i = 0; i <= haystack.Length - needle.Length; i++)
        {
            if (haystack[i] == needle[0])
            {
                var str = haystack.Substring(i, needle.Length);
                if (str == needle)
                {
                    return i;
                }
            }
        }

        return -1;
    }
}