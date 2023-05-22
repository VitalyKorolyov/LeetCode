namespace LeetCode.Array.Easy.MajorityElement;

//https://leetcode.com/problems/majority-element/
public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int majorityElement = nums[0];
        int count = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != majorityElement)
            {
                count--;
                if (count == 0)
                {
                    majorityElement = nums[i];
                    count = 1;
                }
            }
            else
                count++;
        }


        return majorityElement;
    }
}