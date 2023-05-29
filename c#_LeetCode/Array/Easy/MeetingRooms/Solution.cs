﻿namespace LeetCode.Array.Easy.MeetingRooms;

//https://leetcode.com/problems/meeting-rooms/
public class Solution
{
    public bool CanAttendMeetings(int[][] intervals)
    {
        System.Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        for (int i = 1; i < intervals.Length; i++)
            if (intervals[i - 1][1] > intervals[i][0]) return false;

        return true;
    }
}