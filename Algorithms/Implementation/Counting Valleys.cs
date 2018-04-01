using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int countingValleys(int n, string s)
    {
        // Complete this function
        int height = 0, valley = 0;
        bool belowSea = false;
        for (int i = 0; i < n; i++)
        {
            if (s[i] == 'U') height++;
            else height--;

            if (height < 0 && !belowSea)
            {
                valley++;
                belowSea = true;
            }
            else if (height >= 0)
                belowSea = false;
        }
        return valley;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string s = Console.ReadLine();
        int result = countingValleys(n, s);
        Console.WriteLine(result);
    }
}
