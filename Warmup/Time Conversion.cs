using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string timeConversion(string s) {
        // Complete this function
        DateTime time = DateTime.ParseExact(s, "hh:mm:sstt", System.Globalization.CultureInfo.InvariantCulture);
        return (time.ToString("HH:mm:ss"));
    }

    static void Main(String[] args) {
        string s = Console.ReadLine();
        string result = timeConversion(s);
        Console.WriteLine(result);
    }
}
