using System;
using System.Collections.Generic;

namespace LeetCode.Array.Medium.KthLargestElementInAnArray
{
    //https://leetcode.com/problems/kth-largest-element-in-an-array/
    public class Solution
    {
        public int FindKthLargest(int[] nums, int k)
        {
            var list = new PriorityQueue<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                list.Enqueue(nums[i], nums[i]);
            }

            for (int i = 0; i < nums.Length - k; i++)
            {
                list.Dequeue();
            }

            return list.Dequeue();  
        }
    }
}
