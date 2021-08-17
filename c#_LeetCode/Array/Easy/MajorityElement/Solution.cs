namespace LeetCode.Array.Easy.MajorityElement
{
    //https://leetcode.com/problems/majority-element/
    public class Solution
    {
        public static int MajorityElement(int[] nums)
        {
            var candidate = -1;
            var count = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (count == 0)
                {
                    candidate = nums[i];
                    count++;
                }
                else
                {
                    count += nums[i] == candidate ? 1 : -1;
                }
            }

            return candidate;
        }
    }
}