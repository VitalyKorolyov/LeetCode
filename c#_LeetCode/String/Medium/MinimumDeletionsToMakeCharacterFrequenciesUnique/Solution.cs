using System.Collections.Generic;

namespace LeetCode.String.Medium.MinimumDeletionsToMakeCharacterFrequenciesUnique
{
    //https://leetcode.com/problems/minimum-deletions-to-make-character-frequencies-unique/
    public class Solution
    {
        public int MinDeletions(string s)
        {
            var array = new int[26];

            for (var i = 0; i < s.Length; i++)
                array[s[i] - 'a']++;

            var hash = new HashSet<int>(26);
            var res = 0;

            for (int i = 0; i < array.Length; i++)
            {
                while (array[i] > 0 && hash.Contains(array[i]))
                {
                    --array[i];
                    ++res;
                }

                hash.Add(array[i]);
            }

            return res;
        }
    }
}