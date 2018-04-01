using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Solution {
    class Solution {
        static void Main(string[] args) {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT */
            string[] input1 = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(input1[0]);
            int k = Convert.ToInt32(input1[1]);
            string[] input2 = Console.ReadLine().Split(' ');
            int[]  itemCosts = Array.ConvertAll(input2, Int32.Parse);
            int input3 = Convert.ToInt32(Console.ReadLine());
            int bCharged = input3;
            
            int sumTotal = itemCosts.Sum();
            int bActual = (sumTotal - itemCosts[k])/2;
            
            if (bCharged == bActual) Console.WriteLine("Bon Appetit");
            else Console.WriteLine(bCharged - bActual);
        }
    }
}
