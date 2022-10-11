namespace LeetCode.String.Easy.LongestCommonPrefix
{
    //https://leetcode.com/problems/longest-common-prefix/
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0) return "";

            var commonPrefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                while (!strs[i].StartsWith(commonPrefix))
                    commonPrefix = commonPrefix.Remove(commonPrefix.Length - 1);
            }

            return commonPrefix;
        }
    }
}
