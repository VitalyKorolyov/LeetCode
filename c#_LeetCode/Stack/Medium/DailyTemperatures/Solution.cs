using System.Collections.Generic;

namespace LeetCode.Stack.Medium.DailyTemperatures
{
    //https://leetcode.com/problems/daily-temperatures/
    public class TemperatureInfo
    {
        public int Value { get; set; }
        public int Index { get; set; }
    }

    public class Solution
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            var res = new int[temperatures.Length];
            var stack = new Stack<TemperatureInfo>();

            for (int i = temperatures.Length - 1; i >= 0; i--)
            {
                while (stack.Count > 0)
                {
                    var info = stack.Peek();
                    if(info.Value <= temperatures[i])
                    {
                        stack.Pop();
                        continue;
                    }
                    else
                    {
                        res[i] = info.Index - i;
                        stack.Push(new TemperatureInfo { Index = i, Value = temperatures[i] });
                        break;
                    }
                }

                if (stack.Count == 0)
                {
                    stack.Push(new TemperatureInfo { Index = i, Value = temperatures[i] });
                    res[i] = 0;
                }
            }

            return res;
        }
    }
}
