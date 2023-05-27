using System.Collections.Generic;

namespace LeetCode.String.Medium.LongestSubstringWithoutRepeatingCharacters;

//https://leetcode.com/problems/longest-substring-without-repeating-characters/

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        HashSet<char> hash = new();

        int j = 0;
        int length = 0;

        for(int i = 0; i < s.Length; i++)
        {
            while (j < s.Length && !hash.Contains(s[j]))
                hash.Add(s[j++]);

            length = System.Math.Max(length, hash.Count);

            hash.Remove(s[i]);
        }

        return length;
    }
}