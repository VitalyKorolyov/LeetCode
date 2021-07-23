using System.Collections.Generic;
using System.Text;

namespace LeetCode.Array.Easy.UniqueMorseCodeWords
{
    //https://leetcode.com/problems/unique-morse-code-words/
    public class Solution
    {
        public static int UniqueMorseRepresentations(string[] words)
        {
            var morseCodes = new[]{".-", "-...", "-.-.", "-..", ".", "..-.", 
            "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", 
            ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", 
            "-.--", "--.."};

            var hash = new HashSet<string>();

            foreach (var word in words)
            {
                var stringBuilder = new StringBuilder(word.Length * 4);

                foreach (var c in word)
                    stringBuilder.Append(morseCodes[c - 'a']);

                var str = stringBuilder.ToString();
                if (!hash.Contains(str))
                    hash.Add(str);
            }

            return hash.Count;
        }
    }
}