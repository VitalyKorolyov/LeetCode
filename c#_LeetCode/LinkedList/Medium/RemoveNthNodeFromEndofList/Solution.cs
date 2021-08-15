namespace LeetCode.LinkedList.Medium.RemoveNthNodeFromEndofList
{
    //https://leetcode.com/problems/remove-nth-node-from-end-of-list/
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
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var f = head;
            var s = head;

            for (var i = 0; i < n; i++)
                f = f.next;

            if (f == null) return head.next;

            while (f.next != null)
            {
                s = s.next;
                f = f.next;
            }

            s.next = s.next.next;

            return head;
        }
    }
}