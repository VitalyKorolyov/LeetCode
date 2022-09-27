﻿using System.Collections.Generic;

namespace LeetCode.Array.Easy.NextGreaterElementI
{
    public class Solution
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            Stack<int> stack = new();
            Dictionary<int, int> map = new();

            for (int i = 0; i < nums2.Length; i++)
            {
                while (stack.Count != 0 && nums2[i] > stack.Peek())
                    map.Add(stack.Pop(), nums2[i]);
                stack.Push(nums2[i]);
            }

            while (stack.Count != 0)
                map.Add(stack.Pop(), -1);

            int[] res = new int[nums1.Length];
            for (int i = 0; i < nums1.Length; i++)
                res[i] = map[nums1[i]];

            return res;
        }
    }
}
