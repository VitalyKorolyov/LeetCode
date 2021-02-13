using System.Linq;

namespace LeetCode.Array.Easy.RemoveElement
{
    //https://leetcode.com/problems/remove-element
    public class Solution
    {
        public static int RemoveElement(int[] nums, int val)
        {
            if (!nums.Any()) return 0;

            var index = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val) continue;

                nums[index++] = nums[i];
            }

            return index;
        }
    }
}