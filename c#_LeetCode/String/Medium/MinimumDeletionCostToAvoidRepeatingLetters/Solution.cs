using System.Collections.Generic;

namespace LeetCode.String.Medium.MinimumDeletionCostToAvoidRepeatingLetters
{
    //https://leetcode.com/problems/minimum-deletion-cost-to-avoid-repeating-letters/
    public class Solution
    {
        public int MinCost(string s, int[] cost)
        {
            var prevIndex = 0;
            var i = 1;
            int minConst = 0;

            while (i < s.Length)
            {
                while (i < s.Length && s[i] == s[prevIndex])
                {
                    var costCurrent = cost[i];
                    var costPrev = cost[prevIndex];

                    if (costPrev >= costCurrent)
                    {
                        minConst += costCurrent;
                        i++;
                    }
                    else
                    {
                        minConst += costPrev;
                        prevIndex = i;
                        i++;
                    }
                }

                prevIndex = i;
                i++;
            }

            return minConst;
        }
    }
}