using System.Collections.Generic;

namespace LeetCode.Design.Hard.FindMedianFromDataStream
{
    //https://leetcode.com/problems/find-median-from-data-stream/

    //O(logN)
    public class MedianFinder
    {
        private PriorityQueue<int, int> max = new PriorityQueue<int, int>(new MaxComp());
        private PriorityQueue<int, int> min = new PriorityQueue<int, int>();

        public void AddNum(int num)
        {
            if (max.Count == 0 || max.Peek() >= num)
                max.Enqueue(num, num);
            else
                min.Enqueue(num, num);

            if (max.Count > min.Count + 1)
            {
                var maxValue = max.Dequeue();
                min.Enqueue(maxValue, maxValue);
            }
            else if (max.Count < min.Count)
            {
                var minValue = min.Dequeue();
                max.Enqueue(minValue, minValue);
            }
        }

        public double FindMedian()
        {
            var isSizeOdd = (max.Count + min.Count) % 2 != 0;

            if (isSizeOdd)
                return max.Peek();
            else
                return (max.Peek() + min.Peek()) / 2.0;
        }
    }

    public class MaxComp : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y.CompareTo(x);
        }
    }

    //O(n)
    //private List<int> array;

    //public MedianFinder()
    //{
    //    array = new List<int>();
    //}

    //public void AddNum(int num)
    //{
    //    var pos = array.BinarySearch(num);
    //    if (pos < 0)
    //    {
    //        pos = ~pos;
    //    }

    //    array.Insert(pos, num);
    //}

    //public double FindMedian()
    //{
    //    var middle = array.Count / 2;

    //    if (array.Count % 2 == 0)
    //    {
    //        return (array[middle - 1] + array[middle]) / 2.0;
    //    }

    //    return array[middle];
    //}
}