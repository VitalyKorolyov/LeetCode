using System.Collections.Generic;

namespace LeetCode.Array.Medium.InsertInterval
{
    //https://leetcode.com/problems/insert-interval/
    public class Solution
    {
        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            var merged = new List<int[]>();

            int i = 0;
            for (; i < intervals.Length && intervals[i][1] < newInterval[0]; i++)
                merged.Add(intervals[i]);

            for (; i < intervals.Length && intervals[i][0] <= newInterval[1]; i++)
            {
                newInterval[0] = System.Math.Min(intervals[i][0], newInterval[0]);
                newInterval[1] = System.Math.Max(intervals[i][1], newInterval[1]);
            }

            merged.Add(newInterval);

            for (; i < intervals.Length; i++)
                merged.Add(intervals[i]);

            return merged.ToArray();
        }
    }
}
