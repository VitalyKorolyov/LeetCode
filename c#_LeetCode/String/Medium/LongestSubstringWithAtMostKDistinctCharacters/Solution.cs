using System.Collections.Generic;

namespace LeetCode.String.Medium.LongestSubstringWithAtMostKDistinctCharacters
{
    //https://leetcode.com/problems/longest-substring-with-at-most-k-distinct-characters/
    public class Solution
    {
        public int LengthOfLongestSubstringKDistinct(string s, int k)
        {
            var maxLength = 0;
            if(k == 0) return maxLength;

            var hash = new Dictionary<char, int>(k);

            int start = 0; int end = 0;

            while(start < s.Length)
            {
                if (hash.Count < k || (hash.Count == k && hash.ContainsKey(s[start])))
                {
                    if(!hash.ContainsKey(s[start]))
                        hash.Add(s[start], 1);
                    else
                        hash[s[start]]++;

                    start++;
                }
                else
                {
                    var endCharacter = s[end];
                    hash[endCharacter]--;
                    if (hash[endCharacter] == 0) hash.Remove(endCharacter);
                    end++;
                }

                maxLength = System.Math.Max(maxLength, start - end);
            }

            return maxLength;
        }
    }
}
