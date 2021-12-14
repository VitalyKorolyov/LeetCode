namespace LeetCode.HashTable.Easy.DesignHashMap
{
    //https://leetcode.com/problems/design-hashmap/
    public class Pair
    {
        public int Key;
        public int Value;
        public Pair Next;
    }

    public class MyHashMap
    {
        private const int DefSize = 10000;
        private readonly Pair[] _hashMap;

        public MyHashMap()
        {
            _hashMap = new Pair[DefSize];
        }

        public void Put(int key, int value)
        {
            var hash = CalcHash(key);

            var pair = _hashMap[hash];
            if (pair == null)
            {
                _hashMap[hash] = new Pair {Key = key, Value = value};
            }
            else
            {
                while (pair.Next != null)
                {
                    if(pair.Key == key) break;

                    pair = pair.Next;
                }

                if (pair.Key == key)
                {
                    pair.Value = value;
                }
                else
                {
                    pair.Next = new Pair {Key = key, Value = value};
                }
            }
        }

        public int Get(int key)
        {
            var hash = CalcHash(key);
            var pair = _hashMap[hash];

            if (pair == null) return -1;

            while (pair != null)
            {
                if (pair.Key == key) return pair.Value;

                pair = pair.Next;
            }

            return -1;
        }

        public void Remove(int key)
        {
            var hash = CalcHash(key);
            var pair = _hashMap[hash];

            if(pair == null) return;

            if (pair.Key == key)
            {
                _hashMap[hash] = pair.Next;
                return;
            }

            var prev = pair;
            pair = pair.Next;

            while (pair != null)
            {
                if (pair.Key == key)
                {
                    prev.Next = pair.Next;
                    return;
                }

                prev = prev.Next;
                pair = pair.Next;
            }
        }

        private static int CalcHash(int key)
        {
            return key % DefSize;
        }
    }
}