using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int getTotalX(int[] a, int[] b) {
        // Complete this function
        int count = 0;
        for (int i = 1; i <= 100; i++){
            bool testA = true;
            bool testB = true;
            for (int arrA = 0; arrA < a.Length; arrA++){
                if (i%a[arrA]!=0) 
                    testA = false;
            }
            for (int arrB = 0; arrB < b.Length; arrB++){
                if (b[arrB]%i!=0) 
                    testB = false;
            }
            if (testA == true && testB == true) 
                count++;
        }
        return count;
    }

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int m = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        string[] b_temp = Console.ReadLine().Split(' ');
        int[] b = Array.ConvertAll(b_temp,Int32.Parse);
        int total = getTotalX(a, b);
        Console.WriteLine(total);
    }
}
