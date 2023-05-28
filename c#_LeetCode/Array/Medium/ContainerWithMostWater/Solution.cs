namespace LeetCode.Array.Medium.ContainerWithMostWater;

//https://leetcode.com/problems/container-with-most-water/
public class Solution
{
    public int MaxArea(int[] height)
    {
        int l = 0;
        int r = height.Length - 1;
        int maxAreaOfWater = 0;

        while (l < r)
        {
            var currentHeight = System.Math.Min(height[l], height[r]);
            maxAreaOfWater = System.Math.Max(maxAreaOfWater, currentHeight * (r - l));

            if (height[l] > height[r]) r--;
            else l++;
        }

        return maxAreaOfWater;
    }
}
