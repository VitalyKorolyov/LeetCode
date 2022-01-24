using System.Collections.Generic;
using System.Linq;

namespace LeetCode.String.Medium.TopKFrequentWords
{
    //https://leetcode.com/problems/top-k-frequent-words/
    public class Solution
    {
        public IList<string> TopKFrequent(string[] words, int k)
        {
            var stringTofreq = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (stringTofreq.ContainsKey(words[i]))
                {
                    stringTofreq[words[i]]++;
                    continue;
                }

                stringTofreq.Add(words[i], 1);
            }

            var sortedDict = new SortedDictionary<int, List<string>>();
            foreach (var item in stringTofreq)
            {
                int occurrences = item.Value;
                var word = item.Key;
                if (sortedDict.ContainsKey(occurrences))
                {
                    sortedDict[occurrences].Add(word);
                    sortedDict[occurrences].Sort();
                }
                else
                {
                    sortedDict[occurrences] = new List<string>() { word };
                }
            }

            var ans = new List<string>();
            foreach (var item in sortedDict.Reverse())
            {
                if (k == 0) break;
                foreach (var word in item.Value)
                {
                    ans.Add(word);
                    k--;
                    if (k == 0) break;
                }
            }
            return ans;
        }
    }
}
