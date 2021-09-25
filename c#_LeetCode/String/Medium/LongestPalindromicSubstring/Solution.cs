namespace LeetCode.String.Medium.LongestPalindromicSubstring
{
    //https://leetcode.com/problems/longest-palindromic-substring/
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return string.Empty;

            int start = 0, end = 0;
            for (int i = 0; i < s.Length; i++)
            {
                var len1 = GetLen(i, i, s);
                var len2 = GetLen(i, i + 1, s);
                var len = System.Math.Max(len1, len2);

                if (len > end - start)
                {
                    start = i - (len - 1) / 2;
                    end = i + len / 2;
                }
            }

            return s[start..(end + 1)];
        }

        private int GetLen(int l, int r, string s)
        {
            while (l >= 0 && r < s.Length && s[l] == s[r])
            {
                l--; r++;
            }

            return r - l - 1;
        }
    }
}