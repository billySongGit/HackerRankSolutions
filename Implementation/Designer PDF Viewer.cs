using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int designerPdfViewer(int[] h, string word) {
        // Complete this function
        int[] wordArr = new int[word.Length+1];
        for (int i = 0; i < word.Length; i++)
        {
            int letterIndex = Convert.ToInt32(word[i]) - 97;
            int letter = h[letterIndex];

            wordArr[i] = letter;
        }

        return wordArr.Max() * (wordArr.Length - 1); 
    }

    static void Main(String[] args) {
        string[] h_temp = Console.ReadLine().Split(' ');
        int[] h = Array.ConvertAll(h_temp,Int32.Parse);
        string word = Console.ReadLine();
        int result = designerPdfViewer(h, word);
        Console.WriteLine(result);
    }
}
