using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Array.Easy.SingleNumber
{
    //https://leetcode.com/problems/single-number/
    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            int num = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                num = num ^ nums[i];
            }

            return num;
        }

        //public int SingleNumber(int[] nums)
        //{
        //    var singleStore = new HashSet<int>();

        //    foreach (var num in nums)
        //    {
        //        if (!singleStore.Contains(num))
        //        {
        //            singleStore.Add(num);
        //        }
        //        else
        //        {
        //            singleStore.Remove(num);
        //        }
        //    }

        //    return singleStore.First();
        //}
    }
}