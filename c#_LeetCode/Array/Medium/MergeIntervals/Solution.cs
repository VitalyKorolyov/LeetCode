using System;
using System.Collections.Generic;

namespace LeetCode.Array.Medium.MergeIntervals
{
    //https://leetcode.com/problems/merge-intervals/
    public class Solution
    {
        public int[][] Merge(int[][] intervals)
        {
            System.Array.Sort(intervals, (i1, i2) => i1[0].CompareTo(i2[0]));

            var merged = new List<int[]>();

            for (var i = 0; i < intervals.Length; i++)
            {
                var nextI = i;
                var merge = new[] { intervals[i][0], intervals[i][1] };

                for (var j = i + 1; j < intervals.Length; j++)
                {
                    if (IsInside(merge, intervals[j]))
                    {
                        merge[1] = merge[1] > intervals[j][1] ? merge[1] : intervals[j][1];

                        nextI = j;
                        continue;
                    }

                    break;
                }

                merged.Add(merge);

                i = nextI;
            }

            return merged.ToArray();
        }

        private bool IsInside(int[] first, int[] second)
        {
            return first[0] <= second[0] && second[0] <= first[1];
        }
    }
}