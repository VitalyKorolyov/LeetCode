using System.Collections.Generic;

namespace LeetCode.Array.Easy.TwoSum;

//https://leetcode.com/problems/two-sum/
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numberToIndex = new();

        for (int i = 0; i < nums.Length; i++)
        {
            int secondElement = target - nums[i];

            if(numberToIndex.ContainsKey(secondElement))
                return new int[] { numberToIndex[secondElement], i };
            else numberToIndex[nums[i]] = i;
        }

        return null;
    }
}