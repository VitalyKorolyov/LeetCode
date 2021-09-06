namespace LeetCode.String.Easy.LengthOfLastWord
{
    //https://leetcode.com/problems/length-of-last-word/
    public class Solution
    {
        public int LengthOfLastWord(string s)
        {
            var startedIndex = 0;
            var isFirstIndexOfWord = true;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ' && isFirstIndexOfWord)
                {
                    startedIndex = i;
                    isFirstIndexOfWord = false;
                }

                if(s[i] == ' ')
                {
                    isFirstIndexOfWord = true;
                }
            }

            var endIndex = startedIndex;
            for (int i = startedIndex; i < s.Length; i++)
            {
                if (s[i] != ' ') endIndex = i;
            }

            return endIndex - startedIndex + 1;
        }
    }
}