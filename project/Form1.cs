using System;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        static int offsetX = 15, offsetY = 15;
        static int offsetEndX = 625, offsetEndY = 705;
        static int cellSize = 51;

        private int[,] matrix = new int[10, 11];

        public Form1()
        {
            InitializeComponent();
        }

        private void bkgr_Click(object sender, EventArgs e)
        {
            int x, y, startX, startY;

            startX = Location.X;
            startY = Location.Y;

            x = MousePosition.X - startX - offsetX;
            y = MousePosition.Y - startY - offsetY;

            int[] pos = getPosition();
            hint.Text = String.Format("Pos: [{0}, {1}] {2}, {3} ({4})", x, y, pos[0], pos[1], getPositionFormatted());
        }


        public int[] getPosition()
        {
            int offsetX = 105, offsetY = 125;
            int offsetEndX = 560, offsetEndY = 532;

            int[] position = { -1, -1 };


            if (!(offsetX < MousePosition.X && MousePosition.X < offsetEndX) ||
                !(offsetY < MousePosition.Y && MousePosition.Y < offsetEndY))
            {
                // invalid position (out of bounds)
                return position;
            }

            int x = MousePosition.X - offsetX;
            int y = MousePosition.Y - offsetY;

            x = x / cellSize;
            y = y / cellSize;

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
                outS = String.Format("{0}{1}", let, pos[1] + 1);
            }

            return outS;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            assistance.Location = new System.Drawing.Point(offsetX, offsetY);
            
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    matrix[i, j] = 0; // init empty matrix
                }
            }
        }
    }
}