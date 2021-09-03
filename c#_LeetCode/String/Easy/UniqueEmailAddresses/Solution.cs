using System.Collections.Generic;

namespace LeetCode.String.Easy.UniqueEmailAddresses
{
    public class Solution
    {
        public int NumUniqueEmails(string[] emails)
        {
            var hash = new HashSet<string>(emails.Length);

            for (int i = 0; i < emails.Length; i++)
            {
                var parts = emails[i].Split('@');
                var localName = parts[0];
                var domainName = parts[1];

                localName = localName.Split('+')[0];
                localName = localName.Replace(".", "");

                var email = localName + "@" + domainName;
                if (!hash.Contains(email))
                {
                    hash.Add(email);
                }
            }

            return hash.Count;
        }
    }
}