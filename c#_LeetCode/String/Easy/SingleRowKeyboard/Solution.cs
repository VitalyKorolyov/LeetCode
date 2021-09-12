using System.Collections.Generic;

namespace LeetCode.String.Easy.SingleRowKeyboard
{
    //https://leetcode.com/problems/single-row-keyboard/
    public class Solution
    {
        public int CalculateTime(string keyboard, string word)
        {
            var dic = new Dictionary<char, int>(keyboard.Length);

            for (var i = 0; i < keyboard.Length; i++)
                dic.Add(keyboard[i], i);

            var currentIndex = 0;
            var time = 0;

            for (var i = 0; i < word.Length; i++)
            {
                 time += System.Math.Abs(currentIndex - dic[word[i]]);
                 currentIndex = dic[word[i]];
            }

            return time;
        }
    }
}