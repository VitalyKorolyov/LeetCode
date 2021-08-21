namespace LeetCode.LinkedList.Medium.LinkedListCycleII
{
    //https://leetcode.com/problems/linked-list-cycle-ii/
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    public class Solution
    {
        public static ListNode DetectCycle(ListNode head)
        {
            var cycle = FindCycle(head);
            if (cycle == null) return null;

            while (cycle != head)
            {
                cycle = cycle.next;
                head = head.next;
            }

            return head;
        }

        public static ListNode FindCycle(ListNode head)
        {
            var slow = head;
            var fast = head;

            while (fast?.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast) return slow;
            }

            return null;
        }
    }
}