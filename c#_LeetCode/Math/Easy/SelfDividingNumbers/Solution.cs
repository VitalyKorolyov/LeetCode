using System.Collections.Generic;

namespace LeetCode.Math.Easy.SelfDividingNumbers
{
    //https://leetcode.com/problems/self-dividing-numbers/
    public class Solution
    {
        public static IList<int> SelfDividingNumbers(int left, int right)
        {
            var result = new List<int>();

            for (int i = left; i <= right; i++)
            {
                var saved = i;
                var isSd = true;

                while (saved != 0)
                {
                    var num = saved % 10;
                    if (num == 0 || i % num != 0)
                    {
                        isSd = false;
                        break;
                    }

                    saved /= 10;
                }

                if(isSd) result.Add(i);
            }

            return result;
        }
    }
}