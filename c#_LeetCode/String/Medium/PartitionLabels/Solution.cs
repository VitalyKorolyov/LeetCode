using System.Collections.Generic;

namespace LeetCode.String.Medium.PartitionLabels
{
    //https://leetcode.com/problems/partition-labels/
    public class Solution
    {
        public IList<int> PartitionLabels(string s)
        {
            var res = new List<int>();
            var hashMap = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (hashMap.ContainsKey(s[i]))
                {
                    hashMap[s[i]] = i;
                }
                else
                {
                    hashMap.Add(s[i], i);
                }
            }

            int left = 0, right = 0;
            for (int i = 0; i < s.Length; i++)
            {
                var rightPos = hashMap[s[i]];

                if (rightPos > right)
                    right = rightPos;

                if (i == right)
                {
                    res.Add(right - left + 1);
                    right = i + 1;
                    left = right;
                }
            }

            return res;
        }
    }
}