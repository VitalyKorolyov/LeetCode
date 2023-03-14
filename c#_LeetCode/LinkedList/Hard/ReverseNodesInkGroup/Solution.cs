namespace LeetCode.LinkedList.Hard.ReverseNodesInkGroup;

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

//https://leetcode.com/problems/reverse-nodes-in-k-group/description/
public class Solution
{
    public ListNode ReverseKGroup(ListNode head, int k)
    {
        if (head == null || head.next == null || k == 1) return head;

        ListNode dummyhead = new(0) { next = head };
        ListNode begin = dummyhead;

        for (int i = 1; head != null; i++)
        {
            if (i % k == 0)
            {
                begin = Reverse(begin, head.next);
                head = begin.next;
            }
            else head = head.next;
        }

        return dummyhead.next;
    }

    public ListNode Reverse(ListNode start, ListNode end)
    {
        ListNode current = start.next;
        ListNode first = current;
        ListNode prev = start;

        while (current != end)
        {
            ListNode tempNext = current.next;

            current.next = prev;
            prev = current;

            current = tempNext;
        }

        start.next = prev;
        first.next = current;

        return first;
    }
}