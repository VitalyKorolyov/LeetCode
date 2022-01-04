using System.Linq;

namespace LeetCode.String.Medium.StringCompression
{
    //https://leetcode.com/problems/string-compression/
    public class Solution
    {
        public int Compress(char[] chars)
        {
            if (!chars.Any()) return 0;
            if (chars.Length == 1) return 1;

            var indexToInsert = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                var index = i;

                while (index < chars.Length && chars[i] == chars[index])
                {
                    index++;
                }

                chars[indexToInsert++] = chars[i];
                var count = index - i;

                if (count > 1)
                {
                    foreach (var @char in count.ToString().ToCharArray())
                        chars[indexToInsert++] = @char;
                }

                i = index - 1;
            }

            return indexToInsert;
        }
    }
}