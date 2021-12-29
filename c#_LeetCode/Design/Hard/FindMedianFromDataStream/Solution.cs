using System.Collections.Generic;

namespace LeetCode.Design.Hard.FindMedianFromDataStream
{
    //https://leetcode.com/problems/find-median-from-data-stream/
    public class MedianFinder
    {
        private List<int> array;

        public MedianFinder()
        {
            array = new List<int>();
        }

        public void AddNum(int num)
        {
            var pos = array.BinarySearch(num);
            if (pos < 0)
            {
                pos = ~pos;
            }

            array.Insert(pos, num);
        }

        public double FindMedian()
        {
            var middle = array.Count / 2;

            if (array.Count % 2 == 0)
            {
                return (array[middle - 1] + array[middle]) / 2.0;
            }

            return array[middle];
        }
    }
}