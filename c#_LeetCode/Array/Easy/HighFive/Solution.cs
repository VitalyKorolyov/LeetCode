using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Array.Easy.HighFive
{
    //https://leetcode.com/problems/high-five/
    public class Solution
    {
        public int[][] HighFive(int[][] items)
        {
            System.Array.Sort(items, (x, y) =>
            {
                if (x[0] != y[0])
                    return x[0].CompareTo(y[0]);

                return y[1].CompareTo(x[1]);
            });

            var hashMap = new Dictionary<int, List<int>>();

            for (int i = 0; i < items.Length; i++)
            {
                if (!hashMap.ContainsKey(items[i][0]))
                    hashMap.Add(items[i][0], new List<int>(5));

                if(hashMap[items[i][0]].Count == 5) continue;

                hashMap[items[i][0]].Add(items[i][1]);
            }

            var res = new int[hashMap.Count][];
            var j = 0;
            foreach (var key in hashMap.Keys)
            {
                var avS = hashMap[key].Sum() / 5;
                res[j++] = new[] { key, avS};
            }

            return res;
        }
    }
}