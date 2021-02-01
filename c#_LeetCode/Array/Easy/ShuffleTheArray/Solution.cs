namespace LeetCode.Array.Easy.ShuffleTheArray
{
    public class Solution
    {
        //https://leetcode.com/problems/shuffle-the-array/
        public static int[] Shuffle(int[] nums, int n)
        {
            var result = new int[nums.Length];

            for (int i = 0, j = n, index = 0; index < nums.Length;)
            {
                result[index++] = nums[i++];
                result[index++] = nums[j++];
            }

            return result;
        }
    }
}