using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Array.Easy.IntersectionOfTwoArrays
{
    //https://leetcode.com/problems/intersection-of-two-arrays/
    public class Solution
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            var hash = new HashSet<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                if (!hash.Contains(nums1[i]))
                {
                    hash.Add(nums1[i]);
                }
            }

            var res = new HashSet<int>();
            for (int i = 0; i < nums2.Length; i++)
            {
                if (hash.Contains(nums2[i]) && !res.Contains(nums2[i]))
                {
                    res.Add(nums2[i]);
                }
            }

            return res.ToArray();
        }
    }
}