namespace LeetCode.Array.Medium.MeetingRoomsII
{
    //https://leetcode.com/problems/meeting-rooms-ii/
    public class Solution
    {
        public int MinMeetingRooms(int[][] intervals)
        {
            if (intervals == null || intervals.Length == 0) return 0;

            var starts = new int[intervals.Length];
            var ends = new int[intervals.Length];

            for (var i = 0; i < intervals.Length; i++)
            {
                starts[i] = intervals[i][0];
                ends[i] = intervals[i][1];
            }

            System.Array.Sort(starts);
            System.Array.Sort(ends);

            var result = 0;

            for (int i = 0, j = 0; i < starts.Length; i++)
            {
                if (starts[i] < ends[j]) result++;
                else j++;
            }

            return result;
        }
    }
}