using System.Collections.Generic;

namespace LeetCode.LinkedList.Medium.CopyListWithRandomPointer
{
    //https://leetcode.com/problems/copy-list-with-random-pointer/
    public class Node
    {
        public int val;
        public Node next;
        public Node random;

        public Node(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }

    public class Solution
    {
        public Node CopyRandomList(Node head)
        {
            if (head == null) return head;

            Dictionary<Node, Node> oldToNew = new();

            var current = head;
            while(current != null)
            {
                oldToNew.Add(current, new Node(current.val));
                current = current.next;
            }

            foreach (var item in oldToNew)
            {
                if(item.Key.next != null)
                    item.Value.next = oldToNew[item.Key.next];

                if(item.Key.random != null)
                    item.Value.random = oldToNew[item.Key.random];
            }

            return oldToNew[head];
        }
    }
}
