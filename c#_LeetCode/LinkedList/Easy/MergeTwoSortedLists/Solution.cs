namespace LeetCode.LinkedList.Easy.MergeTwoSortedLists
{
    //https://leetcode.com/problems/merge-two-sorted-lists/
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
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            var dummy = new ListNode();
            var res = dummy;

            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    dummy.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    dummy.next = l2;
                    l2 = l2.next;
                }

                dummy = dummy.next;
            }

            dummy.next = l1 ?? l2;

            return res.next;
        }
    }
}