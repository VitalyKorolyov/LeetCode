using System.Collections.Generic;
using System.Text;

namespace LeetCode.String.Medium.DecodeString
{
    //https://leetcode.com/problems/decode-string/
    public class Solution
    {
        private HashSet<char> numbers = new HashSet<char>{
            '0',
            '1',
            '2',
            '3',
            '4',
            '5',
            '6',
            '7',
            '8',
            '9'};

        public string DecodeString(string s)
        {
            var res = Dec(s, 0, 1);

            return res.Item1.ToString();
        }

        private (StringBuilder, int) Dec(string s, int index, int repeat)
        {
            var res = new StringBuilder();

            for (int i = index; i < s.Length; i++)
            {
                if (s[i] == ']')
                {
                    index = i;
                    break;
                }

                if (numbers.Contains(s[i]))
                {
                    var (newRepeat, length) = GetRepeat(s, i);
                    i += length + 1;
                    var (dec, lastIndex) = Dec(s, i, newRepeat);
                    res.Append(dec);
                    i = lastIndex;
                }
                else
                    res.Append(s[i]);
            }

            var temp = res.ToString();
            for (int j = 1; j < repeat; j++)
            {
                res.Append(temp);
            }

            return (res, index);
        }

        private (int, int) GetRepeat(string s, int index)
        {
            var start = index;
            var length = 1;

            for (int i = index + 1; index < s.Length || i <= index + 3; i++)
            {
                if (!numbers.Contains(s[i])) break;

                length++;
            }

            return (int.Parse(s.Substring(start, length)), length);
        }
    }
}