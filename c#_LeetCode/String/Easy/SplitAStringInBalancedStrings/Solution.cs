namespace LeetCode.String.Easy.SplitAStringInBalancedStrings
{
    //https://leetcode.com/problems/split-a-string-in-balanced-strings/
    public class Solution
    {
        public static int BalancedStringSplit(string s)
        {
            var max = 0;
            var charCounter = 0;

            for (var i = 0; i < s.Length; i++)
            {
                var item = s[i];

                if (item == 'L')
                    charCounter++;
                else charCounter--;

                if (charCounter == 0) max++;
            }

            return max;
        }
    }
}