using System.Collections.Generic;
using System.Text;

namespace LeetCode.String.Medium.GroupAnagrams;

//https://leetcode.com/problems/group-anagrams/
public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, IList<string>> anagrams = new();

        for(int i = 0; i < strs.Length; i++)
        {
            string str = strs[i];

            int[] count = new int[26];
            for (int j = 0; j < str.Length; j++)
                count[str[j] - 'a']++;

            StringBuilder key = new(str.Length);
            for(int k = 0; k < count.Length; k++)
            {
                while (count[k] > 0)
                {
                    key.Append((char)('a' + k));
                    count[k]--;
                }
            }

            string strKey = key.ToString();
            if (!anagrams.ContainsKey(strKey))
                anagrams[strKey] = new List<string>() { str };
            else 
                anagrams[strKey].Add(str);
        }

        var result = new List<IList<string>>();
        result.AddRange(anagrams.Values);

        return result;
    }
}