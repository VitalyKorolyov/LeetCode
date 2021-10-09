using System.Collections.Generic;
using System.Text;

namespace LeetCode.String.Medium.ReverseWordsInAString
{
    //https://leetcode.com/problems/reverse-words-in-a-string/
    public class Solution
    {
        public string ReverseWords(string s)
        {
            var res = new StringBuilder(s.Length);

            for (int i = s.Length - 1; i >= 0 ; i--)
            {
                if (s[i] != ' ')
                {
                    var end = i;

                    var start = 0;
                    for (int j = end; j >= 0; j--)
                    {
                        if (s[j] != ' ')
                            start = j;
                        else break;
                    }

                    for (int j = start; j <= end; j++)
                        res.Append(s[j]);

                    if (start != 0) res.Append(' ');
                    i = start;
                }
            }

            if (res[res.Length - 1] == ' ') res.Remove(res.Length - 1, 1);

            return res.ToString();
        }

    }
}