using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    internal class Solver
    {
        /// <summary>
        /// The Sudoku board state.
        /// A matrix of SudokuCells
        /// </summary>
        SudokuCell[,] sudokuArray;

        public Solver(SudokuCell[,] sudokuArray)
        {
            this.sudokuArray = sudokuArray;
        }

        /// <summary>
        /// Iterates through <see cref="sudokuArray"/>, attempting to replace "0" as a number of 1-9. When
        /// one valid integer has been found, it is inserted into the matrix and the program moves to the next
        /// blank space. If a number between 1 and 9 cannot be valid for a space, the recursive
        /// function blanks out the space and returns False, to move to the previous blank space to attempt another
        /// integer.
        /// </summary>
        /// <returns>
        /// True when there are no empty spaces left
        /// False when board is unsolvable and must return to a previous box 
        /// </returns>
        public bool Solve()
        {
            Tuple<int, int> blank_space = this.FindEmpty();
            int col = blank_space.Item1;
            int row = blank_space.Item2;
            if (row == -1 && col == -1) //When no empty blank space has been found, this will be met.
            {
                return true;
            }
            for (int i = 1; i < 10; i++) //Checks numbers 1-9 in a blank position
            {
                if (this.IsValid(i, col, row)) //Checks to see if i is a valid option
                {
                    sudokuArray[col, row].Value = i; //Replaces the blank space in the input matrix with i

                    if (Solve()) //Recursive attempt to iterate through all blank spaces in matrix
                    {
                        return true; //Ends recursive algorithm
                    }

                    sudokuArray[col, row].Value = 0; //Resets number if no solution was found
                }
            }
            return false; //Forces program to backtrack to previous originally-blank box
        }


        /// <summary>
        /// Function checks to see if an inserted number is unique in the row, column, and sub-matrix.
        /// </summary>
        /// <param name="num">Number attempted to insert</param>
        /// <param name="col">Represents the column being checked</param>
        /// <param name="row">Represents the row being checked</param>
        /// <returns>
        /// True if the number is unique.
        /// False if the number is not unique.
        /// </returns>
        public bool IsValid(int num, int col, int row)
        {
            //Check Row
            for (int i = 0; i < 9; i++)
            {
                if (sudokuArray[col, i].Value == num) { return false; }
            }

            //Check Column
            for (int i = 0; i < 9; i++)
            {
                if (sudokuArray[i, row].Value == num) { return false; }
            }

            //Check Sub-matrix box
            double x = row / 3;
            double y = col / 3;
            int box_xval = Convert.ToInt32(Math.Floor(x)); // Returns 0, 1, or 2
            int box_yval = Convert.ToInt32(Math.Floor(y)); // Returns 0, 1, or 2
            for (int i = (box_yval * 3); i < ((box_yval * 3) + 3); i++)
            {
                for (int j = (box_xval * 3); j < ((box_xval * 3) + 3); j++)
                {
                    if (sudokuArray[i, j].Value == num) { return false; }
                }
            }

            //If number is unique
            return true;
        }

        /// <summary>
        /// Finds the coordinates of each empty space in <see cref="sudokuArray"/> singularly
        /// </summary>
        /// <returns>
        /// Coordinates of the first found empty space.
        /// (-1, -1) if no empty spaces found
        /// </returns>
        private Tuple<int, int> FindEmpty()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (sudokuArray[i, j].Value == 0) { return Tuple.Create(i, j); }
                }
            }
            return Tuple.Create(-1, -1);
        }

    }
}
