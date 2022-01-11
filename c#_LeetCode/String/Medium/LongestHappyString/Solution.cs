using System.Text;

namespace LeetCode.String.Medium.LongestHappyString
{
    //https://leetcode.com/problems/longest-happy-string/
    public class Solution
    {
        public string LongestDiverseString(int a, int b, int c)
        {
            var size = a + b + c;
            var res = new StringBuilder(size);

            int A = 0, B = 0, C = 0;
            for (int i = 0; i < size; i++)
            {
                if (a >= b && a >= c && A != 2 || B == 2 && a > 0 || C == 2 && a > 0)
                {
                    res.Append("a");
                    A++;
                    a--;
                    B = 0;
                    C = 0;
                }
                else if (b >= a && b >= c && B != 2 || A == 2 && b > 0 || C == 2 && b > 0)
                {
                    res.Append("b");
                    b--;
                    B++;
                    C = 0;
                    A = 0;
                }
                else if (c >= a && c >= b && C != 2 || A == 2 && c > 0 || B == 2 && c > 0)
                {
                    res.Append("c");
                    C++;
                    c--;
                    A = 0;
                    B = 0;
                }
            }

            return res.ToString();
        }
    }
}