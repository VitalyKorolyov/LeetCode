using System.Collections.Generic;
using System.Text;

namespace LeetCode.Stack.Hard.BasicCalculator
{
    //https://leetcode.com/problems/basic-calculator/
    public class Solution
    {
        public int Calculate(string s)
        {
            Queue<char> queue = new(s.Length);
            foreach (char c in s)
            {
                if (c == ' ') continue;
                queue.Enqueue(c);
            }

            return Calculate(queue);
        }

        private int Calculate(Queue<char> queue)
        {
            Stack<int> numbers = new();
            Stack<char> operations = new();

            while(queue.Count > 0)
            {
                var item = queue.Peek();

                if (char.IsDigit(item))
                {
                    var number = GetNumber(queue);
                    numbers.Push(number);
                    continue;
                }
                if(item == '(')
                {
                    queue.Dequeue();
                    var number = Calculate(queue);
                    numbers.Push(number);
                    continue;
                }
                if(item == ')')
                {
                    queue.Dequeue();
                    break;
                }

                operations.Push(queue.Dequeue());
            }

            int res = 0;
            while (operations.Count > 0 && numbers.Count > 0)
            {
                var first = numbers.Pop();
                res += operations.Pop() == '+' ? first : -first;
            }

            if(operations.Count > 0)
                res *= operations.Pop() == '-' ? -1 : 1;
            if(numbers.Count > 0)
                res += numbers.Pop();

            return res;
        }

        private int GetNumber(Queue<char> queue)
        {
            StringBuilder strBuilder = new();

            while (queue.Count > 0)
            {
                if (char.IsDigit(queue.Peek()))
                    strBuilder.Append(queue.Dequeue());
                else break;
            }

            return int.Parse(strBuilder.ToString());
        }
    }
}
