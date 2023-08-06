using System.Collections.Generic;
using System.Linq;

namespace LeetCode.LinkedList.Hard.MergeKSortedLists;

//https://leetcode.com/problems/merge-k-sorted-lists/
public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        if(lists == null || !lists.Any()) return null;

        ListNode head = new(0);
        PriorityQueue<ListNode, int> priorityQueue = new();

        foreach(ListNode list in lists.Where(x => x != null))
            priorityQueue.Enqueue(list, list.val);

        ListNode node = head;
        while(priorityQueue.Count > 0)
        {
            var currentList = priorityQueue.Dequeue();

            node.next = new ListNode(currentList.val);
            node = node.next;

            if(currentList.next != null)
                priorityQueue.Enqueue(currentList.next, currentList.next.val);
        }

        return head.next;
    }
}