using System.Collections.Generic;

namespace LeetCode.String.Medium.LongestSubstringWithoutRepeatingCharacters
{
    //https://leetcode.com/problems/longest-substring-without-repeating-characters/
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            var length = s.Length;
            var hash = new HashSet<char>(128);

            int i = 0;
            int j = 0;

            while (i < length && j < length)
            {
                if (!hash.Contains(s[j]))
                {
                    hash.Add(s[j++]);
                }
                else
                {
                    hash.Remove(s[i++]);
                }
            }

            return hash.Count;
        }
    }
}