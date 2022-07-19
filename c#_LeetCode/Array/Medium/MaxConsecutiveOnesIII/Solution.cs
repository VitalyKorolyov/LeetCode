
namespace LeetCode.Array.Medium.MaxConsecutiveOnesIII
{
    //https://leetcode.com/problems/max-consecutive-ones-iii/
    public class Solution
    {
        public int LongestOnes(int[] nums, int k)
        {
            int left = 0, right = 0;
            int oneCounter = 0;
            int maxLength = 0;

            while(right < nums.Length)
            {
                if (nums[right] == 1)
                    oneCounter++;

                if (right - left + 1 - oneCounter > k)
                {
                    if (nums[left] == 1)
                        oneCounter--;
                    left++;
                }

                maxLength = System.Math.Max(maxLength, right - left + 1);

                right++;
            }

            return maxLength;
        }
    }
}
