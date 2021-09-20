using System.Collections.Generic;

namespace LeetCode.String.Easy.ValidParentheses
{
    //https://leetcode.com/problems/valid-parentheses/
    public class Solution
    {
        private Dictionary<char, char> pairs = new Dictionary<char, char>()
        {
            {')', '('},
            {'}', '{'},
            {']', '['}
        };

        public bool IsValidStack(string s)
        {
            var stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                var @char = s[i];

                if (pairs.ContainsKey(@char))
                {
                    var top = stack.Count > 0 ? stack.Pop() : '#';

                    if (top != pairs[@char]) return false;
                }
                else
                {
                    stack.Push(s[i]);
                }
            }

            return stack.Count == 0;
        }
    }
}