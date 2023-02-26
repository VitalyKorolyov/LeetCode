using System.Collections.Generic;

namespace LeetCode.Array.Easy.TwoOutOfThree;

public class Solution
{
    public IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3)
    {
        HashSet<int> allNumbers = new();

        for (int i = 0; i < nums1.Length; i++)
            allNumbers.Add(nums1[i]);

        for (int i = 0; i < nums2.Length; i++)
            allNumbers.Add(nums2[i]);

        for (int i = 0; i < nums3.Length; i++)
            allNumbers.Add(nums3[i]);

        HashSet<int> set1 = new (nums1);
        HashSet<int> set2 = new (nums2);
        HashSet<int> set3 = new (nums3);

        List<int> result = new();
        foreach (var num in allNumbers)
        {
            if(set1.Contains(num) && set2.Contains(num) || set1.Contains(num) && set3.Contains(num) ||
                set2.Contains(num) && set3.Contains(num))
                result.Add(num);
        }

        return result;
    }
}