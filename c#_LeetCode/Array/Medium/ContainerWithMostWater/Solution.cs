namespace LeetCode.Array.Medium.ContainerWithMostWater
{
    //https://leetcode.com/problems/container-with-most-water/
    public class Solution
    {
        public int MaxArea(int[] height)
        {
            var left = 0;
            var right = height.Length - 1;
            var maxArea = int.MinValue;

            while (left != right)
            {
                var area = System.Math.Min(height[right], height[left]) * (right - left);
                maxArea = System.Math.Max(area, maxArea);

                if (height[left] > height[right]) right--;
                else left++;
            }

            return maxArea;
        }
    }
}
