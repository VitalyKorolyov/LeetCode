using System.Collections.Generic;

namespace LeetCode.Array.Easy.MovingAverageFromDataStream
{
    //https://leetcode.com/problems/moving-average-from-data-stream/
    public class MovingAverage
    {
        private readonly Queue<int> _queue;
        private double _currentSum;
        private readonly int _size;

        public MovingAverage(int size)
        {
            _queue = new Queue<int>(size);
            _size = size;
        }

        public double Next(int val)
        {
            var currentValue = GetCurrentValue();

            _currentSum -= currentValue;
            _currentSum += val;
            _queue.Enqueue(val);

            return _currentSum / _queue.Count;
        }

        private int GetCurrentValue()
        {
            return _size != _queue.Count ? 0 : _queue.Dequeue();
        }
    }

}