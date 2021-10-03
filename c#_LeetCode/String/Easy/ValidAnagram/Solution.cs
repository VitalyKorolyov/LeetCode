using System.Collections.Generic;

namespace LeetCode.String.Easy.ValidAnagram
{
    //https://leetcode.com/problems/valid-anagram/
    public class Solution
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;

            var hash = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!hash.ContainsKey(s[i]))
                {
                    hash.Add(s[i], 1);
                }
                else
                {
                    hash[s[i]]++;
                }
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (!hash.ContainsKey(t[i])) return false;
                hash[t[i]]--;
            }

            foreach (var key in hash.Keys)
            {
                if (hash[key] != 0) return false;
            }

            return true;
        }
    }
}