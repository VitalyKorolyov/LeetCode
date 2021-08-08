namespace LeetCode.LinkedList.Easy.RemoveDuplicatesFromSortedList
{
    //https://leetcode.com/problems/remove-duplicates-from-sorted-list/
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
        public ListNode DeleteDuplicates(ListNode head)
        {
            var fake = new ListNode(0);
            fake.next = head;

            var cur = fake;

            while (cur.next != null && cur.next.next != null)
            {
                if (cur.next.val == cur.next.next.val)
                {
                    cur.next = cur.next.next;
                }
                else
                {
                    cur = cur.next;
                }
            }

            return fake.next;
        }
    }
}