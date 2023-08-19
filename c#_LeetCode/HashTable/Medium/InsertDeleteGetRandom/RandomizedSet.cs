using System;
using System.Collections.Generic;

namespace LeetCode.HashTable.Medium.InsertDeleteGetRandom;

//https://leetcode.com/problems/insert-delete-getrandom-o1/
public class RandomizedSet
{
    private readonly Dictionary<int, int> hash = new();
    private readonly List<int> list = new();
    private readonly Random random = new();

    public bool Insert(int val)
    {
        if (hash.ContainsKey(val)) return false;

        hash.Add(val, list.Count);
        list.Add(val);

        return true;
    }

    public bool Remove(int val)
    {
        if (!hash.ContainsKey(val)) return false;

        var currentIndex = hash[val];
        var lastIndex = list.Count - 1;

        list[currentIndex] = list[lastIndex];
        hash[list[currentIndex]] = currentIndex;

        list.RemoveAt(lastIndex);
        hash.Remove(val);

        return true;
    }

    public int GetRandom()
    {
        int index = random.Next(0, list.Count);
        return list[index];
    }
}