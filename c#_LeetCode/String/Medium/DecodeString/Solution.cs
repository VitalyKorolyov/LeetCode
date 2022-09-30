using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.String.Medium.DecodeString
{
    //https://leetcode.com/problems/decode-string/
    public class Solution
    {
        public string DecodeString(string s)
        {
            Queue<char> queue = new(s.ToCharArray());

            return Helper(queue).ToString();
        }

        public StringBuilder Helper(Queue<char> queue)
        {
            int num = 0;
            StringBuilder sb = new();

            while (queue.Count != 0)
            {
                char curr = queue.Dequeue();

                if (char.IsDigit(curr))
                {
                    num = 10 * num + int.Parse(curr.ToString());
                    continue;
                }

                if (curr == '[')
                {
                    var temp = Helper(queue);
                    sb.Append(string.Join("", Enumerable.Repeat(temp, num)));
                    num = 0;
                    continue;
                }

                if (curr == ']') return sb;
                if (char.IsLetter(curr)) sb.Append(curr);
            }

            return sb;
        }
    }
}