using System.Collections.Generic;

namespace LeetCode.Stack.Medium.GenerateParentheses;

//https://leetcode.com/problems/generate-parentheses/description/
public class Solution
{
    public IList<string> GenerateParenthesis(int n)
    {
        List<string> result = new();
        Generate(result, string.Empty, n, 0, 0);

        return result;
    }

    private void Generate(List<string> result, string temp, int max, int open, int close)
    {
        if(temp.Length == max * 2)
        {
            result.Add(temp);
            return;
        }

        if (open < max)
            Generate(result, temp + '(', max, open + 1, close);
        if (close < open) 
            Generate(result, temp + ')', max, open, close + 1);
    }
}