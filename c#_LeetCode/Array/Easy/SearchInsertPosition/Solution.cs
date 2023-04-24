namespace LeetCode.Array.Easy.SearchInsertPosition;

//https://leetcode.com/problems/search-insert-position/
public class Solution
{
    public static int SearchInsert(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] >= target)
                right = mid;
            else
                left = mid + 1;
        }

        return left;
    }
}