namespace LeetCode.Array.Medium.MeetingRoomsII;

//https://leetcode.com/problems/meeting-rooms-ii/
public class Solution
{
    public int MinMeetingRooms(int[][] intervals)
    {
        int[] starts = new int[intervals.Length];
        int[] ends = new int[intervals.Length];

        for (int i = 0; i < intervals.Length; i++)
        {
            starts[i] = intervals[i][0];
            ends[i] = intervals[i][1];
        }

        System.Array.Sort(starts);
        System.Array.Sort(ends);

        int count = 0;

        for (int i = 0, j = 0; i < intervals.Length;)
        {
            if (starts[i++] < ends[j]) count++;
            else j++;
        }

        return count;
    }
}