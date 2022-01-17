using System.Collections.Generic;

namespace LeetCode.Array.Medium.CinemaSeatAllocation
{
    //https://leetcode.com/problems/cinema-seat-allocation/
    public class Solution
    {
        public int MaxNumberOfFamilies(int n, int[][] reservedSeats)
        {
            int result = 0;
            var rows = new Dictionary<int, bool[]>();

            foreach (var r in reservedSeats)
            {
                if (!rows.ContainsKey(r[0] - 1))
                    rows[r[0] - 1] = new bool[10];

                rows[r[0] - 1][r[1] - 1] = true;
            }

            foreach (var row in rows)
                result += Count(row.Value);

            return result + 2 * (n - rows.Count);
        }

        private int Count(bool[] row)
        {
            int count = 0;
            if (!row[1] && !row[2] && !row[3] && !row[4])
                count++;

            if (!row[5] && !row[6] && !row[7] && !row[8])
                count++;

            if (count == 0 && !row[3] && !row[4] && !row[5] && !row[6])
                count++;

            return count;
        }
    }
}
