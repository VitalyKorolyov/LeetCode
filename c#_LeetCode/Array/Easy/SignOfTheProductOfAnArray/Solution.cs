namespace LeetCode.Array.Easy.SignOfTheProductOfAnArray
{
    //https://leetcode.com/problems/sign-of-the-product-of-an-array/
    public class Solution
    {
        public int ArraySign(int[] nums)
        {
            var value = 1;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0) return 0;
                if (nums[i] < 0) value *= -1;
            }

            return value;
        }
    }
}