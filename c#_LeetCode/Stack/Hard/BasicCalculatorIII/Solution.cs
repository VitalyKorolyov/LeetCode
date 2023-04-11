using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Stack.Hard.BasicCalculatorIII;

//https://leetcode.com/problems/basic-calculator-iii/description/
public class Solution
{
    public int Calculate(string s)
    {
        Queue<char> queue = new();

        foreach (var item in s.Where(x => x != ' '))
            queue.Enqueue(item);

        queue.Enqueue('+');

        return Calculate(queue);
    }

    private int Calculate(Queue<char> queue)
    {
        char preOp = '+';
        int number = 0;
        Stack<int> numbers = new();

        while (queue.Count > 0)
        {
            char item = queue.Dequeue();

            if (char.IsDigit(item))
                number = 10 * number + item - '0';
            else if (item == '(')
                number = Calculate(queue);
            else
            {
                if (preOp == '+')
                    numbers.Push(number);
                if (preOp == '-')
                    numbers.Push(-number);
                if (preOp == '*')
                    numbers.Push(numbers.Pop() * number);
                if (preOp == '/')
                    numbers.Push(numbers.Pop() / number);

                number = 0;
                preOp = item;

                if (item == ')') break;
            }
        }

        int result = 0;
        while (numbers.Count > 0)
            result += numbers.Pop();
       
        return result;
    }
}
