using System.Collections.Generic;

namespace LeetCode.Stack.Medium.BasicCalculatorII
{
    //https://leetcode.com/problems/basic-calculator-ii/
    public class Solution
    {
        public int Calculate(string s)
        {
            Queue<char> queue = new(s.Length);
            foreach(char c in s)
            {
                if (c == ' ') continue;
                queue.Enqueue(c);
            }

            return Calc(queue);
        }

        private int Calc(Queue<char> queue)
        {
            Stack<int> stack = new();

            while(queue.Count > 0)
            {
                var item = queue.Peek();
                if(char.IsDigit(item))
                {
                    var number = GetNumber(queue);
                    stack.Push(number);
                    continue;
                }

                queue.Dequeue();

                if (item == '-' || item == '+')
                {
                    var number = GetNumber(queue);
                    stack.Push(item == '-' ? -number : number);
                }

                if(item == '*' || item == '/')
                {
                    var first = stack.Pop();
                    var second = GetNumber(queue);
                    stack.Push(item == '*' ? first * second : first / second);
                }
            }

            int res = 0;
            while(stack.Count > 0)
                res += stack.Pop();

            return res;
        }

        private int GetNumber(Queue<char> queue)
        {
            var number = 0;
            while(queue.Count > 0)
            {
                if (char.IsDigit(queue.Peek()))
                    number = 10 * number + queue.Dequeue() - '0';
                else break;
            }

            return number;
        }
    }
}
