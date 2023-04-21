using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace project
{
    public partial class Form1 : Form
    {
        public static int offsetX = 5, offsetY = 40;
        public static int offsetEndX = 553, offsetEndY = 502;
        public static int cellSize = 50;

        public static GameState state = GameState.WhiteTurn;

        public Piece[,] matrix = new Piece[10, 11];
        public Piece selectedPiece;

        private List<PictureBox> piecePictures = new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();

            Driver.form = this;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            bkgr.BackColor = Color.Transparent;
            // bkgr.TransparencyKey = Color.Transparent;
        }

        /**
         * Background click. Fires cellClicked on row/col coords
         */
        private void bkgr_Click(object sender, EventArgs e)
        {
            int[] pos = clickPosition();
            Driver.cellClicked(pos[0], pos[1]);
        }


        int[] clickPosition()
        {
            int[] position = { -1, -1 };

            var startX = Location.X;
            var startY = Location.Y;

            int x = MousePosition.X - startX - offsetX;
            int y = MousePosition.Y - startY - offsetY;

            x /= cellSize;
            y /= cellSize;

            if (x > 11 || y > 9)
                return position;

            position[0] = x;
            position[1] = y;

            return position;
        }

        /**
         * <summary>Takes the coordinates from clickPosition and makes it readable</summary>
         * <example>6,1 => B4 </example>
         */
        public string clickPositionFormatted()
        {
            string outS = "";
            int[] pos = clickPosition();
            if (pos[0] != -1)
            {
                char let = (char)(65 + pos[0]);
                outS = $"{let}{(10 - pos[1])}";
            }

            return outS;
        }

        public string prettyPosition(int x, int y)
        {
            string outS = "";
            if (x != -1)
            {
                char let = (char)(65 + x);
                outS = $"{let}{(10 - y)}";
            }

            return outS;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // assistance.Location = new System.Drawing.Point(offsetX, offsetY);

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    matrix[i, j] = null; // init empty matrix
                }
            }

            hint.Text = @"Board start position: " + bkgr.Location;

            Piece pawn = new Piece("Pawn", "pawn", PieceCode.Pawn);
            Piece bQueen = new Piece("Queen", "queen", PieceCode.Queen, false);

            makePiece(pawn, 0, 1);
            makePiece(pawn, 1, 1);

            makePiece(pawn, 5, 5);
            makePiece(bQueen, 6, 6);
            makePiece(pawn,3,2);
        }

        /**
         * <summary>Makes a WinForms PictureBox corresponding to a piece.
         * It also assigns a click event that does the same thing as background click in driver
         * </summary>
         *
         * <param name="piece">The Piece object to process</param>
         * <param name="x">X (row) coordinate</param>
         * <param name="y">Y (column) coordinate</param>
         */
        public void makePiece(Piece piece, int x, int y)
        {
            int pieceOffsetX = -5, pieceOffsetY = -30;
            // hint.Text = $@"Piece: {piece.name} at [{x}, {y}]";
            PictureBox pb = new PictureBox();
            pb.Parent = bkgr;
            pb.ImageLocation = piece.imagePath;
            pb.Location =
                new Point(offsetX + y * cellSize + pieceOffsetX,
                    offsetY + x * cellSize + pieceOffsetY); // y and x are reversed
            pb.Size = new Size(cellSize, cellSize);
            pb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
            pb.BackColor = getTableColor(x, y);
            pb.SizeMode = PictureBoxSizeMode.CenterImage;

            pb.Click += delegate(object sender, EventArgs e) { Driver.cellClicked(x, y); };

            piecePictures.Add(pb);

            matrix[x, y] = piece;

            Controls.Add(pb);
            pb.BringToFront();

            bkgr.SendToBack();
        }

        /**
         * <summary>Returns the background color for a cell, by coordinates.</summary>
         *
         * <param name="x">X (row) coordinate</param>
         * <param name="y">Y (column) coordinate</param>
         * <returns>The resulting color. Yellow is the equivalent of White and Green is equivalent to Black</returns>
         */
        private Color getTableColor(int x, int y)
        {
            if (x % 2 == 0)
                return y % 2 == 0 ? Color.FromArgb(204, 204, 17) : Color.FromArgb(51, 153, 51);

            return y % 2 == 0 ? Color.FromArgb(51, 153, 51) : Color.FromArgb(204, 204, 17);
        }

        /**
         * Removes all registered controls from the form (deletes the pieces' pictures)
         */
        private void clearBoard()
        {
            foreach (var elem in piecePictures)
            {
                Controls.Remove(elem);
            }
        }

        /**
         * Populates the board with the matrix pieces.
         */
        public void updateBoard()
        {
            clearBoard();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    if (matrix[i, j] != null) // ? if there's a piece present, make the corresponding image
                        makePiece(matrix[i, j], i, j); // ! ref point, this is what broke it before
                }
            }
        }

        /**
         * Close on escape
         */
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Close();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }

    public enum GameState
    {
        WhiteTurn,
        BlackTurn,
        GameEnd,
        Errored,
        Suspended
    }
}