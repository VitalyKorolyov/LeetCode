namespace LeetCode.Array.Easy.MaximumProductDifferenceBetweenTwoPairs
{
    //https://leetcode.com/problems/maximum-product-difference-between-two-pairs/
    public class Solution
    {
        public static int MaxProductDifference(int[] nums)
        {
            var firstL = int.MinValue;
            var secondL = int.MinValue;
            var firstS = int.MaxValue;
            var secondS = int.MaxValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (firstL <= nums[i])
                {
                    secondL = firstL;
                    firstL = nums[i];
                }
                else if(secondL < nums[i])
                {
                    secondL = nums[i];
                }

                if (firstS > nums[i])
                {
                    secondS = firstS;
                    firstS = nums[i];
                }
                else if(secondS > nums[i])
                {
                    secondS = nums[i];
                }
            }

            return firstL * secondL - firstS * secondS;
        }
    }
}