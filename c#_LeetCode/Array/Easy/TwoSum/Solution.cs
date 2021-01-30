namespace LeetCode.Array.Easy.TwoSum
{
    //https://leetcode.com/problems/two-sum/
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var i = 0;
            var result = new int[2];

            while (i < nums.Length)
            {
                for (var y = i + 1; y < nums.Length; y++)
                {
                    if (nums[i] + nums[y] == target)
                    {
                        result[0] = i;
                        result[1] = y;
                        return result;
                    }
                }
                i++;
            }

            return result;
        }
    }
}