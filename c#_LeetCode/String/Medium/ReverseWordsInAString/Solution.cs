using System.Text;

namespace LeetCode.String.Medium.ReverseWordsInAString;

//https://leetcode.com/problems/reverse-words-in-a-string/
public class Solution
{
    public string ReverseWords(string s)
    {
        char[] charsArray = s.ToCharArray();

        Reverse(charsArray, 0, charsArray.Length - 1);
        ReverseWords(charsArray);

        StringBuilder result = new();
        RemoveSpaces(result, charsArray);

        return result.ToString();
    }

    private void RemoveSpaces(StringBuilder result, char[] charArrays)
    {
        int start = 0;
        int end = charArrays.Length - 1;

        for (int i = start; i < charArrays.Length; i++)
        {
            if (charArrays[i] != ' ')
            {
                start = i;
                break;
            }
        }

        for (int i = end; i >= 0; i--)
        {
            if (charArrays[i] != ' ')
            {
                end = i;
                break;
            }
        }

        while (start <= end)
        {
            if (charArrays[start] == ' ')
            {
                result.Append(' ');

                while (start <= end && charArrays[start] == ' ')
                    start++;
            }

            result.Append(charArrays[start]);
        }
    }

    private void Reverse(char[] charsArray, int start, int end)
    {
        while(start < end)
        {
            char saved = charsArray[start];

            charsArray[start++] = charsArray[end];
            charsArray[end--] = saved;
        }
    }

    private void ReverseWords(char[] charsArray)
    {
        int start = 0;
        for (int end = 0; end <= charsArray.Length; end++)
        {
            if (charsArray.Length == end || charsArray[end] == ' ')
            {
                Reverse(charsArray, start, end - 1);
                start = end + 1;
            }
        }
    }
}