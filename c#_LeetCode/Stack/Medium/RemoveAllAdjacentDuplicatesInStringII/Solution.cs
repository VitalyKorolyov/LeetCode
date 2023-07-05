using System.Collections.Generic;
using System.Text;

namespace LeetCode.Stack.Medium.RemoveAllAdjacentDuplicatesInStringII;

//https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string-ii/description/
public class Solution
{
    public string RemoveDuplicates(string s, int k)
    {
        Stack<(char letter, int count)> stack = new();

        int count = 1;
        foreach (char currentLetter in s)
        {
            if (stack.Count > 0)
            {
                var item = stack.Peek();

                if (item.letter == currentLetter)
                {
                    if(item.count == k - 1)
                    {
                        while(stack.Count > 0 && stack.Peek().letter == currentLetter)
                            stack.Pop();

                        count = 1;
                        continue;
                    }
                    else
                        count = item.count + 1;
                }
                else
                    count = 1;
            }
            
            stack.Push((currentLetter, count++));
        }

        StringBuilder answer = new();

        while(stack.Count > 0)
            answer.Append(stack.Pop().letter);

        int left = 0;
        int right = answer.Length - 1;
        while (left < right)
        {
            char saved = answer[left];
            answer[left++] = answer[right];
            answer[right--] = saved;
        }

        return answer.ToString();
    }
}