using System.Collections.Generic;

namespace LeetCode.HashTable.Hard.DataStreamAsDisjointIntervals
{
    //https://leetcode.com/problems/data-stream-as-disjoint-intervals/
    public class SummaryRanges
    {
        private readonly List<int> numbers;

        public SummaryRanges()
        {
            numbers = new List<int>();
        }

        public void AddNum(int val)
        {
            var pos = numbers.BinarySearch(val);
            if(pos < 0)
                numbers.Insert(~pos, val);
        }

        public int[][] GetIntervals()
        {
            var result = new List<int[]>();

            if (numbers.Count == 0)
                return result.ToArray();

            int start = numbers[0];
            int end = numbers[0];
            bool added = false;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] - numbers[i - 1] == 1)
                {
                    end = numbers[i];
                }
                else
                {
                    result.Add(new int[2] { start, end });
                    start = numbers[i];
                    end = numbers[i];
                }
            }

            if (!added)
            {
                result.Add(new int[2] { start, end });
            }

            return result.ToArray();
        }
    }
}
