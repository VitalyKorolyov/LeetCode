using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.String.Medium.SortCharactersByFrequency
{
    //https://leetcode.com/problems/sort-characters-by-frequency/
    public class Solution
    {
        public static string FrequencySort(string s)
        {
            var hash = new Dictionary<char, int>();

            foreach (var @char in s)
            {
                if (!hash.ContainsKey(@char))
                {
                    hash.Add(@char, 1);
                }
                else
                {
                    hash[@char]++;
                }
            }

            var ordered = hash.OrderByDescending(x => x.Value);

            Span<char> result = stackalloc char[s.Length];

            var index = 0;
            foreach (var (@char, value) in ordered)
            {
                for (var i = 0; i < value; i++)
                {
                    result[index++] = @char;
                }
            }

            return result.ToString();
        }
    }
}