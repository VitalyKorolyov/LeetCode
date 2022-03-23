namespace LeetCode.String.Medium.FlipStringToMonotoneIncreasing
{
    //https://leetcode.com/problems/flip-string-to-monotone-increasing/
    public class Solution
    {
        public int MinFlipsMonoIncr(string s)
        {
            int oneCount = 0;
            int flipCount = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '1')
                    oneCount++;
                else
                {
                    if (oneCount >= 1)
                        flipCount++;
                }

                flipCount = System.Math.Min(flipCount, oneCount);
            }

            return flipCount;
        }
    }
}
