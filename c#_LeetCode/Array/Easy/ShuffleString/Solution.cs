using System.Text;

namespace LeetCode.Array.Easy.ShuffleString
{
    //https://leetcode.com/problems/shuffle-string/
    public class Solution
    {
        public static string RestoreString(string s, int[] indices)
        {
            var result = new StringBuilder(s.Length);

            foreach (var indicate in indices)
                result.Append(s[indicate]);

            return result.ToString();
        }
    }
}