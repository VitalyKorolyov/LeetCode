using System.Collections.Generic;
using System.Text;

namespace LeetCode.String.Hard.TextJustification
{
    //https://leetcode.com/problems/text-justification/description/
    public class Solution
    {
        public IList<string> FullJustify(string[] words, int maxWidth)
        {
            int left = 0; 
            List<string> result = new();

            while (left < words.Length)
            {
                int right = FindRight(left, words, maxWidth);
                result.Add(Justify(left, right, words, maxWidth));
                left = right + 1;
            }

            return result;
        }

        private int FindRight(int left, string[] words, int maxWidth)
        {
            int right = left;
            int sum = words[right++].Length;

            while (right < words.Length && (sum + 1 + words[right].Length) <= maxWidth)
                sum += 1 + words[right++].Length;

            return right - 1;
        }

        private string Justify(int left, int right, string[] words, int maxWidth)
        {
            if (right - left == 0) return PadResult(words[left], maxWidth);

            bool isLastLine = right == words.Length - 1;
            int numSpaces = right - left;
            int totalSpace = maxWidth - WordsLength(left, right, words);

            string space = isLastLine ? " " : Blank(totalSpace / numSpaces);
            int remainder = isLastLine ? 0 : totalSpace % numSpaces;

            StringBuilder result = new StringBuilder();
            for (int i = left; i <= right; i++)
                result.Append(words[i])
                    .Append(space)
                    .Append(remainder-- > 0 ? " " : "");

            return PadResult(result.ToString().Trim(), maxWidth);
        }

        private int WordsLength(int left, int right, string[] words)
        {
            int wordsLength = 0;

            for (int i = left; i <= right; i++) 
                wordsLength += words[i].Length;

            return wordsLength;
        }

        private string PadResult(string result, int maxWidth)
        {
            return result + Blank(maxWidth - result.Length);
        }

        private string Blank(int length)
        {
            return new string(new char[length]).Replace('\0', ' ');
        }
    }
}
