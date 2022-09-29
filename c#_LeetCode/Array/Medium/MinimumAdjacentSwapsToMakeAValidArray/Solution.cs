namespace LeetCode.Array.Medium.MinimumAdjacentSwapsToMakeAValidArray
{
    //https://leetcode.com/problems/minimum-adjacent-swaps-to-make-a-valid-array/
    public class Solution
    {
        public int MinimumSwaps(int[] nums)
        {
            if(nums == null || nums.Length <= 1) return 0;

            var minIndex = 0;
            var maxIndex = 0;
            var max = nums[0];
            var min = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if(min > nums[i])
                {
                    minIndex = i;
                    min = nums[i];
                }
                if(max <= nums[i])
                {
                    maxIndex = i;
                    max = nums[i];
                }
            }

            if (max == min) return 0;

            var result = minIndex + (nums.Length - 1) - maxIndex;

            return minIndex > maxIndex ? result - 1 : result;
        }
    }
}
