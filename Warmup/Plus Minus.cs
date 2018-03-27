using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void plusMinus(int[] arr) {
        // Complete this function
        int pos = 0;
        int neg = 0;
        int zer = 0;
        
        for (var i = 0; i< arr.Length; i++){
            if(arr[i] > 0) {
                pos += 1;
            } else if (arr[i] < 0) {
                neg += 1;
            } else if (arr[i] == 0) {
                zer += 1;
            }
        }
        
        Console.WriteLine(Decimal.Divide(pos, arr.Length));
        Console.WriteLine(Decimal.Divide(neg, arr.Length));
        Console.WriteLine(Decimal.Divide(zer, arr.Length));
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        plusMinus(arr);
    }
}
