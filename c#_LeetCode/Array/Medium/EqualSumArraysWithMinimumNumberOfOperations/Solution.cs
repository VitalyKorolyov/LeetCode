using System.Linq;

namespace LeetCode.Array.Medium.EqualSumArraysWithMinimumNumberOfOperations
{
    //https://leetcode.com/problems/equal-sum-arrays-with-minimum-number-of-operations/
    public class Solution
    {
        public int MinOperations(int[] nums1, int[] nums2)
        {
            if (nums1.Length * 6 < nums2.Length || nums1.Length > 6 * nums2.Length)
                return -1;

            var sum1 = nums1.Sum();
            var sum2 = nums2.Sum();

            if (sum1 == sum2) return 0;

            if (sum1 > sum2) return MinOperations(nums2, nums1);

            System.Array.Sort(nums1);
            System.Array.Sort(nums2);

            var minOperation = 0; 
            var i = 0;
            var j = nums2.Length - 1;

            while(sum1 < sum2)
            {
                if (j < 0 && i < nums1.Length || 6 - nums1[i] > nums2[j] - 1)
                    sum1 += 6 - nums1[i++];
                else
                    sum2 -= nums2[j--] - 1;

                minOperation++;
            }

            return minOperation;
        }
    }
}
