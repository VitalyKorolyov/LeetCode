namespace LeetCode.Array.Medium.SortAnArray;

public class Solution
{
    public int[] SortArray(int[] nums)
    {
        int[] temporaryArray = new int[nums.Length];
        MergeSort(nums, 0, nums.Length - 1, temporaryArray);
        return nums;
    }

    private void MergeSort(int[] nums, int left, int right, int[] temp)
    {
        if (left >= right) return;

        int mid = (left + right) / 2;

        MergeSort(nums, left, mid, temp);
        MergeSort(nums, mid + 1, right, temp);

        Merge(nums, left, mid, right, temp);
    }

    private void Merge(int[] nums, int left, int mid, int right, int[] temp)
    {
        int start1 = left;
        int start2 = mid + 1;
        int n1 = mid - left + 1;
        int n2 = right - mid;

        // Copy elements of both halves into a temporary array.
        for (int r = 0; r < n1; r++)
            temp[start1 + r] = nums[start1 + r];

        for (int r = 0; r < n2; r++)
            temp[start2 + r] = nums[start2 + r];

        // Merge the sub-arrays 'in tempArray' back into the original array 'arr' in sorted order.
        int i = 0, j = 0, k = left;
        while (i < n1 && j < n2)
        {
            if (temp[start1 + i] <= temp[start2 + j])
            {
                nums[k] = temp[start1 + i];
                i += 1;
            }
            else
            {
                nums[k] = temp[start2 + j];
                j += 1;
            }
            k += 1;
        }

        // Copy remaining elements
        while (i < n1)
        {
            nums[k] = temp[start1 + i];
            i += 1;
            k += 1;
        }

        while (j < n2)
        {
            nums[k] = temp[start2 + j];
            j += 1;
            k += 1;
        }
    }

    //O(n + k)
    //public int[] CountSortArray(int[] nums)
    //{
    //    Dictionary<int, int> numToCount = new();
    //    int min = int.MaxValue;
    //    int max = int.MinValue;

    //    foreach (int num in nums)
    //    {
    //        numToCount[num] = numToCount.GetValueOrDefault(num, 0) + 1;
    //        min = System.Math.Min(min, num);
    //        max = System.Math.Max(max, num);
    //    }

    //    int p = 0;
    //    int[] result = new int[nums.Length];
    //    for (int i = min; i <= max; i++)
    //    {
    //        if (!numToCount.ContainsKey(i)) continue;

    //        while (numToCount[i] > 0)
    //        {
    //            result[p++] = i;
    //            numToCount[i] = numToCount[i] - 1;
    //        }
    //    }

    //    return result;
    //}
}