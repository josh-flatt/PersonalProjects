using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    internal class SudokuBoardController
    {

        public static void SetSolver(SudokuCell[,] matrix, Solver solver)
        {
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    matrix[x, y].Solver = solver;
                }
            }
        }

        public static SudokuCell[,] InitializeBoard()
        {
            SudokuCell[,] matrix = new SudokuCell[9, 9];

            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    matrix[x, y] = new SudokuCell(x, y);
                }
            }
            return matrix;
        }
    }
}
