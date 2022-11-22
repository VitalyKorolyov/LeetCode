namespace LeetCode.Array.Medium.RotateArray
{
    //https://leetcode.com/problems/rotate-array/description/
    public class Solution
    {
        public void Rotate(int[] nums, int k)
        {
            k = k % nums.Length;

            Swap(nums, 0, nums.Length - 1);
            Swap(nums, 0, k - 1);
            Swap(nums, k, nums.Length - 1);
        }

        private void Swap(int[] arr, int start, int end)
        {
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }
    }
}
