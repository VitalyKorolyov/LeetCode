namespace LeetCode.Array.Medium.FrequencyOfTheMostFrequentElement;

//https://leetcode.com/problems/frequency-of-the-most-frequent-element/description/
public class Solution
{
    public int MaxFrequency(int[] nums, int k)
    {
        System.Array.Sort(nums);

        int answer = 1;
        int l = 0;
        int r = 1;

        while(r < nums.Length)
        {
            int currentDiff = (nums[r] - nums[r - 1]) * (r - l);

            if (currentDiff <= k)
            {
                k -= currentDiff;
                r++;
                answer = System.Math.Max(answer, r - l);
            }
            else
            {
                var moveDiff = nums[r - 1] - nums[l];
                k += moveDiff;
                l++;
            }
        }

        return answer;
    }
}
