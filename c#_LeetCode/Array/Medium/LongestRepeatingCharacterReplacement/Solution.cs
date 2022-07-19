using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array.Medium.LongestRepeatingCharacterReplacement
{
    //https://leetcode.com/problems/longest-repeating-character-replacement/
    public class Solution
    {
        public int CharacterReplacement(string s, int k)
        {
            int maxLength = int.MinValue, maxRepeatLetter = int.MinValue;
            Dictionary<char, int> letterFrequencyMap = new();
            int left = 0, right = 0;

            while (right < s.Length)
            {
                if (letterFrequencyMap.ContainsKey(s[right]))
                    letterFrequencyMap[s[right]]++;
                else
                    letterFrequencyMap.Add(s[right], 1);

                maxRepeatLetter = System.Math.Max(maxRepeatLetter, letterFrequencyMap[s[right]]);

                if (right - left + 1 - maxRepeatLetter > k)
                {
                    letterFrequencyMap[s[left]]--;
                    left++;
                }

                maxLength = System.Math.Max(maxLength, right - left + 1);

                right++;
            }

            return maxLength;
        }
    }
}
