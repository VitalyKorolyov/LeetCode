using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Array.Medium.InsertInterval;

//https://leetcode.com/problems/insert-interval/
public class Solution
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        int i = 0;
        List<int[]> result = new();
        int[] merge = newInterval.ToArray();

        while (i < intervals.Length && !IsOverlapping(intervals[i], newInterval))
            result.Add(intervals[i++]);

        while(i < intervals.Length && IsOverlapping(merge, intervals[i]))
        {
            merge[0] = System.Math.Min(merge[0], intervals[i][0]);
            merge[1] = System.Math.Max(merge[1], intervals[i][1]);

            i++;
        }

        result.Add(merge);

        while (i < intervals.Length)
            result.Add(intervals[i++]);

        return result.ToArray();
    }

    private bool IsOverlapping(int[] first, int[] second)
    {
        return first[1] >= second[0];
    }
}
