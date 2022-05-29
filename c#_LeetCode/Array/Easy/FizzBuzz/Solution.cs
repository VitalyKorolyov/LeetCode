using System.Collections.Generic;

namespace LeetCode.Array.Easy.FizzBuzz
{
    //https://leetcode.com/problems/fizz-buzz/
    public class Solution
    {
        public IList<string> FizzBuzz(int n)
        {
            var res = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    res.Add("FizzBuzz");
                    continue;
                }
                if(i % 3 == 0)
                {
                    res.Add("Fizz");
                    continue;
                }
                if(i % 5 == 0)
                {
                    res.Add("Buzz");
                    continue;
                }

                res.Add(i.ToString());
            }

            return res;
        }
    }
}
