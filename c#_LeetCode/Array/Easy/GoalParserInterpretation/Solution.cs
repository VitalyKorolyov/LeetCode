using System.Collections.Generic;
using System.Text;

namespace LeetCode.Array.Easy.GoalParserInterpretation
{
    //https://leetcode.com/problems/goal-parser-interpretation/
    public class Solution
    {
        public static string Interpret(string command)
        {
            var str = new Dictionary<string, string>
            {
                {"G", "G"}, 
                {"()", "o"}, 
                {"(al)", "al"}
            };

            var stringBuilder = new StringBuilder(100);

            for (int i = 0; i < command.Length; i++)
            {
                for (int j = i + 1; j <= command.Length; j++)
                {
                    var key = command[i..j];
                    if (str.ContainsKey(key))
                    {
                        stringBuilder.Append(str[key]);
                        i = j - 1;
                        break;
                    }
                }
            }

            return stringBuilder.ToString();
        }
    }
}