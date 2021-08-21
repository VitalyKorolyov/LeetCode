using System.Collections.Generic;

namespace LeetCode.Array.Medium.FindAllDuplicatesInAnArray
{
    //https://leetcode.com/problems/find-all-duplicates-in-an-array/
    public class Solution
    {
        public static IList<int> FindDuplicates(int[] nums)
        {
            var result = new List<int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var index = System.Math.Abs(nums[i]) - 1;

                if (nums[index] < 0)
                {
                    result.Add(System.Math.Abs(index+1));
                }
                else
                {
                    nums[index] *= -1;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = System.Math.Abs(nums[i]);
            }

            return result;
        }
    }
}