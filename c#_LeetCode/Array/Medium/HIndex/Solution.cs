using System.Collections.Generic;

namespace LeetCode.Array.Medium.HIndex;

//https://leetcode.com/problems/h-index/description
public class Solution
{
    public int HIndex(int[] citations)
    {
        Dictionary<int, int> count = new();

        for (int i = 0; i < citations.Length; i++)
        {
            var currentCitation = citations[i] > citations.Length 
                ? citations.Length 
                : citations[i];

            if (count.ContainsKey(currentCitation))
                count[currentCitation]++;
            else 
                count[currentCitation] = 1;
        }

        int indexToInsert = 0;
        for (int i = 0; i <= citations.Length; i++)
        {
            var currentCount = count.ContainsKey(i) ? count[i] : 0;

            while(currentCount > 0)
            {
                citations[indexToInsert++] = i;
                currentCount--;
            }
        }

        int hIndex = 0;
        for (int i = citations.Length - 1; i >= 0; i--)
        {
            if (hIndex + 1 <= citations[i]) hIndex++;
            else break;
        }

        return hIndex;
    }

    public int HIndexNLogN(int[] citations)
    {
        System.Array.Sort(citations);

        int hIndex = 0;
        for (int i = citations.Length - 1; i >= 0; i--)
        {
            if (hIndex + 1 <= citations[i]) hIndex++;
            else break;
        }

        return hIndex;
    }

    public int HIndexN2(int[] citations)
    {
        int n = citations.Length;

        for (int hIndex = 1; hIndex <= n; hIndex++)
        {
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                if (citations[i] >= hIndex)
                    count++;
            }

            if(count < hIndex)
                return hIndex - 1;
        }

        return n;
    }
}