using System.Collections.Generic;

namespace LeetCode.String.Medium.FindAllAnagramsInAString;

//https://leetcode.com/problems/find-all-anagrams-in-a-string/
public class Solution
{
    public IList<int> FindAnagrams(string s, string p)
    {
        List<int> result = new();
        int[] countP = new int[26];

        for (int i = 0; i < p.Length; i++)
            countP[p[i] - 'a']++;

        int[] countS = new int[26];
        for (int i = 0, j = 0; i < s.Length; i++)
        {
            countS[s[i] - 'a']++;

            if(i >= p.Length - 1)
            {
                if(IsEqual(countS, countP))
                    result.Add(j);

                countS[s[j++] - 'a']--;
            }
        }

        return result;
    }

    private bool IsEqual(int[] s, int[] p)
    {
        for (int i = 0; i < s.Length; i++) 
            if (s[i] != p[i]) return false;

        return true;
    }
}
