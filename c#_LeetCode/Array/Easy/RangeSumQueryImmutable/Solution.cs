using System;
using System.Collections.Generic;

namespace LeetCode.Array.Easy.RangeSumQueryImmutable
{
    //https://leetcode.com/problems/range-sum-query-immutable/
    public class Solution
    {
        public class NumArray
        {
            private readonly int[] _sum;

            public NumArray(int[] nums)
            {
                _sum = new int[nums.Length + 1];

                for (var i = 0; i < nums.Length; i++)
                    _sum[i + 1] = _sum[i] + nums[i];
            }

            public int SumRange(int left, int right)
            {
                return _sum[right + 1] - _sum[left];
            }
        }
    }
}