namespace LeetCode.Array.Medium.RemoveDuplicatesFromSortedArrayII;

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int duplicate = 1;
        int indexToInsert = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i - 1] == nums[i]) 
                duplicate++;
            else
            {
                indexToInsert = Insert(nums, indexToInsert, i - 1, duplicate);
                duplicate = 1;
            }
        }

        indexToInsert = Insert(nums, indexToInsert, nums.Length - 1, duplicate);

        return indexToInsert;
    }

    private int Insert(int[] nums, int indexToInsert, int prevIndex, int duplicate)
    {
        if (duplicate > 1)
        {
            nums[indexToInsert++] = nums[prevIndex];
            nums[indexToInsert++] = nums[prevIndex];
        }
        else
            nums[indexToInsert++] = nums[prevIndex];

        return indexToInsert;
    }
}