using System.Collections.Generic;

namespace LeetCode.Array.Medium.FruitIntoBaskets
{
    //https://leetcode.com/problems/fruit-into-baskets/
    public class Solution
    {
        public int TotalFruit(int[] fruits)
        {
            var backet = new Dictionary<int, int>(2);

            var total = 0;
            int start = 0; int end = 0;

            while (start < fruits.Length)
            {
                if (backet.Count < 2 || (backet.Count == 2 && backet.ContainsKey(fruits[start])))
                {
                    var type = fruits[start];

                    if (backet.ContainsKey(type)) backet[type]++;
                    else backet.Add(type, 1);

                    start++;
                }
                else
                {
                    var type = fruits[end];
                    backet[type]--;
                    if (backet[type] == 0) backet.Remove(type);
                    end++;
                }

                total = System.Math.Max(total, start - end);
            }

            return total;
        }
    }
}
