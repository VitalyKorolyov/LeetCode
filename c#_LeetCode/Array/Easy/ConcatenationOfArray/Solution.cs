namespace LeetCode.Array.Easy.ConcatenationOfArray
{
    //https://leetcode.com/problems/concatenation-of-array/submissions/
    public class Solution
    {
        public static int[] GetConcatenation(int[] nums)
        {
            var ans = new int[nums.Length * 2];

            for (var i = 0; i < nums.Length; i++)
            {
                ans[i] = nums[i];
                ans[nums.Length + i] = nums[i];
            }

            return ans;
        }
    }
}