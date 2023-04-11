using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Stack.Medium.BasicCalculatorII;

//https://leetcode.com/problems/basic-calculator-ii/
public class Solution
{
    public int Calculate(string s)
    {
        Queue<char> queue = new(s.Length);

        foreach (char c in s.Where(x => x != ' '))
            queue.Enqueue(c);

        queue.Enqueue('+');
        return Calculate(queue);
    }

    private int Calculate(Queue<char> queue)
    {
        Stack<int> numbers = new();
        char preOp = '+';
        int num = 0;

        while (queue.Count > 0)
        {
            var item = queue.Dequeue();

            if (char.IsDigit(item))
                num = num * 10 + item - '0';
            else
            {
                if (preOp == '+')
                    numbers.Push(num);
                if (preOp == '-')
                    numbers.Push(-num);
                if (preOp == '*')
                    numbers.Push(numbers.Pop() * num);
                if (preOp == '/')
                    numbers.Push(numbers.Pop() / num);

                num = 0;
                preOp = item;
            }
        }

        int res = 0;
        while (numbers.Count > 0)
            res += numbers.Pop();

        return res;
    }
}