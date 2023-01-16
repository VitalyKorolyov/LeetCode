using System.Collections.Generic;
using System.Text;

namespace LeetCode.String.Medium.CustomSortString;

//https://leetcode.com/problems/custom-sort-string/description/
public class Solution
{
    public string CustomSortString(string order, string s)
    {
        Dictionary<char, int> hashMap = new();

        for (int i = 0; i < s.Length; i++)
        {
            if (!hashMap.ContainsKey(s[i]))
                hashMap[s[i]] = 0;

            hashMap[s[i]]++;
        }

        StringBuilder answer = new();
        for (int j = 0; j < order.Length; j++)
        {
            if (!hashMap.ContainsKey(order[j])) continue;

            for (int m = 0; m < hashMap[order[j]]; m++)
                answer.Append(order[j]);

            hashMap.Remove(order[j]);
        }

        foreach (var letter in hashMap)
        {
            for (int m = 0; m < letter.Value; m++)
                answer.Append(letter.Key);

            hashMap.Remove(letter.Key);
        }

        return answer.ToString();
    }
}