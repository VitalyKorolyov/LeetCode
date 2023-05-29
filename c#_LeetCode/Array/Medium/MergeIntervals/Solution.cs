using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Array.Medium.MergeIntervals;

//https://leetcode.com/problems/merge-intervals/
public class Solution
{
    public int[][] Merge(int[][] intervals)
    {
        System.Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        List<int[]> result = new();

        int i = 0;
        while(i < intervals.Length)
        {
            int j = i + 1;
            int[] current = intervals[i].ToArray();

            while(j < intervals.Length && IsOverlapping(current, intervals[j]))
            {
                current[0] = System.Math.Min(intervals[j][0], current[0]);
                current[1] = System.Math.Max(intervals[j][1], current[1]);

                j++;
            }

            result.Add(current);
            i = j;
        }

        return result.ToArray();
    }

    private bool IsOverlapping(int[] first, int[] second)
    {
        return first[1] >= second[0];
    }
}