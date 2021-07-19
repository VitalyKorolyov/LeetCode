namespace LeetCode.Array.Easy.NumberOfGoodPairs
{
    //https://leetcode.com/problems/number-of-good-pairs/
    public class Solution
    {
        public static int NumIdenticalPairs(int[] nums)
        {
            var result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j]) result++;
                }
            }

            return result;
        }
    }
}