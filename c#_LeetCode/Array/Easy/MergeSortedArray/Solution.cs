namespace LeetCode.Array.Easy.MergeSortedArray;

//https://leetcode.com/problems/merge-sorted-array/
public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int indexToInsert = n + m - 1;

        while(n > 0)
        {
            if (m > 0 && nums1[m - 1] > nums2[n - 1])
            {
                nums1[indexToInsert--] = nums1[m - 1];
                m--;
            }
            else
            {
                nums1[indexToInsert--] = nums2[n - 1];
                n--;
            }
        }
    }
}