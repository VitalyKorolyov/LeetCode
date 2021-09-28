namespace LeetCode.DynamicProgramming.Easy.CountingBits
{
    //https://leetcode.com/problems/counting-bits/
    public class Solution
    {
        private int PopCount(int x)
        {
            int count;
            for (count = 0; x != 0; ++count)
            {
                var a = x & (x - 1);
                x &= x - 1; // zeroing out the least significant nonzero bit
            }
            return count;
        }

        public int[] CountBits(int n)
        {
            int[] ans = new int[n + 1];
            for (int x = 0; x <= n; ++x)
            {
                ans[x] = PopCount(x);
            }
            return ans;
        }
    }
}