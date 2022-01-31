using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.String.Hard.ConcatenatedWords
{
    //https://leetcode.com/problems/concatenated-words/
    public class Solution
    {
        public IList<string> FindAllConcatenatedWordsInADict(string[] words)
        {
            System.Array.Sort(words, (x, y) => x.Length.CompareTo(y.Length));

            var subWords = new HashSet<string>();

            var result = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                if (IsConcatenated(words[i], subWords))
                {
                    result.Add(words[i]);
                }
                subWords.Add(words[i]);
            }

            return result;
        }

        private bool IsConcatenated(string s, HashSet<string> wordDictSet)
        {
            if (!wordDictSet.Any()) return false;

            Span<bool> dp = stackalloc bool[s.Length + 1];
            dp[0] = true;

            for (int i = 1; i <= s.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (dp[j] && wordDictSet.Contains(s.Substring(j, i - j)))
                    {
                        dp[i] = true;
                        break;
                    }
                }
            }

            return dp[s.Length];
        }
    }
}
