namespace LeetCode.Array.Easy.FirstBadVersion
{
    /* The isBadVersion API is defined in the parent class VersionControl.
          bool IsBadVersion(int version); */

    public class VersionControl
    {
        public bool IsBadVersion(int version)
        {
            return true;
        }
    }

    //https://leetcode.com/problems/first-bad-version/description/
    public class Solution : VersionControl
    {
        public int FirstBadVersion(int n)
        {
            var left = 1;
            var right = n;

            while(left < right)
            {
                var version = left + (right - left)/2;
                if(IsBadVersion(version))
                    right = version;
                else
                    left = version + 1;
            }

            return left;
        }
    }
}
