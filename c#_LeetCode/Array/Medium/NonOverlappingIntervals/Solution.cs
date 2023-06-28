namespace LeetCode.Array.Medium.NonOverlappingIntervals;

//https://leetcode.com/problems/non-overlapping-intervals/description/
public class Solution
{
    public int EraseOverlapIntervals(int[][] intervals)
    {
        System.Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        int overlapCount = 0;
        int l = intervals[0][1];
        for (int i = 1; i < intervals.Length; i++)
        {
            if (IsOverlap(l, intervals[i]))
            {
                overlapCount++;
                l = intervals[i][1] < l ? intervals[i][1] : l;
            }
            else
                l = intervals[i][1];
        }

        return overlapCount;
    }

    private bool IsOverlap(int endOfFirst, int[] second)
    {
        return endOfFirst > second[0];
    }
}