using System;
using System.Linq;

namespace LeetCode.String.Easy.CheckIfAllCharactersHaveEqualNumberOfOccurrences
{
    //https://leetcode.com/problems/check-if-all-characters-have-equal-number-of-occurrences/
    public class Solution
    {
        public bool AreOccurrencesEqual(string s)
        {
            Span<int> c = stackalloc int[26];

            for (int i = 0; i < s.Length; i++) c[s[i] - 'a']++;

            int c1 = 0;
            for (int i = 0; i < 26; i++)
            {
                if (c[i] > 0)
                {
                    if (c1 == 0) { c1 = c[i]; continue; }
                    if (c1 != c[i]) return false;
                }
            }

            return true;
        }
    }
}