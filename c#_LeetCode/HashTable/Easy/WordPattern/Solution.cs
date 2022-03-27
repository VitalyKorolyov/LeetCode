using System.Collections.Generic;

namespace LeetCode.HashTable.Easy.WordPattern
{
    //https://leetcode.com/problems/word-pattern/
    public class Solution
    {
        public bool WordPattern(string pattern, string s)
        {
            Dictionary<char, string> mapChar = new();
            Dictionary<string, char> mapWord = new();
            var words = s.Split(" ");

            if (words.Length != pattern.Length) return false;

            for (int i = 0; i < words.Length; i++)
            {
                if (!mapChar.ContainsKey(pattern[i]))
                {
                    if (mapWord.ContainsKey(words[i]))
                    {
                        return false;
                    }
                    else
                    {
                        mapChar.Add(pattern[i], words[i]);
                        mapWord.Add(words[i], pattern[i]);
                    }
                }
                else
                {
                    if (mapChar[pattern[i]] != words[i]) return false;
                }
            }

            return true;
        }
    }
}
