using System;
using System.Collections.Generic;

namespace LeetCode.Array.Medium.KthLargestElementInAnArray
{
    //https://leetcode.com/problems/kth-largest-element-in-an-array/
    public class Solution
    {
        public int FindKthLargest(int[] nums, int k)
        {
            var queue = new PriorityQueue<int, int>(new Comp());

            foreach (var item in nums)
            {
                queue.Enqueue(item, item);

                if (queue.Count > k)
                    queue.Dequeue();
            }

            return queue.Dequeue();  
        }

        public class Comp : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                return x - y;
            }
        }
    }
}
