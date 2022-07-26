using System.Collections.Generic;

namespace LeetCode.Array.Medium.FindAllDuplicatesInAnArray
{
    //https://leetcode.com/problems/find-all-duplicates-in-an-array/
    public class Solution
    {
        public IList<int> FindDuplicates(int[] nums)
        {
            int i = 0;
            while (i < nums.Length)
            {
                int j = nums[i] - 1;
                if (nums[i] != nums[j])
                    Swap(nums, i, j);
                else i++;
            }


            List<int> result = new();
            for (int k = 0; k < nums.Length; k++)
            {
                if(nums[k] != k + 1)
                    result.Add(nums[k]);
            }

            return result;
        }

        private void Swap(int[] nums, int i, int j)
        {
            var saved = nums[i];
            nums[i] = nums[j];
            nums[j] = saved;
        }

        //negative approuch
        //public static IList<int> FindDuplicates(int[] nums)
        //{
        //    var result = new List<int>();

        //    for (var i = 0; i < nums.Length; i++)
        //    {
        //        var index = System.Math.Abs(nums[i]) - 1;

        //        if (nums[index] < 0)
        //        {
        //            result.Add(System.Math.Abs(index+1));
        //        }
        //        else
        //        {
        //            nums[index] *= -1;
        //        }
        //    }

        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        nums[i] = System.Math.Abs(nums[i]);
        //    }

        //    return result;
        //}
    }
}