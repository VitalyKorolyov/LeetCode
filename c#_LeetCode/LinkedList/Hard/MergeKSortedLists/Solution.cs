using System.Linq;

namespace LeetCode.LinkedList.Hard.MergeKSortedLists
{
    //https://leetcode.com/problems/merge-k-sorted-lists/
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
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (!lists.Any()) return null;

            int interval = 1;
            while (interval < lists.Length)
            {
                for (int i = 0; i + interval < lists.Length; i += interval * 2)
                    lists[i] = Merge(lists[i], lists[i + interval]);

                interval *= 2;
            }

            return lists[0];
        }

        private ListNode Merge(ListNode l1, ListNode l2)
        {
            var res = new ListNode();
            var head = res;

            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    head.next = new ListNode(l1.val);
                    l1 = l1.next;
                }
                else
                {
                    head.next = new ListNode(l2.val);
                    l2 = l2.next;
                }

                head = head.next;
            }

            if (l1 != null)
            {
                head.next = l1;
            }

            if (l2 != null)
            {
                head.next = l2;
            }

            return res.next;
        }
    }
}