﻿using System;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        static int offsetX = 5, offsetY = 40;
        static int offsetEndX = 553, offsetEndY = 502;
        static int cellSize = 50;

        private PieceCode[,] matrix = new PieceCode[10, 11];

        public Form1()
        {
            InitializeComponent();
        }

        private void bkgr_Click(object sender, EventArgs e)
        {
            int[] pos = getPosition();
            hint.Text = $@"Selected cell: {getPositionFormatted()}[{pos[0]}, {pos[1]}] - {matrix[pos[0], pos[1]]}";
        }


        int[] getPosition()
        {
            int[] position = { -1, -1 };
            
            var startX = Location.X;
            var startY = Location.Y;

            int x = MousePosition.X - startX - offsetX;
            int y = MousePosition.Y - startY - offsetY;

            x /= cellSize;
            y /= cellSize;

            if (x > 10 || y > 9)
                return position;

            position[0] = x;
            position[1] = y;
            return position;
        }

        public string getPositionFormatted()
        {
            string outS = "";
            int[] pos = getPosition();
            if (pos[0] != -1)
            {
                char let = (char)(65 + pos[0]);
                outS = $"{let}{(10-pos[1])}";
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
                    matrix[i, j] = 0; // init empty matrix
                }
            }

            hint.Text = @"Board start position: " + bkgr.Location;
            
            Piece pawn = new Piece("Pawn", "pawn_white.png", PieceCode.Pawn);
            
            makePiece(pawn, 0, 1);
        }
        
        public void makePiece(Piece piece, int x, int y)
        {
            hint.Text = $@"Piece: {piece.name} at [{x}, {y}]";
            PictureBox pb = new PictureBox();
            pb.ImageLocation = piece.imagePath;
            pb.Location = new System.Drawing.Point(offsetX + x * cellSize, offsetY + y * cellSize);
            pb.Size = new System.Drawing.Size(cellSize, cellSize);
            pb.BackColor = System.Drawing.Color.Transparent;

            matrix[x, y] = piece.code;
            
            Controls.Add(pb);
            pb.BringToFront();
            
            bkgr.SendToBack();

            hint.Text = $"Location: {piece.imagePath}";

        }
    }
    
}