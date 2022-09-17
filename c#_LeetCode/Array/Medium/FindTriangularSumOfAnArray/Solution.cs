namespace LeetCode.Array.Medium.FindTriangularSumOfAnArray
{
    //https://leetcode.com/problems/find-triangular-sum-of-an-array/
    public class Solution
    {
        public int TriangularSum(int[] nums)
        {
            if(nums == null || nums.Length == 0) return 0;
            if(nums.Length == 1) return nums[0];

            var size = nums.Length;

            while(size > 1)
            {
                for (int i = 1; i < size; i++)
                {
                    nums[i - 1] = (nums[i - 1] + nums[i]) % 10;
                }

                size--;
            }

            return nums[0];
        }
    }
}
