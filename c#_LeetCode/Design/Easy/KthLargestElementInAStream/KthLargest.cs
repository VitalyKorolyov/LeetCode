using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Design.Easy.KthLargestElementInAStream
{
    //https://leetcode.com/problems/kth-largest-element-in-a-stream/
    public class KthLargest
    {
        private readonly List<int> _list;
        private readonly int _k;

        public KthLargest(int k, int[] nums)
        {
            _k = k;
            _list = nums.OrderBy(x => x).ToList();
        }

        public int Add(int val)
        {
            var index = _list.BinarySearch(val);

            if (index < 0)
                _list.Insert(~index, val);
            else 
                _list.Insert(index, val);

            return _list[_list.Count - _k];
        }
    }
}
