using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Stack.Medium.BasicCalculatorII
{
    public class Solution
    {
        public int Calculate(string s)
        {
            var stack = new Stack<int>();
            int number = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    (number, i) = GetNumber(s, i);
                    stack.Push(number);

                    continue;
                }

                if (s[i] == '*')
                {
                    (number, i) = GetNumber(s, ++i);
                    var prev = stack.Pop();
                    stack.Push(prev * number);

                    continue;
                }
                if (s[i] == '/')
                {
                    (number, i) = GetNumber(s, ++i);
                    var prev = stack.Pop();
                    stack.Push(prev / number);

                    continue;
                }
                if (s[i] == '+')
                {
                    (number, i) = GetNumber(s, ++i);
                    stack.Push(number);

                    continue;
                }
                if (s[i] == '-')
                {
                    (number, i) = GetNumber(s, ++i);
                    stack.Push(-number);

                    continue;
                }
            }

            var res = 0;
            while(stack.Count > 0)
            {
                res += stack.Pop();
            }

            return res;
        }

        private Tuple<int, int> GetNumber(string s, int i)
        {
            var res = new StringBuilder();

            if (i < s.Length && s[i] == ' ')
            {
                while (s[i] == ' ')
                    i++;
            }

            while (i < s.Length && char.IsDigit(s[i]))
                res.Append(s[i++]);

            return Tuple.Create(int.Parse(res.ToString()), --i);
        }
    }
}
