using System.Linq;

namespace LeetCode.Array.Easy.FindPivotIndex
{
    //https://leetcode.com/problems/find-the-middle-index-in-array/
    //https://leetcode.com/problems/find-the-middle-index-in-array/
    public class Solution
    {
        public int PivotIndex(int[] nums)
        {
            var lSum = 0;
            var rSum = nums.Sum();

            for (int i = 0; i < nums.Length; i++)
            {
                rSum -= nums[i];

                if (lSum == rSum) return i;

                lSum += nums[i];
            }

            return -1;
        }
    }
}