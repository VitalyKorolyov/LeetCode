using System.Collections.Generic;

namespace LeetCode.Array.Medium.IntervalListIntersections
{
    //https://leetcode.com/problems/interval-list-intersections/
    public class Solution
    {
        public int[][] IntervalIntersection(int[][] firstList, int[][] secondList)
        {
            List<int[]> res = new();
            int i = 0, j = 0;

            while(i < firstList.Length && j < secondList.Length)
            {
                if ((firstList[i][0] >= secondList[j][0] && firstList[i][0] <= secondList[j][1])
                    || (secondList[j][0] >= firstList[i][0] && secondList[j][0] <= firstList[i][1]))
                {
                    var left = System.Math.Max(firstList[i][0], secondList[j][0]);
                    var right = System.Math.Min(firstList[i][1], secondList[j][1]);

                    res.Add(new[] { left, right });
                }

                if (firstList[i][1] < secondList[j][1]) i++;
                else j++;
            }

            return res.ToArray();
        }
    }
}
