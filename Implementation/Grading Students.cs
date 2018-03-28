using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int[] solve(int[] grades){
        // Complete this function
        for (var i = 0; i < grades.Length; i++){
            if (grades[i] < 38) 
                continue;
            for (var j = 0; j < 13; j++){
                if( j*5 + 2 < grades[i] - 35 && grades[i] - 35 <= (j+1)*5) 
                    grades[i] = (j+1)*5 + 35;
            }
        }
            return grades;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] grades = new int[n];
        for(int grades_i = 0; grades_i < n; grades_i++){
           grades[grades_i] = Convert.ToInt32(Console.ReadLine());   
        }
        int[] result = solve(grades);
        Console.WriteLine(String.Join("\n", result));
        

    }
}
