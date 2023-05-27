using System.Collections.Generic;

namespace LeetCode.String.Easy.SummaryRanges;

//https://leetcode.com/problems/summary-ranges/description
public class Solution
{
    public IList<string> SummaryRanges(int[] nums)
    {
        List<string> result = new();

        for(int i = 0; i < nums.Length; i++)
        {
            int start = nums[i];

            while (i + 1 < nums.Length && nums[i + 1] == nums[i] + 1)
                i++;

            if (nums[i] == start)
                result.Add($"{start}");
            else
                result.Add($"{start}->{nums[i]}");
        }

        return result;
    }
}