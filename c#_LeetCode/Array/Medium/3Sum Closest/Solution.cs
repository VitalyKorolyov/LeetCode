using System;

namespace LeetCode.Array.Medium._3Sum_Closest
{
    //https://leetcode.com/problems/3sum-closest
    //O(n^3), can be improved to O(n^2)
    public class Solution
    {
        public static int ThreeSumClosest(int[] nums, int target)
        {
            var closestSum = nums[0] + nums[1] + nums[2];

            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    for (var k = j + 1; k < nums.Length; k++)
                    {
                        var sum = nums[i] + nums[j] + nums[k];

                        if (System.Math.Abs(target - sum) < System.Math.Abs(target - closestSum))
                            closestSum = sum;

                        if (closestSum == target) return closestSum;
                    }
                }
            }

            return closestSum;
        }
    }
}