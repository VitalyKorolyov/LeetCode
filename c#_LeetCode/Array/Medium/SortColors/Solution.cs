namespace LeetCode.Array.Medium.SortColors
{
    public class Solution
    {
        public void SortColors(int[] nums)
        {
            var left = 0;
            var right = nums.Length - 1;

            for (int i = 0; i <= right;)
            {
                if(nums[i] == 0)
                {
                    Swap(nums, i, left);
                    left++;
                    i++;
                }
                else if (nums[i] == 1)
                {
                    i++;
                }
                else if(nums[i] == 2)
                {
                    Swap(nums, i, right);
                    right--;
                }
            }
        }

        private void Swap(int[] nums, int i, int j)
        {
            var saved = nums[j];
            nums[j] = nums[i];
            nums[i] = saved;
        }
    }
}
