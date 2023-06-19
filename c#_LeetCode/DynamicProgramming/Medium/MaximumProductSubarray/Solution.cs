namespace LeetCode.DynamicProgramming.Medium.MaximumProductSubarray;

//https://leetcode.com/problems/maximum-product-subarray/description/
public class Solution
{
    public int MaxProduct(int[] nums)
    {
        int left = 1, right = 1;
        int maxProduct = nums[0];

        for (int i = 0; i < nums.Length; i++)
        {
            left = left == 0 ? 1 : left;
            right = right == 0 ? 1 : right;

            left *= nums[i];
            right *= nums[nums.Length - 1 - i];

            maxProduct = System.Math.Max(maxProduct, System.Math.Max(left, right));
        }

        return maxProduct;
    }
}