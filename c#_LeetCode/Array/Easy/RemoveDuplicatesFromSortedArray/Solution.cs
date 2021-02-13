using System.Linq;

namespace LeetCode.Array.Easy.RemoveDuplicatesFromSortedArray
{
    public class Solution
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if (!nums.Any()) return 0;

            var index = 0;

            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[index] != nums[i])
                    nums[++index] = nums[i];
            }

            return index + 1;
        }
    }
}