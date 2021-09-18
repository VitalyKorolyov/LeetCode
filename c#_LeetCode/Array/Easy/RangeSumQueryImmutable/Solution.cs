using System;
using System.Collections.Generic;

namespace LeetCode.Array.Easy.RangeSumQueryImmutable
{
    //https://leetcode.com/problems/range-sum-query-immutable/
    public class Solution
    {
        public class NumArray
        {
            private readonly int[] _nums;
            private readonly Dictionary<string, int> _cache = new();

            public NumArray(int[] nums)
            {
                _nums = nums;
            }

            public int SumRange(int left, int right)
            {
                var key = $"{left}{right}";

                if (_cache.ContainsKey(key))
                {
                    return _cache[key];
                }

                var res = Calc(left, right);
                _cache.Add(key, res);
                return res;
            }

            private int Calc(int left, int right)
            {
                var sum = 0;

                for (int i = left; i <= right; i++)
                    sum += _nums[i];

                return sum;
            }
        }
    }
}