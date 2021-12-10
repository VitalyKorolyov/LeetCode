namespace LeetCode.Matrix.Medium.DesignTicTacToe
{
    //https://leetcode.com/problems/design-tic-tac-toe/
    public class TicTacToe
    {
        private readonly int[][] _matrix;

        public TicTacToe(int n)
        {
            _matrix = new int[n][];

            for (int i = 0; i < n; i++)
            {
                _matrix[i] = new int[n];
            }
        }

        public int Move(int row, int col, int player)
        {
            _matrix[row][col] = player;

            for (int i = 0; i < _matrix.Length; i++)
            {
                if (i == _matrix.Length - 1 && _matrix[row][i] == player) return player;
                if (_matrix[row][i] != player) break;
            }

            for (int i = 0; i < _matrix.Length; i++)
            {
                if (i == _matrix.Length - 1 && _matrix[i][col] == player) return player;
                if (_matrix[i][col] != player) break;
            }

            if (col == row)
            {
                for (int i = 0; i < _matrix.Length; i++)
                {
                    if (i == _matrix.Length - 1 && _matrix[i][i] == player) return player;
                    if (_matrix[i][i] != player) break;
                }
            }

            if (col + row == _matrix.Length - 1)
            {
                for (int i = 0; i < _matrix.Length; i++)
                {
                    if (i == _matrix.Length - 1 && _matrix[_matrix.Length - i - 1][i] == player) return player;
                    if (_matrix[_matrix.Length - i - 1][i] != player) break;
                }
            }

            return 0;
        }
    }
}