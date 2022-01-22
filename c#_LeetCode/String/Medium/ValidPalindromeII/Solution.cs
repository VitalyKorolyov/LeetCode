namespace LeetCode.String.Medium.ValidPalindromeII
{
    public class Solution
    {
        public bool ValidPalindrome(string s)
        {
            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                if (s[i] == s[j]) continue;
                if (s[i] != s[j])
                {
                    return Compare(i + 1, j, s) || Compare(i, j - 1, s);
                }
            }

            return true;
        }

        private bool Compare(int i, int j, string s)
        {
            for (; i < j; i++, j--)
            {
                if (s[i] == s[j]) continue;
                else return false;
            }

            return true;
        }
    }
}
