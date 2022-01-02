namespace LeetCode.Array.Medium.FindTheDuplicateNumber
{
    //https://leetcode.com/problems/find-the-duplicate-number/
    public static class Solution
    {
        //Negative Marking
        public static int FindDuplicate(int[] nums)
        {
            var dup = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                var cur = nums[i];
                var index = System.Math.Abs(cur) - 1;

                if (nums[index] < 0)
                {
                    dup = System.Math.Abs(nums[index]);
                    break;
                }

                nums[index] *= -1;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = System.Math.Abs(nums[i]);
            }

            return dup;
        }
    }
}