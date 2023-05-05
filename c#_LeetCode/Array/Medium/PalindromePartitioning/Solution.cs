using System.Collections.Generic;

namespace LeetCode.Array.Medium.PalindromePartitioning;

//https://leetcode.com/problems/palindrome-partitioning/description/
public class Solution
{
    public IList<IList<string>> Partition(string s)
    {
        List<IList<string>> result = new();

        BackTrack(0, s, result, new List<string>());

        return result;
    }

    private void BackTrack(int start, string s, List<IList<string>> result, List<string> temp)
    {
        if (start == s.Length)
            result.Add(new List<string>(temp));
        else
        {
            for (int i = start; i < s.Length; i++)
            {
                if (IsPalindrome(s, start, i))
                {
                    temp.Add(s.Substring(start, i - start + 1));
                    BackTrack(i + 1, s, result, temp);
                    temp.RemoveAt(temp.Count - 1);
                }
            }
        }
    }

    private bool IsPalindrome(string s, int l, int r)
    {
        while (l < r)
        {
            if (s[l++] != s[r--])
                return false;
        }

        return true;
    }
}