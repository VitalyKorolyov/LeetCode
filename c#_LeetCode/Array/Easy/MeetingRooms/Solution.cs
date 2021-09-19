namespace LeetCode.Array.Easy.MeetingRooms
{
    //https://leetcode.com/problems/meeting-rooms/
    public class Solution
    {
        public bool CanAttendMeetings(int[][] intervals)
        {
            if (intervals.Length == 0 || intervals.Length == 1) return true;

            System.Array.Sort(intervals, (x, y) => x[0].CompareTo(y[0]));

            for (int i = 1; i < intervals.Length; i++)
            {
                if (intervals[i - 1][1] >= intervals[i][0]) return false;
            }

            return true;
        }
    }
}