using System.Collections.Generic;

namespace LeetCode.Stack.Hard.NumberOfVisiblePeopleInAQueue;

//https://leetcode.com/problems/number-of-visible-people-in-a-queue/description/
public class Solution
{
    public int[] CanSeePersonsCount(int[] heights)
    {
        int[] result = new int[heights.Length];
        Stack<int> stack = new();

        for (int i = heights.Length - 1; i >= 0; i--)
        {
            while (stack.Count > 0 && stack.Peek() < heights[i])
            {
                result[i]++;
                stack.Pop();
            }

            if(stack.Count > 0 && stack.Peek() > heights[i])
                result[i]++;

            stack.Push(heights[i]);
        }

        return result;
    }
}