using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Array.Medium.AnalyzeUserWebsiteVisitPattern;

//https://leetcode.com/problems/analyze-user-website-visit-pattern/description/
public class Solution
{
    public IList<string> MostVisitedPattern(string[] username, int[] timestamp, string[] website)
    {
        Dictionary<string, List<(int, string)>> map = new();

        for (int i = 0; i < username.Length; i++)
        {
            if (!map.ContainsKey(username[i])) map.Add(username[i], new List<(int, string)>());
            map[username[i]].Add((timestamp[i], website[i]));
        }

        string result = "";
        Dictionary<string, int> count = new();

        foreach (string key in map.Keys)
        {
            HashSet<string> uniquePerUser = new();
            List<(int, string)> list = map[key];

            list.Sort((a, b) => a.Item1 - b.Item1); // sort by time

            for (int i = 0; i < list.Count; i++)
                for (int j = i + 1; j < list.Count; j++)
                    for (int k = j + 1; k < list.Count; k++)
                    {
                        string str = list[i].Item2 + " " + list[j].Item2 + " " + list[k].Item2;
                        if (!uniquePerUser.Contains(str))
                        {
                            count[str] = count.GetValueOrDefault(str, 0) + 1;
                            uniquePerUser.Add(str);
                        }
                        if (result == string.Empty || count[result] < count[str] || 
                            (count[result] == count[str] && result.CompareTo(str) > 0))
                        {
                            result = str;
                        }
                    }
        }

        return result.Split(" ").ToList();
    }
}
