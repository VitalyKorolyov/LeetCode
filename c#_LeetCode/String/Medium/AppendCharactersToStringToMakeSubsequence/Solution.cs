namespace LeetCode.String.Medium.AppendCharactersToStringToMakeSubsequence;

//https://leetcode.com/problems/append-characters-to-string-to-make-subsequence/description/
public class Solution
{
    public int AppendCharacters(string s, string t)
    {
        int j = 0;
        for (int i = 0; i < s.Length && j < t.Length; i++)
            if (s[i] == t[j]) j++;

        return t.Length - j;
    }
}