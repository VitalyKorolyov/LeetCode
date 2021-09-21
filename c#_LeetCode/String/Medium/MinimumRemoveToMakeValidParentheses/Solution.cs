using System.Collections.Generic;
using System.Text;

namespace LeetCode.String.Medium.MinimumRemoveToMakeValidParentheses
{
    //https://leetcode.com/problems/minimum-remove-to-make-valid-parentheses/
    public class Solution
    {
        public class @CharPosition
        {
            public readonly char CharType;
            public readonly int Index;

            public @CharPosition(char charType, int index)
            {
                CharType = charType;
                Index = index;
            }
        }

        public string MinRemoveToMakeValid(string s)
        {
            var stack = new Stack<@CharPosition>();

            for (int i = 0; i < s.Length; i++)
            {
                var @char = s[i];

                if (@char == ')')
                {
                    var top = stack.Count > 0 ? stack.Peek() : new CharPosition('#', 0);
                    if (top.CharType == '(')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(new CharPosition(@char, i));
                    }
                }
                if(@char == '(')
                {
                    stack.Push(new CharPosition(@char, i));
                }
            }

            if (stack.Count == 0) return s;

            var res = new StringBuilder(s);

            while (stack.Count > 0)
            {
                var itemToRemove = stack.Pop();
                res.Remove(itemToRemove.Index, 1);
            }

            return res.ToString();
        }
    }
}