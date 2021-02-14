namespace LeetCode.Array.Medium.FindMinimumInRotatedSortedArray
{
    //https://leetcode.com/problems/find-minimum-in-rotated-sorted-array
    public class Solution
    {
        public static int FindMin(int[] nums)
        {
            if (nums.Length == 1) return nums[0];

            return Min(nums, 0, nums.Length - 1);
        }

        private static int Min(int[] nums, int low, int high)
        {
            var middle = (high + low) / 2;

            if (nums[middle] > nums[middle + 1]) return nums[middle + 1];
            if (nums[middle] < nums[middle - 1]) return nums[middle];

            if (nums[middle] > nums[low])
                return Min(nums, middle + 1, high);

            return 0;
    }
}