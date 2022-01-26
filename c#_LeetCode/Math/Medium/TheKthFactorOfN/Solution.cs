namespace LeetCode.Math.Medium.TheKthFactorOfN
{
    //https://leetcode.com/problems/the-kth-factor-of-n/submissions/
    public class Solution
    {
        public int KthFactor(int n, int k)
        {
            var kFact = -1;

            for (int i = 1; i <= n/2 + 1; i++)
            {
                if(n % i == 0) k--;
                if (0 == k) 
                {
                    kFact = i;
                    break;
                }
            }

            return k == 1 ? n : kFact;
        }
    }
}
