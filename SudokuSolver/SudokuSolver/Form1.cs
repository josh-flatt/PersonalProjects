using System;
using System.Drawing;
using System.Windows.Forms;

namespace SudokuSolver
{
    public partial class Form1 : Form
    {
        SudokuCell[,] matrix;
        Solver solver;

        public Form1()
        {
            InitializeComponent();
            
            matrix = SudokuBoardController.InitializeBoard();

            solver = new Solver(matrix);
            SudokuBoardController.SetSolver(matrix, solver);
            foreach (SudokuCell cell in matrix) { SudokuBoardGUI.Controls.Add(cell); }
        }

        public void FillBoard_Click(object sender, EventArgs e)
        {
            solver.Solve();
        }

        public void ClearBoard_Click(object sender, EventArgs e)
        {
            foreach (SudokuCell cell in matrix) { cell.Value = 0; }
        }

        public void SudokuBoardGUI_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}