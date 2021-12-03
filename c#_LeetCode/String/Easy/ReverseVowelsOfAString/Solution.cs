using System;

namespace LeetCode.String.Easy.ReverseVowelsOfAString
{
    //https://leetcode.com/problems/reverse-vowels-of-a-string/
    public class Solution
    {
        public string ReverseVowels(string s)
        {
            Span<char> vowels = stackalloc char[]
            {
                'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U'
            };

            Span<char> res = stackalloc char[s.Length];
            for (int k = 0; k < s.Length; k++)
                res[k] = s[k];

            int i = 0, j = s.Length - 1;

            while (i < j)
            {
                if (vowels.IndexOf(s[i]) >= 0)
                {
                    while (j > i)
                    {
                        if (vowels.IndexOf(s[j]) >= 0)
                        {
                            res[i] = s[j];
                            res[j] = s[i];
                            j--;
                            i++;
                            break;
                        }

                        j--;
                    }
                }
                else
                {
                    i++;
                }
            }

            return res.ToString();
        }
    }
}