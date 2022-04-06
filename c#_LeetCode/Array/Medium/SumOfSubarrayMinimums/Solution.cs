using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array.Medium.SumOfSubarrayMinimums
{
    public class Solution
    {
        //O(n^2)
        public int SumSubarrayMins(int[] arr)
        {
            int mod = (int)1e9 + 7;

            var res = 0;

            for (int start = 0; start < arr.Length; start++)
            {
                var min = arr[start];

                for (int end = start; end < arr.Length; end++)
                {
                    min = System.Math.Min(min, arr[end]);

                    res = (res + min) % mod;
                }
            }

            return res;
        }

        ////O(n^2)
        //public int SumSubarrayMins(int[] arr)
        //{
        //    int mod = (int)1e9 + 7;

        //    var res = 0;

        //    for (int start = 0; start < arr.Length; start++)
        //    {
        //        var min = arr[start];

        //        for (int end = start; end < arr.Length; end++)
        //        {
        //            min = System.Math.Min(min, arr[end]);

        //            res = (res + min) % mod;
        //        }
        //    }

        //    return res;
        //}

        ////O(n^3)
        //public int SumSubarrayMins(int[] arr)
        //{
        //    int mod = (int)1e9 + 7;

        //    var res = 0;

        //    for (int start = 0; start < arr.Length; start++)
        //    {
        //        for (int end = start; end < arr.Length; end++)
        //        {
        //            var min = int.MaxValue;
        //            for (int i = start; i <= end; i++)
        //            {
        //                min = System.Math.Min(min, arr[i]);
        //            }

        //            res = (res + min) % mod; ;
        //        }
        //    }

        //    return res;
        //}
    }
}
