using System.Collections.Generic;

namespace LeetCode.Array.Medium.KthLargestElementInAnArray;

//https://leetcode.com/problems/kth-largest-element-in-an-array/
public class Solution
{
    public int FindKthLargest(int[] nums, int k)
    {
        PriorityQueue<int, int> priorityQueue = new();

        for (int i = 0; i < nums.Length; i++)
        {
            priorityQueue.Enqueue(nums[i], nums[i]);

            if (priorityQueue.Count > k)
                priorityQueue.Dequeue();
        }

        return priorityQueue.Dequeue();
    }
}