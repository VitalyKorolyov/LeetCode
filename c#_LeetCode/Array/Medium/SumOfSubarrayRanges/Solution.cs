namespace LeetCode.Array.Medium.SumOfSubarrayRanges
{
    //https://leetcode.com/problems/sum-of-subarray-ranges/
    public class Solution
    {
        //O(n^2)
        public long SubArrayRanges(int[] nums)
        {
            long res = 0;

            for (int start = 0; start < nums.Length; start++)
            {
                var min = int.MaxValue;
                var max = int.MinValue;

                for (int end = start; end < nums.Length; end++)
                {
                    min = System.Math.Min(min, nums[end]);
                    max = System.Math.Max(max, nums[end]);

                    res += max - min;
                }
            }

            return res;
        }
    }
}
