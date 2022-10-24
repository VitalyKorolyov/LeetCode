﻿namespace LeetCode.Array.Medium.FindMinimumInRotatedSortedArray
{
    //https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/
    public class Solution
    {
        public int FindMin(int[] nums)
        {
            int left = 0, right = nums.Length - 1;

            while (left < right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] < nums[right])
                    right = mid;
                else
                    left = mid + 1;
            }

            return nums[left];
        }
    }
}
