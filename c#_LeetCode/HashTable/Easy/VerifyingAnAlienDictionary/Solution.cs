using System.Collections.Generic;

namespace LeetCode.HashTable.Easy.VerifyingAnAlienDictionary;

public class Solution
{
    public bool IsAlienSorted(string[] words, string order)
    {
        Dictionary<char, int> alienDictionary = new();
        for (int i = 0; i < order.Length; i++)
            alienDictionary[order[i]] = i;

        for (int i = 0; i + 1 < words.Length; i++)
        {
            string first = words[i];
            string second = words[i + 1];

            int minLength = System.Math.Min(first.Length, second.Length);
            for (int j = 0; j < minLength; j++)
            {
                var letterFromFirst = first[j];
                var letterFromSecond = second[j];

                if (alienDictionary[letterFromFirst] < alienDictionary[letterFromSecond]) break;
                if (alienDictionary[letterFromFirst] > alienDictionary[letterFromSecond]) return false;

                if (j == minLength - 1 && first.Length > second.Length)
                    return false;
            }
        }

        return true;
    }
}