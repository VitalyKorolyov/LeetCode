namespace LeetCode.String.Easy.ValidPalindrome
{
    //https://leetcode.com/problems/valid-palindrome/
    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            if (s == null || s.Length <= 1) return true;

            int i = 0, j = s.Length - 1;

            while (i < j)
            {
                if (!char.IsLetterOrDigit(s[i]))
                {
                    i++;
                    continue;
                }
                if (!char.IsLetterOrDigit(s[j]))
                {
                    j--;
                    continue;
                }

                if (char.ToLower(s[i++]) != char.ToLower(s[j--])) return false;
            }

            return true;
        }
    }
}
