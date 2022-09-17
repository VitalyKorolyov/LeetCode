using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Array.Hard.SlidingWindowMaximum
{
    //https://leetcode.com/problems/sliding-window-maximum/
    public class Solution
    {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            var res = new List<int>();
            var sortedHash = new SortedDictionary<int, int>(new Comp());

            for (int i = 0, j = 0; i < nums.Length; i++)
            {
                if(i - j >= k)
                {
                    res.Add(sortedHash.Keys.ElementAt(0));

                    Decrease(sortedHash, nums[j]);
                    j++;
                }

                Add(sortedHash, nums[i]);
            }

            res.Add(sortedHash.Keys.ElementAt(0));
            return res.ToArray();
        }

        private void Add(SortedDictionary<int, int> sortedHash, int value)
        {
            if (sortedHash.ContainsKey(value))
                sortedHash[value]++;
            else sortedHash.Add(value, 1);
        }

        private void Decrease(SortedDictionary<int, int> sortedHash, int value)
        {
            sortedHash[value]--;
            if (sortedHash[value] == 0) sortedHash.Remove(value);
        }

        public class Comp : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                return y.CompareTo(x);
            }
        }
    }
}
