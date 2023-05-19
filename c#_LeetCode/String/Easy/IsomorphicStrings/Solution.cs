using System.Collections.Generic;

//https://leetcode.com/problems/isomorphic-strings/description/

namespace LeetCode.String.Easy.IsomorphicStrings;

public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        if(s.Length != t.Length) return false;

        Dictionary<char, char> mapToT = new(s.Length);
        Dictionary<char, char> mapToS = new(s.Length);

        for (int i = 0; i < s.Length; i++)
        {
            char sChar = s[i];
            char tChar = t[i];

            if (!mapToT.ContainsKey(sChar) && mapToS.ContainsKey(tChar)) return false;

            if (!mapToT.ContainsKey(sChar))
            {
                mapToT[sChar] = tChar;
                mapToS[tChar] = sChar;
            }
            else
                if (mapToT[sChar] != tChar) return false;
        }

        return true;
    }
}