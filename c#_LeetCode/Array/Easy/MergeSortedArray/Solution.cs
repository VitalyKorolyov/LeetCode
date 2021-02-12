namespace LeetCode.Array.Easy.MergeSortedArray
{
    //https://leetcode.com/problems/merge-sorted-array/
    public class Solution
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = m + n - 1, indexOfNums1 = m - 1, indexOfNums2 = n - 1; i > -1; i--)
            {
                if (indexOfNums1 < 0)
                    nums1[i] = nums2[indexOfNums2--];
                else if (indexOfNums2 < 0 || nums1[indexOfNums1] > nums2[indexOfNums2])
                    nums1[i] = nums1[indexOfNums1--];
                else
                    nums1[i] = nums2[indexOfNums2--];
            }
        }
    }
}