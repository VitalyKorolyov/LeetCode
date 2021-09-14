using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.LinkedList.Medium.PrintImmutableLinkedListInReverse
{
    //https://leetcode.com/problems/print-immutable-linked-list-in-reverse/

    public class ImmutableListNode
    {
        private int _value;
        private ImmutableListNode _next;

        public ImmutableListNode(int value, ImmutableListNode next)
        {
            _value = value;
            _next = next;
        }

        public void PrintValue(){
            Console.WriteLine(_value);    
        }

        public ImmutableListNode GetNext(){
            return _next;
        }
    }

    public class Solution
    {
        public void PrintLinkedListInReverse(ImmutableListNode head)
        {
            var length = CalcLength(head);

            var groupSize = System.Math.Sqrt(length) + 1;
            var groupStack = new Stack<ImmutableListNode>();

            var savedH = head;
            var index = 0;

            while (savedH != null)
            {
                if (index % groupSize == 0)
                    groupStack.Push(savedH);

                index++;
                savedH = savedH.GetNext();
            }

            PrintEachHeadNodesInReverseOrder(groupStack);
        }

        private void PrintEachHeadNodesInReverseOrder(Stack<ImmutableListNode> headNodes)
        {
            ImmutableListNode startNode = null;

            while (headNodes.Count > 0)
            {
                var endNode = startNode;
                startNode = headNodes.Pop();
                var tempNode = startNode;

                var stack = new Stack<ImmutableListNode>();
                while (tempNode != endNode)
                {
                    stack.Push(tempNode);
                    tempNode = tempNode.GetNext();
                }

                while (stack.Count > 0)
                {
                    stack.Pop().PrintValue();
                }
            }
        }

        //O(n^2)
            private void ConstMemory(ImmutableListNode head)
        {
            var length = CalcLength(head);

            for (int i = length - 1; i >= 0; i--)
            {
                var savedHead = head;

                for (int j = 0; j < i; j++)
                    savedHead = savedHead.GetNext();

                savedHead.PrintValue();
            }
        }

        public int CalcLength(ImmutableListNode head)
        {
            var length = 0;

            while (head != null)
            {
                head = head.GetNext();
                length++;
            }

            return length;
        }

        //O(n) - runtime, O(n) - memory
        public void Recursive(ImmutableListNode head)
        {
            if(head == null) return;

            Recursive(head.GetNext());
            head.PrintValue();
        }


        //Stack - O(n), O(n) - memory
        public void PrintLinkedListInReverseStack(ImmutableListNode head)
        {
            var stack = new Stack<ImmutableListNode>();

            while (head != null)
            {
                stack.Push(head);
                head = head.GetNext();
            }

            while (stack.Count > 0)
            {
                stack.Pop().PrintValue();
            }
        }
    }
}