namespace SudokuSolver
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FillBoard = new System.Windows.Forms.Button();
            this.ClearBoard = new System.Windows.Forms.Button();
            this.SudokuBoardGUI = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // FillBoard
            // 
            this.FillBoard.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FillBoard.Location = new System.Drawing.Point(25, 32);
            this.FillBoard.Name = "FillBoard";
            this.FillBoard.Size = new System.Drawing.Size(193, 81);
            this.FillBoard.TabIndex = 0;
            this.FillBoard.Text = "Solve";
            this.FillBoard.UseVisualStyleBackColor = true;
            this.FillBoard.Click += new System.EventHandler(this.FillBoard_Click);
            // 
            // ClearBoard
            // 
            this.ClearBoard.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearBoard.Location = new System.Drawing.Point(25, 156);
            this.ClearBoard.Name = "ClearBoard";
            this.ClearBoard.Size = new System.Drawing.Size(193, 81);
            this.ClearBoard.TabIndex = 1;
            this.ClearBoard.Text = "Clear";
            this.ClearBoard.UseVisualStyleBackColor = true;
            this.ClearBoard.Click += new System.EventHandler(this.ClearBoard_Click);
            // 
            // SudokuBoardGUI
            // 
            this.SudokuBoardGUI.Location = new System.Drawing.Point(247, 32);
            this.SudokuBoardGUI.Name = "SudokuBoardGUI";
            this.SudokuBoardGUI.Size = new System.Drawing.Size(578, 503);
            this.SudokuBoardGUI.TabIndex = 2;
            this.SudokuBoardGUI.Paint += new System.Windows.Forms.PaintEventHandler(this.SudokuBoardGUI_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 560);
            this.Controls.Add(this.SudokuBoardGUI);
            this.Controls.Add(this.ClearBoard);
            this.Controls.Add(this.FillBoard);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button FillBoard;
        private Button ClearBoard;
        public Panel SudokuBoardGUI;
    }
}