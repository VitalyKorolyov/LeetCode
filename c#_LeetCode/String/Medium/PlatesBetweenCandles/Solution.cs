using System.Collections.Generic;

namespace LeetCode.String.Medium.PlatesBetweenCandles
{
    //https://leetcode.com/problems/plates-between-candles/
    public class Solution
    {
        public int[] PlatesBetweenCandles(string s, int[][] queries)
        {
            List<int> candles = new();

            for (int i = 0; i < s.Length; ++i) //O(n)
                if (s[i] == '|') candles.Add(i);

            int[] result = new int[queries.Length];

            for (int i = 0; i < queries.Length; ++i) 
            {
                int[] query = queries[i];
                int lm = LBinarySearch(candles, query[0]);
                int rm = RBinarySearch(candles, query[1]) - 1;

                if (lm < rm)
                    result[i] = candles[rm] - candles[lm] - (rm - lm);
                else
                    result[i] = 0;
            }

            return result;
        }

        public int LBinarySearch(List<int> ci, int lb)
        {
            int l = 0, r = ci.Count;

            while (l < r)
            {
                int m = l + (r - l) / 2;

                if (ci[m] >= lb)
                    r = m;
                else
                    l = m + 1;
            }

            return l;
        }

        public int RBinarySearch(List<int> ci, int rb)
        {
            int l = 0, r = ci.Count;

            while (l < r)
            {
                int m = l + (r - l) / 2;
                if (ci[m] <= rb)
                    l = m + 1;
                else
                    r = m;
            }

            return l;
        }
    }
}
