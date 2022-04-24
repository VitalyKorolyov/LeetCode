using System.Collections.Generic;
using System.Linq;

namespace LeetCode.HashTable.Medium.SubdomainVisitCount
{
    //https://leetcode.com/problems/subdomain-visit-count/
    public class Solution
    {
        public IList<string> SubdomainVisits(string[] cpdomains)
        {
            var map = new Dictionary<string, int>();

            foreach (var cpdomain in cpdomains)
            {
                var parts = cpdomain.Split(' ');
                var count = int.Parse(parts[0]);
                var subdomain = parts[1];

                if (!map.TryAdd(subdomain, count))
                    map[subdomain] += count;

                for (int k = 0; k < subdomain.Length; k++)
                {
                    if (subdomain[k] == '.')
                    {
                        var name = subdomain.Substring(k + 1);
                        if (!map.TryAdd(name, count))
                            map[name] += count;
                    }
                }
            }

            return map.Select(x => $"{x.Value} {x.Key}").ToList();
        }
    }
}
