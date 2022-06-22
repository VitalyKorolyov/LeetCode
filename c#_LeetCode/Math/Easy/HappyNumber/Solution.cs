using System.Collections.Generic;

namespace LeetCode.Math.Easy.HappyNumber
{
    //https://leetcode.com/problems/happy-number/
    public class Solution
    {
        public bool IsHappy(int n)
        {
            var hash = new HashSet<int>();

            while (!hash.Contains(n))
            {
                hash.Add(n);

                var sum = 0;
                while (n != 0)
                {
                    var value = n % 10;
                    sum += value * value;
                    n /= 10;
                }
                if (sum == 1) return true;
                n = sum;
            }

            return false;
        }
    }
}
