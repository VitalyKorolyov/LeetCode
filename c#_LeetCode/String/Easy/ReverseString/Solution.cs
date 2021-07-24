namespace LeetCode.String.Easy.ReverseString
{
    //https://leetcode.com/problems/reverse-string/
    public class Solution
    {
        public static void ReverseString(char[] s)
        {
            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                var value = s[i];
                s[i] = s[j];
                s[j] = value;
            }
        }
    }
}