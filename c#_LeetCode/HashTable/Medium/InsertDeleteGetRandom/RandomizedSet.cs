using System;
using System.Collections.Generic;

namespace LeetCode.HashTable.Medium.InsertDeleteGetRandom
{
    //https://leetcode.com/problems/insert-delete-getrandom-o1/
    public class RandomizedSet
    {
        private readonly Dictionary<int, int> _hash;
        private readonly List<int> _list;
        private readonly Random _random;

        public RandomizedSet()
        {
            _hash = new();
            _list = new List<int>();
            _random = new Random();
        }

        public bool Insert(int val)
        {
            if (_hash.ContainsKey(val)) return false;

            _hash.Add(val, _list.Count);
            _list.Add(val);

            return true;
        }

        public bool Remove(int val)
        {
            if (!_hash.ContainsKey(val)) return false;

            var currentIndex = _hash[val];
            var lastIndex = _list.Count - 1;

            _list[currentIndex] = _list[lastIndex];
            _hash[_list[currentIndex]] = currentIndex;

            _list.RemoveAt(lastIndex);
            _hash.Remove(val);

            return true;
        }

        public int GetRandom()
        {
            int index = _random.Next(0, _list.Count);
            return _list[index];
        }
    }
}
