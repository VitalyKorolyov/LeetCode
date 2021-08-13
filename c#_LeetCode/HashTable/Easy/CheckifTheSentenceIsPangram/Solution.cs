using System.Collections.Generic;

namespace LeetCode.HashTable.Easy.CheckifTheSentenceIsPangram
{
    //https://leetcode.com/problems/check-if-the-sentence-is-pangram/
    public class Solution
    {
        public static bool CheckIfPangram(string sentence)
        {
            var hashMap = new HashSet<char>();

            for (var i = 0; i < sentence.Length; i++)
            {
                var c = sentence[i];
                if (hashMap.Contains(c)) continue;

                hashMap.Add(c);
            }

            return hashMap.Count == 26;
        }
    }
}