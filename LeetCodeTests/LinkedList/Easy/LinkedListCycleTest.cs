using System.Collections.Generic;
using System.Linq;
using LeetCode.LinkedList.Easy.LinkedListCycle;
using Xunit;

namespace LeetCodeTests.LinkedList.Easy
{
    public class LinkedListCycleTest
    {
        [Fact]
        public void Test()
        {
            var head = new ListNode(1, new ListNode(3, null));

            Assert.False(Solution.HasCycle(head));

            var first = new ListNode(10, new ListNode(11, null));
            head = new ListNode(1, first);
            first.next.next = head;

            Assert.True(Solution.HasCycle(head));

            Assert.False(Solution.HasCycle(null));
        }
    }
}