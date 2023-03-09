namespace LeetCode.Array.Easy.ShortestWordDistance;

//https://leetcode.com/problems/shortest-word-distance/description/
public class Solution
{
    public int ShortestDistance(string[] wordsDict, string word1, string word2)
    {
        int? first = null;
        int? second = null;
        int min = int.MaxValue;

        for (int i = 0; i < wordsDict.Length; i++)
        {
            var key = wordsDict[i];
            if (word1 != key && word2 != key) continue;

            if(key == word1)
                first = i;
            else if(key == word2)
                second = i;

            if (first != null && second != null)
                min = System.Math.Min(min, System.Math.Abs(first.Value - second.Value));
        }

        return min;
    }

    //public int ShortestDistance(string[] wordsDict, string word1, string word2)
    //{
    //    Dictionary<string, List<int>> wordToPositions = new();
    //    for (int i = 0; i < wordsDict.Length; i++)
    //    {
    //        var key = wordsDict[i];

    //        if (word1 != key && word2 != key) continue;

    //        if (!wordToPositions.ContainsKey(key))
    //            wordToPositions.Add(key, new List<int>());

    //        wordToPositions[key].Add(i);
    //    }

    //    int min = int.MaxValue;
    //    foreach (var word1Length in wordToPositions[word1])
    //        foreach (var word2Length in wordToPositions[word2])
    //            min = System.Math.Min(min, System.Math.Abs(word1Length - word2Length));

    //    return min;
    //}
}