using System.Collections.Generic;

namespace LeetCode.String.Medium.WordBreak
{
    //https://leetcode.com/problems/word-break/description/
    public class Solution
    {
        public bool WordBreak(string s, IList<string> wordDict)
        {
            return Break(s, new HashSet<string>(wordDict), 0, new bool?[s.Length]);
        }

        private bool Break(string s, HashSet<string> hash, int start, bool?[] seen)
        {
            if (start >= s.Length) return true;
            if (seen[start] != null) return seen[start].Value;

            for (int i = start + 1; i <= s.Length; i++)
            {
                if (hash.Contains(s.Substring(start, i - start)))
                {
                    var result = Break(s, hash, i, seen);
                    if (result) 
                    {
                        seen[start] = result;
                        return seen[start].Value;
                    }
                }
            }

            seen[start] = false;
            return seen[start].Value;
        }
    }
}
