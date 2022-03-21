using System.Linq;

namespace LeetCode.Array.Medium.MaximumLengthOfSubarrayWithPositiveProduct
{
    //https://leetcode.com/problems/maximum-length-of-subarray-with-positive-product/
    public class Solution
    {
        public int GetMaxLen(int[] nums)
        {
            var currentResult = 1;
            var currentLength = 0;
            var maxLength = 0;

            int[] newNums = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0) newNums[i] = nums[i];
                if (nums[i] > 0) newNums[i] = 1;
                if (nums[i] < 0) newNums[i] = -1;
            }

            nums = newNums;
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == 0)
                {
                    currentResult = 1;
                    currentLength = 0;
                    continue;
                }

                currentLength++;
                currentResult *= nums[i];

                if(currentResult > 0)
                    maxLength = System.Math.Max(maxLength, currentLength);
            }

            currentResult = 1;
            currentLength = 0;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] == 0)
                {
                    currentResult = 1;
                    currentLength = 0;
                    continue;
                }

                currentLength++;
                currentResult *= nums[i];

                if (currentResult > 0)
                    maxLength = System.Math.Max(maxLength, currentLength);
            }

            return maxLength;
        }
    }
}
