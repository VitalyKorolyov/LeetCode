using System.Collections.Generic;

namespace LeetCode.String.Hard.MinimumWindowSubstring
{
    //https://leetcode.com/problems/minimum-window-substring/
    public class Solution
    {
        public string MinWindow(string s, string t)
        {
            var charMap = new Dictionary<char, int>();

            foreach (char c in t)
            {
                if (charMap.ContainsKey(c))
                    charMap[c] += 1;
                else
                    charMap[c] = 1;
            }

            int j = 0, minStart = 0, minLen = -1, matchedChars = 0;
            var windowMap = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                while (j < s.Length && matchedChars < charMap.Count)
                {
                    if (charMap.ContainsKey(s[j]))
                    {
                        if (windowMap.ContainsKey(s[j]))
                            windowMap[s[j]] += 1;
                        else
                            windowMap[s[j]] = 1;

                        if (windowMap[s[j]] == charMap[s[j]])
                            matchedChars += 1;
                    }
                    j += 1;
                }

                if (matchedChars == charMap.Count)
                {
                    if (minLen == -1 || (j - i) < minLen)
                    {
                        minLen = j - i;
                        minStart = i;
                    }
                }

                if (charMap.ContainsKey(s[i]))
                {
                    windowMap[s[i]] -= 1;
                    if (windowMap[s[i]] < charMap[s[i]])
                        matchedChars -= 1;
                }
            }

            return minLen == -1 ? "" : s.Substring(minStart, minLen);
        }
    }
}
