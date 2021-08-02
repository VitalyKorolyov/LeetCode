namespace LeetCode.Array.Medium.ProductOfArrayExceptSelf
{
    //https://leetcode.com/problems/product-of-array-except-self/
    public class Solution
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            var result = new int[nums.Length];

            result[0] = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                result[i] = result[i - 1] * nums[i - 1];
            }

            var right = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                result[i] *= right;
                right *= nums[i];
            }

            return result;
        }
    }
}