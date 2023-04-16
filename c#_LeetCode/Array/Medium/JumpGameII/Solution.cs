using System.Collections.Generic;

namespace LeetCode.Array.Medium.JumpGameII;

public class Solution
{
    //https://leetcode.com/problems/jump-game-ii/description/
    //O(n^2)
    public int Jump(int[] nums)
    {
        Dictionary<int, int> indexToMinJump = new();
        return Jump(nums, 0, indexToMinJump);
    }

    private int Jump(int[] nums, int index, Dictionary<int, int> indexToMinJump)
    {
        if(indexToMinJump.ContainsKey(index)) return indexToMinJump[index];
        if(nums.Length - 1 <= index) return 0;

        int jump = nums[index];

        while(jump > 0)
        {
            var currentRes = Jump(nums, index + jump, indexToMinJump);
            indexToMinJump[index] = System.Math.Min(currentRes + 1, indexToMinJump.GetValueOrDefault(index, 10001));
            jump--;
        }

        return indexToMinJump.GetValueOrDefault(index, 10001);
    }
}