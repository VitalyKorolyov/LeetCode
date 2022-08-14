using System.Collections.Generic;

namespace LeetCode.String.Easy.PalindromePermutation
{
    //https://leetcode.com/problems/palindrome-permutation/
    public class Solution
    {
        public bool CanPermutePalindrome(string s)
        {
            var hash = new HashSet<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if(hash.Contains(s[i]))
                    hash.Remove(s[i]);
                else
                    hash.Add(s[i]);
            }

            return s.Length % 2 == 0 ? hash.Count == 0 : hash.Count == 1;
        }
    }
}
