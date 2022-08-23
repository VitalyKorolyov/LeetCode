namespace LeetCode.Array.Easy.MissingNumber
{
    //https://leetcode.com/problems/missing-number/
    public class Solution
    {
        public static int MissingNumber(int[] nums)
        {
            int n = nums.Length + 1;

            int x1 = 1;
            for (int i = 2; i <= n; i++)
                x1 = x1 ^ i;

            int x2 = nums[0];
            for (int i = 1; i < nums.Length; i++)
                x2 = x2 ^ nums[i];

            var res = x1 ^ x2;

            return res;
        }

        //public static int MissingNumber(int[] nums)
        //{
        //    var expectedSum = nums.Length * (nums.Length + 1) / 2;

        //    var currentSum = 0;
        //    for (int i = 0; i < nums.Length; i++)
        //        currentSum += nums[i];

        //    return expectedSum - currentSum;
        //}
    }
}