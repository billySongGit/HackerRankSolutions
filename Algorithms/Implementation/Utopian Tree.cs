using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int utopianTree(int n)
    {
        // Complete this function
        int height = 1;
        for (int i = 1; i <= n; i++)
        {
            if (i == 1 || i % 2 == 1)
            {
                height = height * 2;
            }
            else if (i == 2 || i % 2 == 0)
            {
                height++;
            }
        }

        return height;
    }

    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int result = utopianTree(n);
            Console.WriteLine(result);
        }
    }
}
