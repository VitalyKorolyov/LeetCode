using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.String.Easy.RemoveAllAdjacentDuplicatesInString
{
    //https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string/
    public class Solution
    {
        public string RemoveDuplicates(string s)
        {
            if (s.Length == 1) return s;

            var stack = new Stack<char>();
            stack.Push(s[0]);

            for (int i = 1; i < s.Length; i++)
            {
                if (stack.Count == 0)
                {
                    stack.Push(s[i]);
                    continue;
                }

                if (stack.Peek() == s[i])
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(s[i]);
                }
            }

            var res = new StringBuilder(stack.Count);

            while (stack.Count != 0)
            {
                res.Append(stack.Pop());
            }

            for (int i = 0, j = res.Length - 1; j > i; i++, j--)
            {
                var saved = res[i];
                res[i] = res[j];
                res[j] = saved;
            }

            return res.ToString();
        }
    }
}