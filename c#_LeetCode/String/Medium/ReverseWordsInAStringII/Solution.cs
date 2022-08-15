namespace LeetCode.String.Medium.ReverseWordsInAStringII
{
    //https://leetcode.com/problems/reverse-words-in-a-string-ii/
    public class Solution
    {
        public void ReverseWords(char[] s)
        {
            Reverse(s);
            ReverseWord(s);
        }

        public void Reverse(char[] s)
        {
            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                var saved = s[i];
                s[i] = s[j];
                s[j] = saved;
            }
        }

        public void ReverseWord(char[] s)
        {
            var startIndex = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] == ' ')
                {
                    Reverse(s, startIndex, i - 1);
                    startIndex = i + 1;
                }
            }

            Reverse(s, startIndex, s.Length - 1);
        }

        private void Reverse(char[] s, int startIndex, int endIndex)
        {
            while(startIndex < endIndex)
            {
                var saved = s[startIndex];
                s[startIndex++] = s[endIndex];
                s[endIndex--] = saved;
            }
        }
    }
}
