namespace LeetCode.Math.Easy.ArmstrongNumber
{
    public class Solution
    {
        public bool IsArmstrong(int n)
        {
            var sum = 0;
            var saved = n;
            var k = n.ToString().Length;

            while (n != 0)
            {
                var value = n % 10;
                n /= 10;

                sum += (int)System.Math.Pow(value, k);
            }

            return saved == sum;
        }
    }
}