using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void miniMaxSum(int[] arr) {
        // Complete this function
        List<long> sums = new List<long>();
        for (var i = 0; i < arr.Length; i++){
            long sum = 0;
            for (var j = 0; j < arr.Length; j++){
                if(i == j) continue;
                
                sum += arr[j];
            }
            sums.Add(sum);
        }
        
        Console.WriteLine("{0} {1}", sums.Min(), sums.Max());
    }

    static void Main(String[] args) {
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        miniMaxSum(arr);
    }
}
