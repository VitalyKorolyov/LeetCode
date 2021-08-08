namespace LeetCode.LinkedList.Easy.PalindromeLinkedList
{
    //https://leetcode.com/problems/palindrome-linked-list/

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
        public static bool IsPalindrome(ListNode head)
        {
            var fast = head;
            var slow = head;

            while (fast?.next?.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            ListNode prev = null;
            while (slow != null)
            {
                var next = slow.next;
                slow.next = prev;
                prev = slow;
                slow = next;
            }

            while (prev != null && head != null)
            {
                if (prev.val != head.val) return false;
                prev = prev.next;
                head = head.next;
            }

            return true;
        }
    }
}