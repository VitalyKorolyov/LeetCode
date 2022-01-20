using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Array.Medium.BuildingsWithAnOceanView
{
    //https://leetcode.com/problems/buildings-with-an-ocean-view/
    public class Solution
    {
        public int[] FindBuildings(int[] heights)
        {
            var res = new List<int>();

            var highestIndex = heights.Length - 1;
            res.Add(highestIndex);

            for (int i = heights.Length - 2; i >= 0; i--)
            {
                if(heights[i] > heights[highestIndex])
                {
                    highestIndex = i;
                    res.Add(i);
                }
            }

            return res.OrderBy(x => x).ToArray();
        }
    }
}
