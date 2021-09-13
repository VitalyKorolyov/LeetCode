using System;
using System.Collections.Generic;

namespace LeetCode.HashTable.Medium
{
    //https://leetcode.com/problems/lru-cache/
    public class LRUCache
    {
        private readonly Dictionary<int, LinkedListNode<Tuple<int, int>>> _cache;
        private readonly LinkedList<Tuple<int, int>> _ranks;

        private readonly int _capacity;

        public LRUCache(int capacity)
        {
            _cache = new Dictionary<int, LinkedListNode<Tuple<int, int>>>(capacity);
            _ranks = new LinkedList<Tuple<int, int>>();
            _capacity = capacity;
        }

        public int Get(int key)
        {
            if (!_cache.ContainsKey(key)) return -1;

            var value = _cache[key];
            _ranks.Remove(value);
            _ranks.AddFirst(value);

            return value.Value.Item2;
        }

        public void Put(int key, int value)
        {
            if (_cache.Count < _capacity)
            {
                if (_cache.ContainsKey(key))
                {
                    RemoveExistedKey(key, value);
                }
                else
                {
                    var valueToAdd = new LinkedListNode<Tuple<int, int>>(Tuple.Create(key, value));
                    _cache.Add(key, valueToAdd);
                    _ranks.AddFirst(valueToAdd);
                }
            }
            else
            {
                if (_cache.ContainsKey(key))
                {
                    RemoveExistedKey(key, value);
                }
                else
                {
                    var valueToReplace = _ranks.Last;
                    var valueToAdd = new LinkedListNode<Tuple<int, int>>(Tuple.Create(key, value));

                    _ranks.RemoveLast();

                    _cache.Remove(valueToReplace.Value.Item1);
                    _cache.Add(key, valueToAdd);

                    _ranks.AddFirst(valueToAdd);
                }
            }
        }

        private void RemoveExistedKey(int key, int value)
        {
            var valueToAdd = new LinkedListNode<Tuple<int, int>>(Tuple.Create(key, value));

            var valueAdded = _cache[key];

            _cache.Remove(key);
            _ranks.Remove(valueAdded);

            _ranks.AddFirst(valueToAdd);
            _cache.Add(key, valueToAdd);
        }
    }

}