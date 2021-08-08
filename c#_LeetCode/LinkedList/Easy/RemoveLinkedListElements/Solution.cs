namespace LeetCode.LinkedList.Easy.RemoveLinkedListElements
{
    //https://leetcode.com/problems/remove-linked-list-elements/
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
        public ListNode RemoveElements(ListNode head, int val)
        {
            var fake = new ListNode(0);
            fake.next = head;

            var cur = fake;

            while (cur.next != null)
            {
                if (cur.next.val == val)
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