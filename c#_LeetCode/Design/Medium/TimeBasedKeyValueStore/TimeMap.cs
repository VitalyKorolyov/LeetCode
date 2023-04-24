using System.Collections.Generic;

namespace LeetCode.Design.Medium.TimeBasedKeyValueStore;

//https://leetcode.com/problems/time-based-key-value-store/description/
public class TimeMap
{
    private readonly Dictionary<string, List<(int timestamp, string value)>> keyToValues = new();

    public void Set(string key, string value, int timestamp)
    {
        if (!keyToValues.ContainsKey(key))
            keyToValues.Add(key, new List<(int timestamp, string value)>());

        keyToValues[key].Add((timestamp, value));
    }

    public string Get(string key, int timestamp)
    {
        if(!keyToValues.ContainsKey(key)) return string.Empty;

        var list = keyToValues[key];

        int left = 0;
        int right = list.Count - 1;

        while(left < right) 
        {
            int mid = left + (right - left) / 2;

            if (list[mid].timestamp >= timestamp)
                right = mid;
            else
                left = mid + 1;
        }

        if(list[left].timestamp > timestamp)
            return left > 0 ? list[left - 1].value : "";

        return list[left].value;
    }
}