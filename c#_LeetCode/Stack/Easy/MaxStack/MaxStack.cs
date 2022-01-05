using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Stack.Easy.MaxStack
{
    //https://leetcode.com/problems/max-stack/
    public class Node
    {
        public int Value { get; set; }
    }

    public class MaxStack
    {
        private readonly SortedDictionary<int, List<Node>> _dictionary;
        private readonly LinkedList<Node> _stack;

        public MaxStack()
        {
            _stack = new LinkedList<Node>();
            _dictionary = new SortedDictionary<int, List<Node>>();
        }

        //Log(n)
        public void Push(int x)
        {
            var node = new Node {Value = x};
            _stack.AddFirst(node);

            if (!_dictionary.ContainsKey(x))
            {
                _dictionary.Add(x, new List<Node> {node});
            }
            else
            {
                var head = _dictionary[x];
                head.Add(node);
            }
        }

        //O(1)
        public int Pop()
        {
            var node = _stack.First.Value;

            var list = _dictionary[node.Value];
            if (list.Count == 1)
            {
                _dictionary.Remove(node.Value);
            }
            else
            {
                list.RemoveAt(list.Count - 1);
            }

            _stack.RemoveFirst();

            return node.Value;
        }

        //O(1)
        public int Top()
        {
            return _stack.First.Value.Value;
        }

        //O(1)
        public int PeekMax()
        {
            return _dictionary.Last().Key;
        }

        //O(1)
        public int PopMax()
        {
            var list = _dictionary.Last().Value;

            var last = list[list.Count - 1];

            _stack.Remove(last);
            list.RemoveAt(list.Count - 1);

            if (!list.Any()) _dictionary.Remove(last.Value);

            return last.Value;
        }
    }
}