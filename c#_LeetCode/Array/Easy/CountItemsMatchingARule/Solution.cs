using System.Collections.Generic;

namespace LeetCode.Array.Easy.CountItemsMatchingARule
{
    //https://leetcode.com/problems/count-items-matching-a-rule/
    public class Solution
    {
        private static Dictionary<string, int> nameToIndex = new Dictionary<string, int>()
        {
            {"type", 0},
            {"color", 1},
            {"name", 2}
        };

        public static int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            var counter = 0;
            var index = nameToIndex[ruleKey];

            foreach (var item in items)
            {
                if (ruleValue == item[index]) counter++;
            }

            return counter;
        }
    }
}