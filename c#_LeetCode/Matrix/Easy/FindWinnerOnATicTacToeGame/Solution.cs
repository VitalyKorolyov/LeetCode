using System.Linq;

namespace LeetCode.Matrix.Easy
{
    public class Solution
    {
        public string Tictactoe(int[][] moves)
        {
            var matrix = new int[3][];
            matrix[0] = new int[3];
            matrix[1] = new int[3];
            matrix[2] = new int[3];

            for (int i = 0; i < moves.Length; i++)
            {
                matrix[moves[i][0]][moves[i][1]] = i % 2 == 0 ? 1 : 2;
            }

            return GetResult(matrix, moves.Length);
        }

        private string GetResult(int[][] matrix, int steps)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix[i][0] != 0 && matrix[i][0] == matrix[i][1] && matrix[i][1] == matrix[i][2]) 
                    return matrix[i][0] == 1 ? "A" : "B";
            }

            for (int i = 0; i < matrix[0].Length; i++)
            {
                if (matrix[0][i] != 0 && matrix[0][i] == matrix[1][i] && matrix[0][i] == matrix[2][i]) 
                    return matrix[0][i] == 1 ? "A" : "B";
            }

            if(matrix[0][0] != 0 && matrix[0][0] == matrix[1][1] && matrix[0][0] == matrix[2][2])
                return matrix[0][0] == 1 ? "A" : "B";

            if (matrix[0][2] != 0 && matrix[0][2] == matrix[1][1] && matrix[0][2] == matrix[2][0])
                return matrix[0][2] == 1 ? "A" : "B";

            if (steps != 9) return "Pending";

            return "Draw";
        }
    }
}