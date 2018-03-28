using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int formingMagicSquare(int[][] s)
    {
        // Complete this function
        int[] cost = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };
        // list of all magic squares
        int[,] t = new int[,]{
            {4,9,2,3,5,7,8,1,6},
            {4,3,8,9,5,1,2,7,6},
            {2,9,4,7,5,3,6,1,8},
            {2,7,6,9,5,1,4,3,8},
            {8,1,6,3,5,7,4,9,2},
            {8,3,4,1,5,9,6,7,2},
            {6,7,2,1,5,9,8,3,4},
            {6,1,8,7,5,3,2,9,4}
        };

        for (int i = 0; i < 8; i++)
        {
            cost[i] = Math.Abs(t[i, 0] - s[0][0]) + Math.Abs(t[i, 1] - s[0][1]) + Math.Abs(t[i, 2] - s[0][2]);
            cost[i] = cost[i] + Math.Abs(t[i, 3] - s[1][0]) + Math.Abs(t[i, 4] - s[1][1]) + Math.Abs(t[i, 5] - s[1][2]);
            cost[i] = cost[i] + Math.Abs(t[i, 6] - s[2][0]) + Math.Abs(t[i, 7] - s[2][1]) + Math.Abs(t[i, 8] - s[2][2]);
            //Console.WriteLine(cost[i]);
        }
        Array.Sort(cost);
        return cost[0];
    }

    static void Main(String[] args)
    {
        int[][] s = new int[3][];
        for (int s_i = 0; s_i < 3; s_i++)
        {
            string[] s_temp = Console.ReadLine().Split(' ');
            s[s_i] = Array.ConvertAll(s_temp, Int32.Parse);
        }
        int result = formingMagicSquare(s);
        Console.WriteLine(result);
    }
}
