using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int[] breakingRecords(int[] score) {
        // Complete this function
        int highRec = 0, lowRec = 0, highScore = score[0], lowScore = score[0];
        
        for (int i = 0; i < score.Length; i++){
            if (score[i] > highScore){
                highScore = score[i];
                highRec++;
            }
            if(score[i] < lowScore) {
                lowScore = score[i];
                lowRec++;
            }
        }
        int[] result = new int[] {highRec, lowRec};
        return result;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] score_temp = Console.ReadLine().Split(' ');
        int[] score = Array.ConvertAll(score_temp,Int32.Parse);
        int[] result = breakingRecords(score);
        Console.WriteLine(String.Join(" ", result));


    }
}
