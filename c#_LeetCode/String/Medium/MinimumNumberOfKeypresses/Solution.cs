using System;

namespace LeetCode.String.Medium.MinimumNumberOfKeypresses
{
    public class Solution
    {
        public int MinimumKeypresses(string s)
        {
            var frequency = new int[26];

            for (int i = 0; i < s.Length; i++)
                frequency[s[i] - 'a'] += 1;

            System.Array.Sort(frequency, new Comparison<int>(
                  (i1, i2) => i2.CompareTo(i1)));

            var res = 0;
            var pressTime = 1;

            for (int i = 0; i < frequency.Length; i++)
            {
                res += pressTime * frequency[i];

                if ((i + 1) % 9 == 0)
                    pressTime++;
            }

            return res;
        }
    }
}
