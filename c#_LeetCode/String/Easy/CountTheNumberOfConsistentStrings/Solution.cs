using System.Collections.Generic;
using System.Linq;

namespace LeetCode.String.Easy.CountTheNumberOfConsistentStrings
{
    //https://leetcode.com/problems/count-the-number-of-consistent-strings/
    public class Solution
    {
        public int CountConsistentStrings(string allowed, string[] words)
        {
            var res = 0;

            var hash = new HashSet<char>(26);
            for (int i = 0; i < allowed.Length; i++)
                hash.Add(allowed[i]);

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (!hash.Contains(words[i][j])) break;

                    if (j == words[i].Length - 1) res++;
                }
            }

            return res;
        }
    }
}