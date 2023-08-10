namespace LeetCode.Array.Hard.MedianOfTwoSortedArrays;

//https://leetcode.com/problems/median-of-two-sorted-arrays/description/
public class Solution
{
    //O(n + m)
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int[] array = new int[nums1.Length + nums2.Length];

        int p1 = 0;
        int p2 = 0;
        int indexToInsert = 0;

        while(p1 < nums1.Length && p2 < nums2.Length)
        {
            if (nums1[p1] <= nums2[p2])
                array[indexToInsert++] = nums1[p1++];
            else
                array[indexToInsert++] = nums2[p2++];
        }

        while(p1 < nums1.Length)
            array[indexToInsert++] = nums1[p1++];

        while(p2 < nums2.Length)
            array[indexToInsert++] = nums2[p2++];

        if ((p1 + p2) % 2 == 1)
            return array[array.Length / 2];
        else return (array[array.Length / 2] + array[array.Length / 2 - 1]) / 2.0;
    }
}
