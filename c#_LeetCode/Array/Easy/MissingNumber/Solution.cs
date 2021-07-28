namespace LeetCode.Array.Easy.MissingNumber
{
    //https://leetcode.com/problems/missing-number/
    public class Solution
    {
        public static int MissingNumber(int[] nums)
        {
            var expectedSum = nums.Length * (nums.Length + 1) / 2;

            var currentSum = 0;
            for (int i = 0; i < nums.Length; i++)
                currentSum += nums[i];

            return expectedSum - currentSum;
        }
    }
}