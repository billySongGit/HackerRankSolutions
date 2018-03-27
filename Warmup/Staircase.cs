using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void staircase(int n) {
        // Complete this function
        for (var i = 0; i < n; i++) {
            string white =  String.Concat(Enumerable.Repeat(" ", n - (i+1)));
            string stair = String.Concat(Enumerable.Repeat("#", (i+1)));
            Console.WriteLine(white + stair);
        }
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        staircase(n);
    }
}
  