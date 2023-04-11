using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Stack.Hard.BasicCalculator;

//https://leetcode.com/problems/basic-calculator/
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
        int num = 0;
        char preOp = '+';

        while (queue.Count > 0)
        {
            char item = queue.Dequeue();

            if (char.IsDigit(item))
                num = num * 10 + item - '0';
            else if (item == '(')
                num = Calculate(queue);
            else
            {
                if (preOp == '+')
                    numbers.Push(num);
                else if (preOp == '-')
                    numbers.Push(-num);

                preOp = item;
                num = 0;

                if (item == ')') break;
            }
        }

        int result = 0;
        while (numbers.Count > 0)
            result += numbers.Pop();

        return result;
    }
}