
namespace LeetCode.Array.Hard.FirstMissingPositive
{
    //https://leetcode.com/problems/first-missing-positive/
    public class Solution
    {
        public int FirstMissingPositive(int[] nums)
        {
            int i = 0;
            while (i < nums.Length)
            {
                int j = nums[i] - 1;

                if (nums[i] > nums.Length || nums[i] <= 0 || nums[i] == nums[j])
                    i++;
                else
                    Swap(nums, i, j);
            }

            int first = 1;
            for (int k = 0; k < nums.Length; k++)
            {
                if (nums[k] != first) break;
                first++;
            }

            return first;
        }

        private void Swap(int[] nums, int i, int j)
        {
            var saved = nums[i];
            nums[i] = nums[j];
            nums[j] = saved;
        }
    }
}
