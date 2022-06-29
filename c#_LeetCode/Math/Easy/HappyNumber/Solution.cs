using System.Collections.Generic;

namespace LeetCode.Math.Easy.HappyNumber
{
    //https://leetcode.com/problems/happy-number/
    public class Solution
    {
        public bool IsHappy(int n)
        {
            int slow = n, fast = n;

            do
            {
                slow = FindSquareSum(slow);
                fast = FindSquareSum(FindSquareSum(fast));
            } while (slow != fast);

            return slow == 1;
        }

        private static int FindSquareSum(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                var value = num % 10;
                sum += value * value;
                num /= 10;
            }
            
            return sum;
        }
    }
}
