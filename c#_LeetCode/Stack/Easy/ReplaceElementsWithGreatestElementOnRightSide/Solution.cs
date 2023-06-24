namespace LeetCode.Stack.Easy.ReplaceElementsWithGreatestElementOnRightSide;

//https://leetcode.com/problems/replace-elements-with-greatest-element-on-right-side/description/
public class Solution
{
    public int[] ReplaceElements(int[] arr)
    {
        for (int i = arr.Length - 1, max = -1; i >= 0; i--)
        {
            var current = arr[i];
            arr[i] = max;

            max = System.Math.Max(current, max);
        }

        return arr;
    }
}