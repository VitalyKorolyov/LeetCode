using System.Collections.Generic;

namespace LeetCode.HashTable.Hard.LFUCache
{
    //https://leetcode.com/problems/lfu-cache/
    public class LFUCache
    {
        private readonly Dictionary<int, Node> _cache;
        private readonly Dictionary<int, Dll> _dllList;
        private int _minCount;
        private readonly int _capacity;

        public LFUCache(int capacity)
        {
            _capacity = capacity;
            _minCount = 0;
            _cache = new Dictionary<int, Node>(capacity);
            _dllList = new Dictionary<int, Dll>(capacity);
        }

        public int Get(int key)
        {
            if (!_cache.ContainsKey(key)) return -1;

            var node = _cache[key];
            UpdateNodeAndFrequency(node);
            return node.Val;
        }

        public void Put(int key, int value)
        {
            if (_capacity == 0)
                return;

            if (_cache.ContainsKey(key))
            {
                var node = _cache[key];
                node.Val = value;
                UpdateNodeAndFrequency(node);
                return;
            }

            if (_cache.Count == _capacity)
            {
                var node = _dllList[_minCount].RemoveFromTail();

                if (_dllList[_minCount].Size() == 0)
                    _dllList.Remove(_minCount);

                _cache.Remove(node.Key);
            }

            var newNode = new Node(key, value);
            _minCount = 1;
            _cache.Add(key, newNode);

            if (!_dllList.ContainsKey(newNode.Count))
                _dllList.Add(newNode.Count, new Dll());

            _dllList[newNode.Count].Add(newNode);
        }

        private void UpdateNodeAndFrequency(Node node)
        {
            var list = _dllList[node.Count];
            list.Remove(node);

            if (_minCount == node.Count && list.Size() == 0)
            {
                _dllList.Remove(node.Count);
                _minCount++;
            }

            node.Count++;

            if (!_dllList.ContainsKey(node.Count))
                _dllList.Add(node.Count, new Dll());

            _dllList[node.Count].Add(node);
        }
    }

    public class Node
    {
        public int Key;
        public int Val;
        public Node Left;
        public Node Right;
        public int Count;

        public Node(int key, int val, Node left = null, Node right = null)
        {
            Key = key;
            Val = val;
            Left = left;
            Right = right;
            Count = 1;
        }
    }

    public class Dll
    {
        private readonly Node _head;
        private readonly Node _tail;
        private int _size;

        public Dll()
        {
            _head = new Node(0, 0);
            _tail = new Node(0, 0);
            _head.Right = _tail;
            _tail.Left = _head;
            _size = 0;
        }

        public void Add(Node node)
        {
            _head.Right.Left = node;
            node.Right = _head.Right;
            node.Left = _head;
            _head.Right = node;

            _size++;
        }

        public void Remove(Node node)
        {
            node.Left.Right = node.Right;
            node.Right.Left = node.Left;
            _size--;
        }

        public Node RemoveFromTail()
        {
            if (_size <= 0)
                return null;

            var node = _tail.Left;
            Remove(_tail.Left);

            return node;
        }

        public int Size()
        {
            return _size;
        }
    }
}