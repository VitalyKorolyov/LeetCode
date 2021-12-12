using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.String.Medium.GroupAnagrams
{
    //https://leetcode.com/problems/group-anagrams/
    public class Solution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var res = new List<IList<string>>();

            if (strs == null || strs.Length == 0)
                return res;

            var dict = new Dictionary<string, List<string>>();

            foreach (var str in strs)
            {
                var cur = new string(str.OrderBy(x => x).ToArray());

                if (!dict.ContainsKey(cur))
                    dict.Add(cur, new List<string>());

                dict[cur].Add(str);
            }

            foreach (var item in dict.Values)
                res.Add(item);

            return res;
        }
    }
}