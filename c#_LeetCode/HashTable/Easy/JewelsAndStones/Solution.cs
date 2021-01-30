using System.Collections.Generic;

namespace LeetCode.HashTable.Easy.JewelsAndStones
{
    //https://leetcode.com/problems/jewels-and-stones/
    public class Solution
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            var hash = new HashSet<char>(jewels.Length);

            foreach (var jewel in jewels)
                hash.Add(jewel);

            var jewelsCount = 0;
            foreach (var stone in stones)
            {
                if (hash.Contains(stone)) jewelsCount++;
            }

            return jewelsCount;
        }
    }
}