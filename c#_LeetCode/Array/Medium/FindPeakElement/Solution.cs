namespace LeetCode.Array.Medium.FindPeakElement
{
    //https://leetcode.com/problems/find-peak-element/
    public class Solution
    {
        public static int FindPeakElement(int[] nums)
        {
            var indexResult = 0;

            for (var i = 1; i < nums.Length; i++)
                if (nums[i] > nums[indexResult])
                    indexResult = i;

            return indexResult;
        }
    }
}