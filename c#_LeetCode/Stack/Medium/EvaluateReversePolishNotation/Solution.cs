using System.Collections.Generic;

namespace LeetCode.Stack.Medium.EvaluateReversePolishNotation;

//https://leetcode.com/problems/evaluate-reverse-polish-notation/description/
public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        Stack<int> stack = new();
        for (int i = 0; i < tokens.Length; i++)
        {
            if (char.IsDigit(tokens[i][0]) || tokens[i].Length > 1)
                stack.Push(int.Parse(tokens[i]));
            else
            {
                int first = stack.Pop();
                int second = stack.Pop();

                if (tokens[i] == "+")
                    stack.Push(first + second);
                if (tokens[i] == "-")
                    stack.Push(second - first);
                if (tokens[i] == "*")
                    stack.Push(first * second);
                if (tokens[i] == "/") 
                    stack.Push(second / first);
            }
        }

        return stack.Pop();
    }
}