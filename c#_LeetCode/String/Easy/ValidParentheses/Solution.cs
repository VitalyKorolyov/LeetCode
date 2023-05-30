using System.Collections.Generic;

namespace LeetCode.String.Easy.ValidParentheses;

//https://leetcode.com/problems/valid-parentheses/
public class Solution
{
    private readonly Dictionary<char, char> hashMap = new()
    {
        {')', '('},
        {']', '['},
        {'}', '{'}
    };

    public bool IsValid(string s)
    {
        Stack<char> stack = new();

        for(int i = 0; i < s.Length; i++)
        {
            if (hashMap.ContainsKey(s[i]))
            {
                if (stack.Count == 0) return false;

                if(hashMap.ContainsKey(s[i]) && hashMap[s[i]] != stack.Pop()) 
                    return false;
            }
            else stack.Push(s[i]);
        }

        return stack.Count == 0;
    }
}