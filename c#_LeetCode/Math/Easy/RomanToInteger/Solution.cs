using System.Collections.Generic;

namespace LeetCode.Math.Easy.RomanToInteger
{
    //https://leetcode.com/problems/roman-to-integer/
    public class Solution
    {
        public static Dictionary<string, int> romanToIntegers = new Dictionary<string, int>
        {
            {"I", 1},
            {"IV", 4},
            {"V", 5},
            {"IX", 9},
            {"X", 10},
            {"XL", 40 },
            {"L", 50},
            {"XC", 90},
            {"C", 100},
            {"CD", 400},
            {"D", 500},
            {"CM", 900},
            {"M", 1000}
        };

        public int RomanToInt(string s)
        {
            var res = 0;
            for (int i = 0; i < s.Length; i++)
            {
                string roman;
                if(i + 1 < s.Length)
                {
                    roman = s.Substring(i, 2);
                    if (romanToIntegers.ContainsKey(roman))
                    {
                        res += romanToIntegers[roman];
                        i++;
                        continue;
                    }
                }

                roman = s.Substring(i, 1);
                res += romanToIntegers[roman];
            }

            return res;
        }
    }
}
