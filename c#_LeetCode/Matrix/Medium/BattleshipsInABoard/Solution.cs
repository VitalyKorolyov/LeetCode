namespace LeetCode.Matrix.Medium.BattleshipsInABoard;

//https://leetcode.com/problems/battleships-in-a-board/description/
public class Solution
{
    public int CountBattleships(char[][] board)
    {
        int count = 0;

        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                if (i - 1 >= 0 && board[i - 1][j] == 'X') continue;
                if (j - 1 >= 0 && board[i][j - 1] == 'X') continue;

                if (board[i][j] == 'X') count++;
            }
        }

        return count;
    }
}