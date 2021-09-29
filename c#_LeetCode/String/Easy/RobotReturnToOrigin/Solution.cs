namespace LeetCode.String.Easy.RobotReturnToOrigin
{
    //https://leetcode.com/problems/robot-return-to-origin/
    public class Solution
    {
        public bool JudgeCircle(string moves)
        {
            int x = 0;
            int y = 0;

            for (var i = 0; i < moves.Length; i++)
            {
                if (moves[i] == 'U')
                {
                    y++;
                    continue;
                }

                if (moves[i] == 'D')
                {
                    y--;
                    continue;
                }

                if (moves[i] == 'R')
                {
                    x++;
                    continue;
                }

                if (moves[i] == 'L')
                {
                    x--;
                }
            }

            return x == 0 && y == 0;
        }
    }
}