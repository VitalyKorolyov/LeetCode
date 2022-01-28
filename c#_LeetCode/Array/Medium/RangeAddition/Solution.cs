using System;

namespace LeetCode.Array.Medium.RangeAddition
{
    //https://leetcode.com/problems/range-addition/
    public class Solution
    {
        public int[] GetModifiedArray(int length, int[][] updates)
        {
            int[] arr = new int[length];
            if (length == 0) return arr;

            Span<int> difference = stackalloc int[length + 1];
            foreach (int[] update in updates)
            {
                difference[update[0]] += update[2];
                difference[update[1] + 1] -= update[2];
            }

            arr[0] = difference[0];

            for (int i = 1; i < length; i++)
            {
                difference[i] = difference[i] + difference[i - 1];//Prefix sum of difference array
                arr[i] = difference[i];
            }

            return arr;
        }
    }
}
