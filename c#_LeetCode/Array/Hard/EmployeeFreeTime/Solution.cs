using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array.Hard.EmployeeFreeTime
{
    //https://leetcode.com/problems/employee-free-time/
    public class Interval
    {
        public int start;
        public int end;

        public Interval() { }
        public Interval(int _start, int _end)
        {
            start = _start;
            end = _end;
        }
    }


    public class Solution
    {
        public IList<Interval> EmployeeFreeTime(IList<IList<Interval>> schedule)
        {
            List<Interval> merged = new();
            var priorityQueue = new PriorityQueue<Interval, int>();

            foreach (var scheduleItem in schedule)
                foreach (var interval in scheduleItem)
                    priorityQueue.Enqueue(interval, interval.start);

            Interval prev = priorityQueue.Peek();
            while(priorityQueue.Count > 0)
            {
                var interval = priorityQueue.Dequeue();

                if (prev.end < interval.start)
                {
                    merged.Add(new Interval(prev.end, interval.start));
                    prev = interval;
                }
                else
                {
                    if (prev.end < interval.end)
                        prev = interval;
                }
            }

            return merged;
        }
    }
}
