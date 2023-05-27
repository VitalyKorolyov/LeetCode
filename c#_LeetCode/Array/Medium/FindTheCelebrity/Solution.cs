namespace LeetCode.Array.Medium.FindTheCelebrity
{
    /* The Knows API is defined in the parent class Relation.
          bool Knows(int a, int b); */
    public class Relation
    {
        protected virtual bool Knows(int a, int b)
        {
            return true;
        }
    }

    //https://leetcode.com/problems/find-the-celebrity/description/
    public class Solution : Relation
    {
        public int FindCelebrity(int n)
        {
            int l = 0;
            int r = n - 1;

            while (l < r) 
            {
                if(Knows(l, r))
                    l++;
                else
                    r--;
            }

            for (int i = 0; i < n; i++)
            {
                if (i == r) continue;
                if (!Knows(i, r) || Knows(r, i)) return -1;
            }

            return r;
        }
    }
}
