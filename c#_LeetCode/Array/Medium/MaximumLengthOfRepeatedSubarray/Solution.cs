namespace LeetCode.Array.Medium.MaximumLengthOfRepeatedSubarray
{
    //https://leetcode.com/problems/maximum-length-of-repeated-subarray/description/
    public class Solution
    {
        //bottom-up dynamic programming time complexity: O(mn)
        public int FindLength(int[] nums1, int[] nums2)
        {
            int result = 0;

            int[,] memo = new int[nums1.Length + 1, nums2.Length + 1];
            for (int i = nums1.Length - 1; i >= 0; --i)
            {
                for (int j = nums2.Length - 1; j >= 0; --j)
                {
                    if (nums1[i] == nums2[j])
                    {
                        memo[i, j] = memo[i + 1, j + 1] + 1;
                        result = System.Math.Max(result, memo[i, j]);
                    }
                }
            }

            return result;
        }

        //Sliding window time complexity: O(mn)
        //public int FindLength(int[] nums1, int[] nums2)
        //{
        //    int result = 0;

        //    for (int i = 0; i < nums1.Length + nums2.Length - 1; i++)
        //    {
        //        int startA = System.Math.Max(0, nums1.Length - i - 1);
        //        int startB = System.Math.Max(0,  i - nums1.Length - 1);

        //        var currentLength = 0;
        //        for(; startA < nums1.Length && startB < nums2.Length; startA++, startB++)
        //        {
        //            currentLength = nums1[startA] == nums2[startB] ? currentLength + 1 : 0;
        //            result = System.Math.Max(result, currentLength);
        //        }
        //    }

        //    return result;
        //}
    }
}
