using System.Collections.Generic;

namespace LeetCode.HashTable.Medium.SnapshotArray
{
    //https://leetcode.com/problems/snapshot-array/
    public class SnapshotArray
    {
        private int snapshotId = 0;
        private Dictionary<int, int>[] snapshots;

        public SnapshotArray(int length)
        {
            snapshots = new Dictionary<int, int>[length];
        }

        public void Set(int index, int val)
        {
            if (snapshots[index] == null)
                snapshots[index] = new Dictionary<int, int>();

            if (snapshots[index].ContainsKey(snapshotId))
                snapshots[index][snapshotId] = val;
            else snapshots[index].Add(snapshotId, val);
        }

        public int Snap()
        {
            return snapshotId++;
        }

        public int Get(int index, int snap_id)
        {
            if (snapshots[index] == null) return 0;

            if (snapshots[index].ContainsKey(snap_id)) return snapshots[index][snap_id];

            while (!snapshots[index].ContainsKey(snap_id) && snap_id != -1)
                snap_id--;

            return snap_id == -1 ? 0 : snapshots[index][snap_id];
        }
    }
}
