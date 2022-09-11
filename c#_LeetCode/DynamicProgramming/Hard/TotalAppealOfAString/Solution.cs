using System.Linq;

namespace LeetCode.DynamicProgramming.Hard.TotalAppealOfAString
{
    //https://leetcode.com/problems/total-appeal-of-a-string/
    public class Solution
    {
        public long AppealSum(string s)
        {
            var seen = new int[26];

            long res = 0;
            for (int i = 0; i < s.Length; i++)
            {
                var index = s[i] - 'a';

                seen[index] = i + 1;
                res += seen.Sum();
            }

            return res;
        }
    }
}
