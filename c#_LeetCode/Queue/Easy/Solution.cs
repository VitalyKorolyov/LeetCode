using System.Collections.Generic;

namespace LeetCode.Queue.Easy
{
    //https://leetcode.com/problems/implement-stack-using-queues/
    public class MyStack
    {
        private Queue<int> queue = new();

        public void Push(int x)
        {
            var n = queue.Count;
            queue.Enqueue(x);

            while (n != 0)
            {
                var value = queue.Dequeue();
                queue.Enqueue(value);
                n--;
            }
        }

        public int Pop()
        {
            return queue.Dequeue();
        }

        public int Top()
        {
            return queue.Peek();
        }

        public bool Empty()
        {
            return queue.Count == 0;
        }
    }


    //private Queue<int> queue1 = new();
    //private Queue<int> queue2 = new();

    //public void Push(int x)
    //{
    //    if (queue1.Count > 0)
    //        queue1.Enqueue(x);
    //    else
    //        queue2.Enqueue(x);
    //}

    //public int Pop()
    //{
    //    var (queue, empty) = GetQueues();

    //    while (queue.Count != 1)
    //        empty.Enqueue(queue.Dequeue());

    //    return queue.Dequeue();
    //}

    //public int Top()
    //{
    //    var (queue, empty) = GetQueues();

    //    while (queue.Count != 1)
    //        empty.Enqueue(queue.Dequeue());

    //    var last = queue.Dequeue();
    //    empty.Enqueue(last);

    //    return last;
    //}

    //public bool Empty()
    //{
    //    return queue1.Count == 0 && queue2.Count == 0;
    //}

    //private (Queue<int>, Queue<int>) GetQueues()
    //{
    //    var queue = queue1.Count > 0 ? queue1 : queue2;
    //    var empty = queue1.Count == 0 ? queue1 : queue2;

    //    return (queue, empty);
    //}
}
