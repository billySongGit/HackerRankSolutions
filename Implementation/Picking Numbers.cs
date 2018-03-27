using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int pickingNumbers(int[] a)
    {
        // Complete this function
        List<int> map = Enumerable.Repeat(0, 100).ToList();
        for (int i = 0; i < a.Length; i++)
        {
            var key = a[i];
            map[key]++;
        }

        int maxCount = 0;
        for (int i = 0; i < a.Length - 1; i++)
        {
            var count = map[i] + map[i + 1];
            if (count > maxCount)
                maxCount = count;
        }

        return maxCount;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);
        int result = pickingNumbers(a);
        Console.WriteLine(result);
    }
}
