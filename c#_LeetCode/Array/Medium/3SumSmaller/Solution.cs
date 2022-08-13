namespace LeetCode.Array.Medium._3SumSmaller
{
    //https://leetcode.com/problems/3sum-smaller/
    public class Solution
    {
        public int ThreeSumSmaller(int[] nums, int target)
        {
            System.Array.Sort(nums);

            var counter = 0;
            for (int i = 0; i < nums.Length - 2; i++)
            {
                counter += Search(nums, i + 1, target - nums[i]);
            }

            return counter;
        }

        private int Search(int[] nums, int left, int target)
        {
            var counter = 0;
            var right = nums.Length - 1;

            while(left < right)
            {
                if (nums[left] + nums[right] < target)
                {
                    counter += right - left;
                    left++;
                }
                else
                    right--;
            }

            return counter;
        }
    }
}
