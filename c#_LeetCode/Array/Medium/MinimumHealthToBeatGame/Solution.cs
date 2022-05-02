namespace LeetCode.Array.Medium.MinimumHealthToBeatGame
{
    //https://leetcode.com/problems/minimum-health-to-beat-game/
    public class Solution
    {
        public long MinimumHealth(int[] damage, int armor)
        {
            long totalHealth = 1;
            var maxAppliedArmor = 0;

            for(int i = 0; i < damage.Length; i++)
            {
                totalHealth += damage[i];
                maxAppliedArmor = System.Math.Max(maxAppliedArmor, System.Math.Min(armor, damage[i]));
            }

            return totalHealth - maxAppliedArmor;
        }
    }
}
