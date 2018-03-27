using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int sockMerchant(int n, int[] ar)
    {
        // Complete this function
        int pairs = 0;

        Dictionary<int, int> sockDict = new Dictionary<int, int>();

        for (int i = 0; i < n; i++)
        {
            if (sockDict.ContainsKey(ar[i]))
            {
                if (sockDict[ar[i]] == 1)
                {
                    pairs++;
                    sockDict[ar[i]] = 2;
                }
                else
                    sockDict[ar[i]] = 1;
            }
            else
                sockDict.Add(ar[i], 1);
        }

        return pairs;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
        int result = sockMerchant(n, ar);
        Console.WriteLine(result);
    }
}
