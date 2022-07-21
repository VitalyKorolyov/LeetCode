using System.Collections.Generic;

namespace LeetCode.String.Medium.FindAllAnagramsInAString
{
    //https://leetcode.com/problems/find-all-anagrams-in-a-string/
    public class Solution
    {
        public IList<int> FindAnagrams(string s, string p)
        {
            var freqS = new int[26];
            var freqP = new int[26];
            var result = new List<int>();

            for (int i = 0; i < p.Length; i++)
                freqP[p[i] - 'a']++;

            int start = 0;
            for (int end = 0; end < s.Length; end++)
            {
                if(end >= p.Length)
                {
                    if (IsAnagram(freqS, freqP))
                        result.Add(start);

                    freqS[s[start] - 'a']--;
                    start++;
                }

                freqS[s[end] - 'a']++;
            }

            if (IsAnagram(freqS, freqP))
                result.Add(start);

            return result;
        }

        private bool IsAnagram(int[] freqS, int[] freqP)
        {
            for (int i = 0; i < freqP.Length; i++)
                if (freqP[i] != freqS[i]) return false;

            return true;
        }
    }
}
