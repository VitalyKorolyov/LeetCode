using System.Collections.Generic;
using System.Linq;

namespace LeetCode.String.Easy.MaximumNumberOfBalloons
{
    //https://leetcode.com/problems/maximum-number-of-balloons/
    public class Solution
    {
        public int MaxNumberOfBalloons(string text)
        {
            var dic = new Dictionary<char, int>()
            {
                {'a', 0},
                {'b', 0},
                {'n', 0},
                {'l', 0},
                {'o', 0}
            };

            for (int i = 0; i < text.Length; i++)
            {
                if (dic.ContainsKey(text[i]))
                {
                    dic[text[i]]++;
                }
            }

            return dic.Min(x => x.Key == 'l' || x.Key == 'o' ? x.Value/2 : x.Value);
        }
    }
}