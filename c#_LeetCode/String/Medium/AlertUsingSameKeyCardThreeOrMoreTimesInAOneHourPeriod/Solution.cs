using System.Collections.Generic;
using System.Linq;

namespace LeetCode.String.Medium.AlertUsingSameKeyCardThreeOrMoreTimesInAOneHourPeriod
{
    //https://leetcode.com/problems/alert-using-same-key-card-three-or-more-times-in-a-one-hour-period/
    public class Solution
    {
        public IList<string> AlertNames(string[] keyName, string[] keyTime)
        {
            Dictionary<string, SortedList<int, int>> namesToTime = new();

            for (int i = 0; i < keyName.Length; i++)
            {
                string name = keyName[i];
                int minutes = GetMinutes(keyTime[i]);

                namesToTime.TryAdd(name, new SortedList<int, int>());
                namesToTime[name].Add(minutes, minutes);
            }

            SortedSet<string> result = new();

            foreach (var nameToTime in namesToTime)
            {
                for (var i = 2; i < nameToTime.Value.Count; i++)
                {
                    if (nameToTime.Value.Values[i] - nameToTime.Value.Values[i - 2] <= 60)
                    {
                        result.Add(nameToTime.Key);
                        break;
                    }
                }
            }

            return result.ToList();
        }

        private int GetMinutes(string time)
        {
            var parts = time.Split(':');
            return int.Parse(parts[0]) * 60 + int.Parse(parts[1]);
        }
    }
}
