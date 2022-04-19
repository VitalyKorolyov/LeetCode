using System.Collections.Generic;
using System.Linq;

namespace LeetCode.String.Medium.MinimumAddToMakeParenthesesValid
{
    //https://leetcode.com/problems/minimum-add-to-make-parentheses-valid/
    public class Solution
    {
        public int MinAddToMakeValid(string s)
        {
            var stack = new Stack<int>();

            for (int i = 0; i < s.Length; i++)
            {
                if(!stack.Any())
                {
                    stack.Push(s[i]);
                    continue;
                }

                if(s[i] == ')' && stack.Peek() == '(')
                {
                    stack.Pop();
                    continue;
                }

                stack.Push(s[i]);
            }

            return stack.Count;
        }
    }
}
