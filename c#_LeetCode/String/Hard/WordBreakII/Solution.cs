using System.Collections.Generic;

namespace LeetCode.String.Hard.WordBreakII;

//https://leetcode.com/problems/word-break-ii/description/
public class Solution
{
    public IList<string> WordBreak(string s, IList<string> wordDict)
    {
        HashSet<string> words = new(wordDict);
        List<string> result = new();

        WordBreak(s, 0, words, result, string.Empty);

        return result;
    }

    private void WordBreak(string s, int i, HashSet<string> words, List<string> result, string temp)
    {
        if(i == s.Length)
        {
            result.Add(temp);
            return;
        }

        for (int j = i + 1; j <= s.Length; j++)
        {
            var sub = s.Substring(i, j - i);

            if(words.Contains(sub))
                WordBreak(s, j, words, result, temp == "" ? sub : temp + " " + sub);
        }
    }
}