namespace LeetCode.LinkedList.Easy.ReverseLinkedList
{
    //https://leetcode.com/problems/reverse-linked-list/
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
        public static ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;

            while (head != null)
            {
                var next = head.next;
                head.next = prev;
                prev = head;
                head = next;
            }

            return prev;
        }

        public static ListNode Recursive(ListNode head)
        {
            return Revert(head, null);
        }

        private static ListNode Revert(ListNode head, ListNode newHead)
        {
            if (head == null)
                return newHead;

            var next = head.next;

            head.next = newHead;
            newHead = head;

            return Revert(next, newHead);
        }
    }
}