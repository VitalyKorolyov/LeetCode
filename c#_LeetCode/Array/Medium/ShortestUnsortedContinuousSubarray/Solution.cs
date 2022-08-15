namespace LeetCode.Array.Medium.ShortestUnsortedContinuousSubarray
{
    //https://leetcode.com/problems/shortest-unsorted-continuous-subarray/
    public class Solution
    {
        public int FindUnsortedSubarray(int[] nums)
        {
            int min = int.MaxValue, max = int.MinValue;

            bool flag = false;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < nums[i - 1])
                    flag = true;
                if (flag)
                    min = System.Math.Min(min, nums[i]);
            }

            flag = false;
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                if (nums[i] > nums[i + 1])
                    flag = true;
                if (flag)
                    max = System.Math.Max(max, nums[i]);
            }

            int minIndex;
            for (minIndex = 0; minIndex < nums.Length; minIndex++)
            {
                if (nums[minIndex] > min)
                    break;
            }

            int maxIndex;
            for (maxIndex = nums.Length - 1; maxIndex >= 0; maxIndex--)
            {
                if (nums[maxIndex] < max)
                    break;
            }

            return maxIndex - minIndex < 0 ? 0 : maxIndex - minIndex + 1;
        }
    }
}
