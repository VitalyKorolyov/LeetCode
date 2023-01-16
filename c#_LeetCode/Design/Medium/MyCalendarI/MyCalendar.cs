using System;
using System.Collections.Generic;

namespace LeetCode.Design.Medium.MyCalendarI;

//https://leetcode.com/problems/my-calendar-i/description/

public class MyCalendar
{
    private readonly List<Tuple<int, int>> events = new();
    private readonly IComparer<Tuple<int, int>> comparer = 
        Comparer<Tuple<int, int>>.Create((x, y) => x.Item1.CompareTo(y.Item1));

    public bool Book(int start, int end)
    {
        int result = BinarySearch(start, end, events);
        if(result != -1) return false;

        events.Add(Tuple.Create(start, end));
        events.Sort(comparer);

        return true;
    }

    private int BinarySearch(int startNew, int endNew, List<Tuple<int, int>> events)
    {
        int left = 0;
        int right = events.Count - 1;

        while (left <= right)
        {
            int pivot = left + (right - left) / 2;
            var (sEvent, eEvent) = events[pivot];

            if ((startNew >= sEvent && startNew < eEvent) || (startNew < sEvent && endNew > sEvent))
                return pivot;

            if (sEvent > startNew)
                right = pivot - 1;
            else
                left = pivot + 1;
        }

        return -1;
    }
}
