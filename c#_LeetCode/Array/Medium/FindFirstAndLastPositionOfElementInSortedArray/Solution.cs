
namespace LeetCode.Array.Medium.FindFirstAndLastPositionOfElementInSortedArray
{
    //https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/
    public class Solution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
                return new[] { -1, -1 }; 

            var left = FindPosition(nums, target, true);
            var right = FindPosition(nums, target, false);

            return new int[] { left, right };
        }

        private int FindPosition(int[] nums, int target, bool isLeft)
        {
            var left = 0;
            var right = nums.Length - 1;
            var position = -1;

            while(left <= right)
            {
                var mid = left + (right - left) / 2;

                if (nums[mid] == target)
                {
                    position = mid;

                    if (isLeft)
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }

                    continue;
                }

                if (nums[mid] > target)
                    right = mid - 1;
                if(nums[mid] < target)
                    left = mid + 1;
            }

            return position;
        }
    }
}
