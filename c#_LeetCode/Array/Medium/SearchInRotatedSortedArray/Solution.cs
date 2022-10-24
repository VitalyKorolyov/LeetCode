namespace LeetCode.Array.Medium.SearchInRotatedSortedArray
{
    //https://leetcode.com/problems/search-in-rotated-sorted-array/
    public class Solution
    {
        public int Search(int[] nums, int target)
        {
            if (nums.Length == 0) return -1;

            var pivot = FindPivotIndex(nums);

            return FindTarget(nums, target, pivot);
        }

        private int FindTarget(int[] nums, int target, int pivot)
        {
            int left = 0;
            int right = nums.Length - 1;

            if (nums[pivot] <= target && target <= nums[nums.Length - 1])
                left = pivot;
            else
                right = pivot;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (nums[mid] == target) return mid;

                if (nums[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1;
        }

        private int FindPivotIndex(int[] nums)
        {
            int left = 0, right = nums.Length - 1;

            while (left < right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] < nums[right])
                    right = mid;
                else
                    left = mid + 1;
            }

            return left;
        }
    }
}
