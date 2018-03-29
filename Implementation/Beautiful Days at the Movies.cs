using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int beautifulDays(int i, int j, int k)
    {
        // Complete this function
        int[] a = Enumerable.Range(i, (j - i) + 1).ToArray();
        int result = 0;
        for (int m = 0; m < a.Length; m++)
        {
            if (Math.Abs(a[m] - a[m].Reverse()) % k == 0)
                result++;
        }

        return result;
    }

    static void Main(String[] args)
    {
        string[] tokens_i = Console.ReadLine().Split(' ');
        int i = Convert.ToInt32(tokens_i[0]);
        int j = Convert.ToInt32(tokens_i[1]);
        int k = Convert.ToInt32(tokens_i[2]);
        int result = beautifulDays(i, j, k);
        Console.WriteLine(result);
    }
}

// Extensions Methods
public static class Extensions
{
    public static int Reverse(this int num)
    {
        int res = 0;
        while (num > 0)
        {
            res = (res * 10) + (num % 10);
            num /= 10;
        }
        return res;
    }
}
