namespace LeetCode.String.Easy.ConsecutiveCharacters
{
    //https://leetcode.com/problems/consecutive-characters/
    public class Solution
    {
        public int MaxPower(string s)
        {
            var maxCount = 0;
            var count = 0;
            var prevChar = ' ';

            for (int i = 0; i < s.Length; i++)
            {
                if(prevChar == s[i])
                {
                    count++;
                }
                else
                {
                    prevChar = s[i];
                    count = 1;
                }

                maxCount = System.Math.Max(maxCount, count);
            }

            return maxCount;
        }
    }
}
