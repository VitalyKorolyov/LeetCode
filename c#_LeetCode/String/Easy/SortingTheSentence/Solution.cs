using System.Text;

namespace LeetCode.String.Easy.SortingTheSentence
{
    //https://leetcode.com/problems/sorting-the-sentence/
    public class Solution
    {
        public static string SortSentence(string s)
        {
            var words = s.Split(' ');
            var str = new StringBuilder(s.Length - words.Length);

            for (int i = 49; i <= 49 + words.Length; i++)
            {
                var c = (char) i;

                var currentWord = string.Empty;

                foreach (var word in words)
                {
                    if (word[word.Length - 1] == c)
                        currentWord = word.Substring(0, word.Length - 1);
                }

                if (i == 49 + words.Length - 1)
                {
                    str.Append(currentWord);
                    break;
                }

                str.Append(currentWord + " ");
            }

            return str.ToString();
        }
    }
}