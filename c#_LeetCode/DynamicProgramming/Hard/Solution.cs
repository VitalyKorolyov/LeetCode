using System.Linq;

namespace LeetCode.DynamicProgramming.Hard
{
    //https://leetcode.com/problems/trapping-rain-water/
    public class Solution
    {
        public int Trap(int[] height)
        {
            if(height == null || !height.Any()) return 0;

            int[] leftMax = new int[height.Length];
            int[] rightMax = new int[height.Length];

            leftMax[0] = height[0];
            for (int i = 1; i < height.Length; i++)
            {
                leftMax[i] = System.Math.Max(height[i], leftMax[i - 1]);
            }

            rightMax[height.Length - 1] = height[height.Length - 1];
            for (int i = height.Length - 2; i >= 0; i--)
            {
                rightMax[i] = System.Math.Max(height[i], rightMax[i + 1]);
            }

            int res = 0;
            for (int i = 1; i < height.Length - 1; i++)
            {
                res += System.Math.Min(leftMax[i], rightMax[i]) - height[i];
            }

            return res;
        }
    }
}
