using System.Collections.Generic;
using System.Text;

namespace LeetCode.String.Medium.ReorganizeString;

//https://leetcode.com/problems/reorganize-string/description/
public class Solution
{
    private static readonly IComparer<int> comparer = 
        Comparer<int>.Create((a, b) => b - a);

    public string ReorganizeString(string s)
    {
        PriorityQueue<(char, int), int> priority = new(comparer);
        int[] count = new int[26];

        for (int i = 0; i < s.Length; i++) 
            count[s[i] - 'a']++;

        for (int i = 0; i < 26; i++)
            if (count[i] != 0)
                priority.Enqueue(((char)(i + 'a'), count[i]), count[i]);

        (char, int) prev = ('a', -1);
        StringBuilder sb = new();

        while (priority.Count > 0)
        {
            var cur = priority.Dequeue();
            if (prev.Item2 > 0) priority.Enqueue(prev, prev.Item2);

            sb.Append(cur.Item1);
            cur.Item2--;
            prev = cur;
            if (priority.Count == 0 && prev.Item2 > 0) return string.Empty;
        }

        return sb.ToString();
    }
}