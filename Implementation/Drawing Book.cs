using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int solve(int n, int p)
    {
        // Complete this function
        int halfway = n / 2;
        int turns = 0;
        if (p > halfway)
        {
            // turn from back
            int rev = n - p;
            if (rev > 1)
            {
                turns = rev / 2;
            }

            if (n % 2 == 0 && rev == 1)
                turns = 1;
        }
        else
        {
            // turn from front
            if (p > 1)
                turns = p / 2;
        }
        return turns;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int p = Convert.ToInt32(Console.ReadLine());
        int result = solve(n, p);
        Console.WriteLine(result);
    }
}
