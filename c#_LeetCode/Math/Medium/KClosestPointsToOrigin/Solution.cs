using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Math.Medium.KClosestPointsToOrigin
{
    //https://leetcode.com/problems/k-closest-points-to-origin/
    public class Solution
    {
        public int[][] KClosest(int[][] points, int k)
        {
            var sortedList = new SortedList<double, List<int[]>>();
            for (var i = 0; i < points.Length; i++)
            {
                var distance = System.Math.Sqrt(System.Math.Pow(points[i][0] - 0, 2) + System.Math.Pow(points[i][1] - 0, 2)); ;
                if (sortedList.ContainsKey(distance))
                {
                    sortedList[distance].Add(points[i]);
                }
                else
                {
                    sortedList.Add(distance, new List<int[]> { points[i] });
                }
            }

            var result = new int[k][];
            var sortedValues = sortedList.Values;
            for (int i = 0; i < k; i++)
            {
                if (sortedValues[i].Count == 1)
                {
                    result[i] = sortedValues[i][0];
                }
                else
                {
                    foreach (var p in sortedValues[i])
                    {
                        result[i] = p;
                        i++;
                    }
                }
            }

            return result;
        }
    }
}
