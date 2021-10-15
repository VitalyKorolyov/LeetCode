namespace LeetCode.LinkedList.Medium.ReorderList
{
    //https://leetcode.com/problems/reorder-list/
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
        public void ReorderList(ListNode head)
        {
            var slow = head;
            var fast = head;

            while (fast?.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            var middle = slow;
            ListNode prev = null;

            while (middle != null)
            {
                var next = middle.next;
                middle.next = prev;

                prev = middle;
                middle = next;
            }

            middle = prev;
            var start = head;

            while (middle?.next != null)
            {
                var next = start.next;
                var mNext = middle.next;

                start.next = middle;
                middle.next = next;

                middle = mNext;
                start = next;
            }
        }
    }
}