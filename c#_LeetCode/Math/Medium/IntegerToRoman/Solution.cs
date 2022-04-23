using System.Collections.Generic;
using System.Text;

namespace LeetCode.Math.Medium.IntegerToRoman
{
    //https://leetcode.com/problems/integer-to-roman/
    public class Solution
    {
        private static Dictionary<int, string> romans = new Dictionary<int, string>()
        {
            {1000, "M" }, {900, "CM" },{500, "D" },{400, "CD" }, {100, "C" },{90, "XC" },
            {50, "L" },{40, "XL" },{10, "X" },{9, "IX" },{5, "V" },{4, "IV" },{1, "I" }
        };

        public string IntToRoman(int num)
        {
            var res = new StringBuilder();

            foreach (var (value, sym) in romans)
            {
                while(value <= num)
                {
                    res.Append(sym);
                    num -= value;
                }
            }

            return res.ToString();
        }
    }
}
