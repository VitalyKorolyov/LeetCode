using System.Linq;

namespace LeetCode.Array.Easy.RemoveDuplicatesFromSortedArray;

//https://leetcode.com/problems/remove-duplicates-from-sorted-array
public class Solution
{
    public static int RemoveDuplicates(int[] nums)
    {
        int indexToInsert = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
                nums[indexToInsert++] = nums[i];
        }

        return indexToInsert;
    }
}