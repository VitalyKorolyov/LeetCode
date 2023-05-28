using System.Collections.Generic;
using System.Linq;

namespace LeetCode.HashTable.Easy.WordPattern;

//https://leetcode.com/problems/word-pattern/
public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        Dictionary<char, string> letterToWord = new();
        HashSet<string> used = new();

        string[] allWords = s.Split(' ').ToArray();

        if(allWords.Length != pattern.Length) return false;

        foreach ((string word, char letter) in allWords.Zip(pattern))
        {
            if(!letterToWord.ContainsKey(letter) && used.Contains(word)) return false;

            if (letterToWord.ContainsKey(letter))
            {
                if (letterToWord[letter] != word) return false;
            }
            else
            {
                letterToWord.Add(letter, word);
                used.Add(word);
            }
        }

        return true;
    }
}
