namespace LeetCode.LinkedList.Easy.LinkedListCycle
{
    //https://leetcode.com/problems/linked-list-cycle/
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x, ListNode y)
        {
            val = x;
            next = y;
        }
    }

    public static class Solution
    {
        public static bool HasCycle(ListNode head)
        {
            if (head == null) return false;

            var slow = head;
            var fast = head.next;

            while (slow != fast)
            {
                if (slow == null || fast == null) return false;

                slow = slow.next;
                fast = fast.next?.next;
            }

            return true;
        }
    }
}