using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int diagonalDifference(int[][] a) {
    // Complete this function
        int leftD = 0;
        int rightD = 0;
        for ( int i = 0; i < a.Length; i++){
                leftD += a[i][i];
                rightD += a[i][a.Length - (i+1)];
            }
        return Math.Abs(leftD - rightD);
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] a = new int[n][];
        for(int a_i = 0; a_i < n; a_i++){
           string[] a_temp = Console.ReadLine().Split(' ');
           a[a_i] = Array.ConvertAll(a_temp,Int32.Parse);
        }
        int result = diagonalDifference(a);
        Console.WriteLine(result);
    }
}