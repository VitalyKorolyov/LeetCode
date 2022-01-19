using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Array.Medium.SearchSuggestionsSystem
{
    //https://leetcode.com/problems/search-suggestions-system/
    public class Solution
    {
        public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
        {
            System.Array.Sort(products); //nlogn

            var res = new List<IList<string>>();

            for (int i = 0; i < searchWord.Length; i++) //k
            {
                var search = new List<string>();

                foreach (var product in products) //n
                {
                    if (search.Count == 3) break;

                    for (int j = 0; j <= i && j < product.Length; j++)
                    {
                        if(product[j] == searchWord[j] && j == i)
                        {
                            search.Add(product);
                            break;
                        }

                        if (product[j] != searchWord[j]) break;
                    }
                }

                res.Add(search);
            }

            return res;
        }
    }
}
