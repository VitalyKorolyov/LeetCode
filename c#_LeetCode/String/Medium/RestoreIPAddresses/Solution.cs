using System.Collections.Generic;

namespace LeetCode.String.Medium.RestoreIPAddresses
{
    //https://leetcode.com/problems/restore-ip-addresses/description/
    public class Solution
    {
        public IList<string> RestoreIpAddresses(string s)
        {
            var result = new List<string>();

            Restore(s, result, "", 0);

            return result;
        }

        private void Restore(string s, List<string> result, string restored, int count)
        {
            if(count == 4)
            {
                if(string.IsNullOrEmpty(s)) result.Add(restored);
                return;
            }

            for (int i = 1; i <= System.Math.Min(3, s.Length); i++)
            {
                var sub = s.Substring(0, i);

                if (sub.Length > 1 && sub[0] == '0' || sub.Length == 3 && int.Parse(sub) > 255) continue;

                Restore(s.Substring(i), result, restored + sub + (count < 3 ? "." : ""), count + 1);
            }
        }
    }
}
