namespace LeetCode.String.Easy.MaximumNestingDepthOfTheParentheses
{
    //https://leetcode.com/problems/maximum-nesting-depth-of-the-parentheses/
    public class Solution
    {
        public int MaxDepth(string s)
        {
            var max = 0;
            var current = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                    current++;

                if (s[i] == ')')
                {
                    max = System.Math.Max(current, max);
                    current--;
                }
            }

            return max;
        }
    }
}