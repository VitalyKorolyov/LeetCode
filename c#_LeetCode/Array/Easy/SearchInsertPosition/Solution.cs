namespace LeetCode.Array.Easy.SearchInsertPosition
{
    //https://leetcode.com/problems/search-insert-position/
    public class Solution
    {
        public static int SearchInsert(int[] nums, int target)
        {
            int l = 0, r = nums.Length - 1, middle = 0;

            while (r >= l)
            {
                middle = l + (r - l) / 2;

                if (nums[middle] == target) return middle;

                if (nums[middle] < target)
                {
                    l = middle + 1;
                }
                else
                {
                    r = middle - 1;
                }
            }

            var resIndex = nums[middle] < target ? middle + 1 : middle;

            return resIndex;
        }
    }
}