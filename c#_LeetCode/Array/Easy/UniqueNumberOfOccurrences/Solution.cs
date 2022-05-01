using System.Collections.Generic;

namespace LeetCode.Array.Easy.UniqueNumberOfOccurrences
{
    //https://leetcode.com/problems/unique-number-of-occurrences/
    public class Solution
    {
        public bool UniqueOccurrences(int[] arr)
        {
            var hash = new Dictionary<int, int>(arr.Length);

            for (int i = 0; i < arr.Length; i++)
            {
                if (!hash.ContainsKey(arr[i]))
                    hash.Add(arr[i], 1);
                else
                    hash[arr[i]]++;
            }

            var hashSet = new HashSet<int>(arr.Length);
            foreach (int i in hash.Values)
            {
                if (!hashSet.Contains(i))
                    hashSet.Add(i);
                else
                    return false;
            }

            return true;
        }
    }
}
