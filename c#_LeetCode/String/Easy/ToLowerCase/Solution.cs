using System;

namespace LeetCode.String.Easy.ToLowerCase
{
    //https://leetcode.com/problems/to-lower-case/
    public class Solution
    {
        public string ToLowerCase(string str)
        {
            Span<char> lowerCaseStr = stackalloc char[str.Length];

            for (var i = 0; i < str.Length; i++)
            {
                if (str[i] < 97 && str[i] > 64)
                {
                    lowerCaseStr[i] = (char)(str[i] + 32);
                }
                else
                {
                    lowerCaseStr[i] += str[i];
                }
            }

            return lowerCaseStr.ToString();
        }
    }
}