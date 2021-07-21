using System.Collections.Generic;

namespace LeetCode.Array.Easy.HowManyNumbersAreSmallerThanTheCurrentNumber
{
    //https://leetcode.com/problems/how-many-numbers-are-smaller-than-the-current-number/submissions/
    public class Solution
    {
        //O(n)
        public static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            var count = new int[101];
            var result = new int[nums.Length];

            for (var i = 0; i < nums.Length; i++)
                count[nums[i]]++;

            for (var i = 1; i < 101; i++)
                count[i] += count[i - 1];

            for (var i = 0; i < nums.Length; i++)
                result[i] = nums[i] != 0 ? count[nums[i] - 1] : 0;

            return result;
        }

        //O(n^2)
        public static int[] SmallerNumbersThanCurrent1(int[] nums)
        {
            var result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                var counter = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j]) counter++;
                }

                result[i] = counter;
            }

            return result;
        }
    }
}