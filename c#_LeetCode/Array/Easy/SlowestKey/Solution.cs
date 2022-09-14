namespace LeetCode.Array.Easy.SlowestKey
{
    //https://leetcode.com/problems/slowest-key/
    public class Solution
    {
        public char SlowestKey(int[] releaseTimes, string keysPressed)
        {
            char slowestKey = 'a';
            var keyTime = int.MinValue;

            var time = 0;

            for (int i = 0; i < keysPressed.Length; i++)
            {
                var currentTime = releaseTimes[i] - time;
                if (currentTime >= keyTime)
                {
                    if (currentTime == keyTime)
                        slowestKey = slowestKey > keysPressed[i] ? slowestKey : keysPressed[i];
                    else
                        slowestKey = keysPressed[i];

                    keyTime = currentTime;
                }

                time = releaseTimes[i];
            }

            return slowestKey;
        }
    }
}
