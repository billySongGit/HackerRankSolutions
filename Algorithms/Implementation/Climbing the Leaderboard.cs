using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    /*
     * Complete the climbingLeaderboard function below.
     */
    static int[] climbingLeaderboard(int[] scores, int[] alice)
    {
        int[] distScores = scores.Distinct().ToArray();
        List<int> rank = new List<int>();

        int gamesLeft = alice.Length, currentRank = 0, aliceGameIndex = 0, nextAliceScore = alice[aliceGameIndex];

        if (nextAliceScore < distScores[distScores.Length - 1])
            currentRank = distScores.Length + 1;
        else
        {
            for (int i = 0; i < distScores.Length; i++)
            {
                if (nextAliceScore >= distScores[i])
                {
                    currentRank++;
                    break;
                }
                currentRank++;
            }
        }

        gamesLeft--;
        rank.Add(currentRank);

        while (gamesLeft > 0)
        {
            nextAliceScore = alice[++aliceGameIndex];
            var temp = currentRank - 2;

            while (temp > -1)
            {
                var nextHigherRank = distScores[temp--];
                if (nextAliceScore >= nextHigherRank)
                {
                    currentRank--;
                    continue;
                }
                else
                    break;
            }
            rank.Add(currentRank);
            gamesLeft--;
        }

        return rank.ToArray();
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int scoresCount = Convert.ToInt32(Console.ReadLine());

        int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
        ;
        int aliceCount = Convert.ToInt32(Console.ReadLine());

        int[] alice = Array.ConvertAll(Console.ReadLine().Split(' '), aliceTemp => Convert.ToInt32(aliceTemp))
        ;
        int[] result = climbingLeaderboard(scores, alice);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
