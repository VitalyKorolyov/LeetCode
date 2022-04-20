using System.Collections.Generic;

namespace LeetCode.String.Hard.CountUniqueCharactersOfAllSubstringsOfGivenString
{
    //https://leetcode.com/problems/count-unique-characters-of-all-substrings-of-a-given-string/
    public class Solution
    {
        public int UniqueLetterString(string s)
        {
            var left = new int[s.Length];
            var right = new int[s.Length];

            var dic = new Dictionary<char, int>();
            for (int i = 0, position = 1; i < s.Length; i++, position++) 
            {
                if (dic.ContainsKey(s[i]))
                {
                    var charPosition = dic[s[i]];
                    left[i] = position - charPosition;
                    dic[s[i]] = position;
                }
                else
                {
                    left[i] = position;
                    dic.Add(s[i], position);
                }
            }

            dic.Clear();

            for (int i = s.Length - 1, position = 1; i >= 0; i--, position++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    var charPosition = dic[s[i]];
                    right[i] = position - charPosition;
                    dic[s[i]] = position;
                }
                else
                {
                    right[i] = position;
                    dic.Add(s[i], position);
                }
            }

            var res = 0;
            for (int i = 0; i < left.Length; i++)
                res += left[i] * right[i];

            return res;
        }
    }
}
