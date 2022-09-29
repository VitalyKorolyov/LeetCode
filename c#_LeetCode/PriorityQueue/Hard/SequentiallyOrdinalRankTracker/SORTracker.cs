using System.Collections.Generic;

namespace LeetCode.PriorityQueue.Hard.SequentiallyOrdinalRankTracker
{
    //https://leetcode.com/problems/sequentially-ordinal-rank-tracker/
    public class SORTracker
    {
        private int index = 0;

        private readonly SortedList<Record, Record> list = new(Comparer<Record>.Create((a, b) => 
            a.Score == b.Score ? a.Name.CompareTo(b.Name) : b.Score.CompareTo(a.Score)));

        public void Add(string name, int score)
        {
            var record = new Record { Name = name, Score = score };
            list.Add(record, record);
        }

        public string Get() => list.Values[index++].Name;
    }

    public class Record
    {
        public int Score { get; set; }
        public string Name { get; set; }
    }
}
