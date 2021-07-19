using System.Collections.Generic;

namespace LeetCode.Array.Easy.KidsWithTheGreatestNumberOfCandies
{
    //https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/
    public class Solution
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            IList<bool> listResult = new List<bool>(candies.Length);
            
            for (int i = 0; i < candies.Length; i++)
            {
                var currentCandies = candies[i] + extraCandies;
                var result = true;

                for (int j = 0; j < candies.Length; j++)
                {
                    if (currentCandies >= candies[j]) continue;

                    result = false;
                    break;
                }

                listResult.Add(result);
            }

            return listResult;
        }
    }
}