using System.Text;

namespace LeetCode.String.Medium.StringWithoutAAAOrBBB
{
    //https://leetcode.com/problems/string-without-aaa-or-bbb/
    public class Solution
    {
        public string StrWithout3a3b(int a, int b)
        {
            var size = a + b;
            var res = new StringBuilder(size);

            var countA = 0; 
            var countB = 0;

            for (int i = 0; i < size; i++)
            {
                if(a >= b && countA <= 1 || countB == 2)
                {
                    res.Append("a");
                    countA++;
                    countB = 0;
                    a--;
                }
                else
                {
                    res.Append("b");
                    countB++;
                    countA = 0;
                    b--;
                }
            }

            return res.ToString();
        }
    }
}
