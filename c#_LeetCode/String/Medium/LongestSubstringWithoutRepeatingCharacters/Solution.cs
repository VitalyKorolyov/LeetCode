using System.Collections.Generic;

namespace LeetCode.String.Medium.LongestSubstringWithoutRepeatingCharacters
{
    //https://leetcode.com/problems/longest-substring-without-repeating-characters/
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            var hash = new HashSet<char>();

            int i = 0, j = 0, max = 0;

            while (i < s.Length && j < s.Length)
            {
                if (!hash.Contains(s[j]))
                    hash.Add(s[j++]);
                else
                    hash.Remove(s[i++]);

                max = System.Math.Max(max, j - i);
            }

            return max;
        }
    }
}