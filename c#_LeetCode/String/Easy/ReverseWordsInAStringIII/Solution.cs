using System.Text;

namespace LeetCode.String.Easy.ReverseWordsInAStringIII
{
    //https://leetcode.com/problems/reverse-words-in-a-string-iii/
    public class Solution
    {
        public static string ReverseWords(string s)
        {
            var str = s.ToCharArray();

            Reverse(str);

            return new string(str);
        }

        private static void Reverse(char[] str)
        {
            var left = 0;

            for (int right = 0; right < str.Length; right++)
            {
                if(str[right] == ' ')
                {
                    ReverseWord(str, left, right);
                    left = right + 1;
                }
            }

            ReverseWord(str, left, str.Length - 1);
        }

        private static void ReverseWord(char[] str, int left, int right)
        {
            while(left < right)
            {
                var temp = str[left];
                str[left++] = str[right];
                str[right--] = temp;
            }
        } 
    }
}