using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    internal class SudokuCell : Button
    {
        private int _value;
        public int Value {
            get
            {
                return this._value;
            } 
            set 
            {
                if (value > 0) { this.Text = value.ToString(); }
                else { this.Text = String.Empty; }
                this._value = value;
            }
        }
        public Solver Solver { get; set; }
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }


        public SudokuCell(int x, int y)
        {
            this.Text = "";
            this.Value = 0;
            this.Size = new Size(40, 40);
            this.Font = new Font(SystemFonts.DefaultFont.FontFamily, 20);
            this.ForeColor = SystemColors.ControlText;
            this.Location = new Point(x * 40, y * 40);
            this.BackColor = ((x / 3) + (y / 3)) % 2 == 0 ? SystemColors.Control : Color.LightGray;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderColor = Color.Black;
            this.XCoordinate = x;
            this.YCoordinate = y;
            this.KeyPress += CellKeyPressed;
        }

        public static void CellKeyPressed(object sender, KeyPressEventArgs e)
        {
            var cell = sender as SudokuCell;

            int value;

            if (!(int.TryParse(e.KeyChar.ToString(), out value)))
            {
                return;
            }

            if (value == 0)
            {
                cell.Value = 0;
                return;
            }

            if (cell.Solver.IsValid(value, cell.XCoordinate, cell.YCoordinate))
            {
                cell.Value = value;
            }
        }
    }
}
