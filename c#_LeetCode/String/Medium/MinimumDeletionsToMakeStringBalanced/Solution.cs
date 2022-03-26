namespace LeetCode.String.Medium.MinimumDeletionsToMakeStringBalanced
{
    //https://leetcode.com/problems/minimum-deletions-to-make-string-balanced/
    public class Solution
    {
        public int MinimumDeletions(string s)
        {
            int countB = 0;
            var res = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'b') countB++;

                if(s[i] == 'a')
                    res = System.Math.Min(++res, countB);
            }

            return res;
        }
    }
}
