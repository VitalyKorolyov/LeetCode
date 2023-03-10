namespace LeetCode.Array.Medium.SingleElementInASortedArray;

//https://leetcode.com/problems/single-element-in-a-sorted-array/description/
public class Solution
{
    public int SingleNonDuplicate(int[] nums)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left < right)
        {
            int pivot = left + (right - left) / 2;

            if (pivot % 2 == 1) pivot--;

            if (nums[pivot] == nums[pivot+1])
                left = pivot + 2;
            else
                right = pivot;
        }

        return nums[left];
    }
}