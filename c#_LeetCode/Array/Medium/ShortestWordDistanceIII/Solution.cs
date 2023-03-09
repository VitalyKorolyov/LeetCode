namespace LeetCode.Array.Medium.ShortestWordDistanceIII;

//https://leetcode.com/problems/shortest-word-distance-iii/description/
public class Solution
{
    public int ShortestWordDistance(string[] wordsDict, string word1, string word2)
    {
        int prevIndex = -1;
        int length = int.MaxValue;
        var isEqual = word1 == word2;

        for (int i = 0; i < wordsDict.Length; i++)
        {
            var key = wordsDict[i];
            if (key != word1 && key != word2) continue;

            if (prevIndex != -1 && (wordsDict[prevIndex] != wordsDict[i] || isEqual))
                length = System.Math.Min(length, System.Math.Abs(i - prevIndex));

            prevIndex = i;
        }

        return length;
    }
}