using System.Collections.Generic;

namespace LeetCode.LinkedList.Medium.RemoveDuplicatesFromAnUnsortedLinkedList;

//https://leetcode.com/problems/remove-duplicates-from-an-unsorted-linked-list/description/

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
    public ListNode DeleteDuplicatesUnsorted(ListNode head)
    {
        Dictionary<int, int> nodeCounter = new();
        ListNode dummy = new(0, head);

        while (head != null)
        {
            if (nodeCounter.ContainsKey(head.val))
                nodeCounter[head.val]++;
            else nodeCounter[head.val] = 1;

            head = head.next;
        }

        ListNode prev = dummy;
        head = dummy.next;

        while(head != null)
        {
            if (nodeCounter[head.val] > 1)
                prev.next = head.next;
            else
                prev = head;

            head = head.next;
        }

        return dummy.next;
    }
}
