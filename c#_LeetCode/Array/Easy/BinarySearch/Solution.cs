namespace LeetCode.Array.Easy.BinarySearch
{
    //https://leetcode.com/problems/binary-search/
    public class Solution
    {
        public static int Search(int[] nums, int target)
        {
            if (nums.Length != 0 && (nums[0] > target || nums[nums.Length - 1] < target)) return -1;

            var l = 0;
            var r = nums.Length - 1;

            while (r >= l)
            {
                var index = l + (r - l) / 2;

                if (nums[index] == target) return index;

                if (nums[index] < target)
                {
                    l = index + 1;
                }
                else
                {
                    r = index - 1;
                }
            }

            return -1;
        }
    }
}