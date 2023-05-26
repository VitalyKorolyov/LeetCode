namespace LeetCode.String.Medium.IsSubsequence;

//https://leetcode.com/problems/is-subsequence/description
public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        int indexS = 0;

        for (int indexT = 0; indexT < t.Length && indexS < s.Length; indexT++)
        {
            if (t[indexT] == s[indexS])
                indexS++;
        }

        return indexS == s.Length ? true : false;
    }
}