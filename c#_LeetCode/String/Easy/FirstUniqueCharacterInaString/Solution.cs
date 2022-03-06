using System;

namespace LeetCode.String.Easy.FirstUniqueCharacterInaString
{
    //https://leetcode.com/problems/first-unique-character-in-a-string/
    public class Solution
    {
        public int FirstUniqChar(string s)
        {
            Span<int> letters = stackalloc int[26];

            for (int i = 0; i < s.Length; i++)
                letters[s[i] - 'a'] += 1;

            for (int i = 0; i < s.Length; i++)
                if (letters[s[i] - 'a'] == 1) return i;

            return -1;
        }
    }
}
