namespace Tasks.LeetCode;

public static class CalculateBinarySum
{
    public static string AddBinary(string a, string b)
    {
        string first, second;
        if (a.Length < b.Length)
        {
            first = b;
            second = a;
        }
        else
        {
            first = a;
            second = b;
        }
        
        var result = new char[first.Length];
        var correction = '0';
        var index = second.Length - 1;
        var diff = first.Length - second.Length;
        for (int i = first.Length - 1; i >= diff; i--)
        {
            var array = new []{ first[i], second[index], correction };
            var count1 = array.Count(s => s == '1');
            if (count1 <= 1)
            {
                result[i] = count1.ToString()[0];
                correction = '0';
            }

            if (count1 == 2)
            {
                result[i] = '0';
                correction = '1';
            }
            
            if (count1 == 3)
            {
                result[i] = '1';
                correction = '1';
            }

            index--;
        }
        
        if (correction == '0')
        {
            for (int j = 0; j < diff; j++)
            {
                result[j] = first[j];
            }   
            return new string(result);
        }
        for (int i = diff - 1; i >= 0; i--)
        {
            var array = new []{ first[i], correction };
            var count1 = array.Count(s => s == '1');
            if (count1 <= 1)
            {
                result[i] = count1.ToString()[0];
                correction = '0';
            }

            if (count1 == 2)
            {
                result[i] = '0';
                correction = '1';
            }
        }

        if (correction == '1')
        {
            return string.Concat("1" + new string(result));
        }

        return new string(result);
    }
}