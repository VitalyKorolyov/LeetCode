using System.Collections.Generic;
using System.Text;

namespace LeetCode.String.Hard.TextJustification;

//https://leetcode.com/problems/text-justification/description/
public class Solution
{
    public IList<string> FullJustify(string[] words, int maxWidth)
    {
        var width = 0;
        List<string> lines = new();
        List<string> line = new();

        foreach (var word in words)
        {
            if (word.Length + width + line.Count <= maxWidth)
            {
                width += word.Length;
                line.Add(word);
                continue;
            }

            if (line.Count == 1)
                lines.Add($"{line[0]}{new string(' ', maxWidth - width)}");
            else
            {
                var commonSpaces = System.Math.DivRem(maxWidth - width, line.Count - 1, out int extraSpaces);

                StringBuilder strBuilder = new(maxWidth);
                for (var i = 0; i < line.Count; i++)
                {
                    strBuilder.Append(line[i]);
                    if (i >= line.Count - 1) continue;

                    strBuilder.Append(new string(' ', commonSpaces));
                    if (extraSpaces <= 0) continue;

                    strBuilder.Append(' ');
                    extraSpaces--;
                }

                lines.Add(strBuilder.ToString());
            }

            line = new List<string> { word };
            width = word.Length;
        }

        StringBuilder lastLine = new(maxWidth);
        lastLine.Append(string.Join(" ", line));
        lastLine.Append(new string(' ', maxWidth - lastLine.Length));
        lines.Add(lastLine.ToString());

        return lines;
    }
}