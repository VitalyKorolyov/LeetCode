using System.Collections.Generic;

namespace LeetCode.Stack.Easy.BaseballGame
{
    //https://leetcode.com/problems/baseball-game/
    public class Solution
    {
        public int CalPoints(string[] ops)
        {
            var res = new Stack<int>();

            for (int i = 0; i < ops.Length; i++)
            {
                if (ops[i] == "C")
                {
                    res.Pop();
                    continue;
                }

                if (ops[i] == "D")
                {
                    res.Push(res.Peek() * 2);
                    continue;
                }

                if (ops[i] == "+")
                {
                    var top = res.Pop();
                    var sum = top + res.Peek();

                    res.Push(top);
                    res.Push(sum);
                    continue;
                }

                var n = int.Parse(ops[i]);
                res.Push(n);
            }

            var totalSum = 0;
            while (res.Count > 0)
            {
                totalSum += res.Pop();
            }

            return totalSum;
        }
    }
}