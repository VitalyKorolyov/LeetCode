namespace LeetCode.Math.Medium.NumberOfStepsToReduceANumberInBinaryRepresentationToOne
{
    //https://leetcode.com/problems/number-of-steps-to-reduce-a-number-in-binary-representation-to-one/
    public class Solution
    {
        public int NumSteps(string s)
        {
            var res = 0;
            var carry = 0;

            for (int i = s.Length - 1; i > 0; i--)
            {
                res++;

                if(s[i] - '0' + carry == 1)
                {
                    res++;
                    carry = 1;
                }
            }

            return res + carry;
        }
    }
}
