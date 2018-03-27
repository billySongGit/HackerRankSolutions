using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string solve(int year){
        // Complete this function
        int[] days = new int[]{31,28,31,30,31,30,31,31};
        if ((year > 1918 && (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))) || (year < 1918 && year % 4 == 0)) 
            days[1] = 29;
        
        if (year == 1918) 
            days[1] = 15;
            
        int day = 256 - days.Sum();
        DateTime date = new DateTime(year, days.Length + 1,day);   
        
        return date.ToString("dd.MM.yyyy");
    }

    static void Main(String[] args) {
        int year = Convert.ToInt32(Console.ReadLine());
        string result = solve(year);
        Console.WriteLine(result);
    }
}
