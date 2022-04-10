using System.Collections.Generic;

namespace LeetCode.Array.Medium.SumOfSubarrayMinimums
{
    //https://leetcode.com/problems/sum-of-subarray-ranges/
    public class Solution
    {
        //O(n)
        public int SumSubarrayMins(int[] arr)
        {
            var mod = 1000000007;
            int[] left = new int[arr.Length];
            int[] right = new int[arr.Length];

            var stack = new Stack<KeyValuePair<int, int>>();
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 1;
                while (stack.Count != 0 && stack.Peek().Key > arr[i])
                {
                    count = count + stack.Peek().Value;
                    stack.Pop();
                }

                stack.Push(new KeyValuePair<int, int>(arr[i], count));
                left[i] = count;
            }

            stack.Clear();

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int count = 1;
                while (stack.Count != 0 && stack.Peek().Key >= arr[i])
                {
                    count = count + stack.Peek().Value;
                    stack.Pop();
                }
                stack.Push(new KeyValuePair<int, int>(arr[i], count));
                right[i] = count;
            }

            long sum = 0;
            for (int i = 0; i < arr.Length; i++)
                sum = (sum + (long)left[i] * right[i] * arr[i]) % mod;

            return (int)sum;
        }
    }

    ////O(n^2)
    //public int SumSubarrayMins(int[] arr)
    //{
    //    int mod = (int)1e9 + 7;

    //    var res = 0;

    //    for (int start = 0; start < arr.Length; start++)
    //    {
    //        var min = arr[start];

    //        for (int end = start; end < arr.Length; end++)
    //        {
    //            min = System.Math.Min(min, arr[end]);

    //            res = (res + min) % mod;
    //        }
    //    }

    //    return res;
    //}

    ////O(n^3)
    //public int SumSubarrayMins(int[] arr)
    //{
    //    int mod = (int)1e9 + 7;

    //    var res = 0;

    //    for (int start = 0; start < arr.Length; start++)
    //    {
    //        for (int end = start; end < arr.Length; end++)
    //        {
    //            var min = int.MaxValue;
    //            for (int i = start; i <= end; i++)
    //            {
    //                min = System.Math.Min(min, arr[i]);
    //            }

    //            res = (res + min) % mod; ;
    //        }
    //    }

    //    return res;
    //}
}
