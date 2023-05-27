namespace LeetCode.Array.Easy.RemoveElement;

//https://leetcode.com/problems/remove-element
public class Solution
{
    public static int RemoveElement(int[] nums, int val)
    {
        if(nums == null || nums.Length == 0) return 0;

        int indexToInsert = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
                nums[indexToInsert++] = nums[i];
        }

        return indexToInsert;
    }
}