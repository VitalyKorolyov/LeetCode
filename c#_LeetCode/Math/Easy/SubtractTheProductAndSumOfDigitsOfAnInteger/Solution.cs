namespace LeetCode.Math.Easy.SubtractTheProductAndSumOfDigitsOfAnInteger
{
    //https://leetcode.com/problems/subtract-the-product-and-sum-of-digits-of-an-integer/
    public class Solution
    {
        public static int SubtractProductAndSum(int n)
        {
            var sum = 0;
            var product = 1;

            while (n > 0)
            {
                var number = n % 10;

                sum += number;
                product *= number;

                n /= 10;
            }

            return product - sum;
        }
    }
}