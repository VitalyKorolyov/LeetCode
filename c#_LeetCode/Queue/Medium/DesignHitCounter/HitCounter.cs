using System.Collections.Generic;

namespace LeetCode.Queue.Medium.DesignHitCounter
{
    //https://leetcode.com/problems/design-hit-counter/
    public class HitCounter
    {
        private readonly Queue<int> queue = new();

        public void Hit(int timestamp)
        {
            queue.Enqueue(timestamp);
        }

        public int GetHits(int timestamp)
        {
            while (queue.Count > 0)
            {
                int diff = timestamp - queue.Peek();
                if (diff >= 300) queue.Dequeue();
                else break;
            }

            return queue.Count;
        }
    }
}