using System.Text;

namespace LeetCode.String.Easy.ReverseWordsInAStringIII
{
    //https://leetcode.com/problems/reverse-words-in-a-string-iii/
    public class Solution
    {
        public static string ReverseWords(string s)
        {
            var rSpaceIndex = 0;
            var res = new StringBuilder(s.Length);

            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ' || s.Length - 1 == i)
                {
                    var lSpaceIndex = rSpaceIndex;
                    rSpaceIndex = i;

                    for (int j = rSpaceIndex; j >= lSpaceIndex; j--)
                    {
                        if(s[j] == ' ') continue;

                        res.Append(s[j]);
                    }

                    if (s.Length - 1 != i) res.Append(' ');
                }
            }

            return res.ToString();
        }
    }
}