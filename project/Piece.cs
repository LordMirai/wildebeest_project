using System.IO;

namespace project
{
    public class Piece
    {
        public string name;
        public string imagePath;
        public PieceCode code;
        public bool isWhite;
        public int[] location = new[] { 0, 0 };

        public Piece()
        {
            name = "Pawn";
            isWhite = true;
        }

        public Piece(string name, string imagePath)
        {
            this.name = name;
            isWhite = true;
            this.imagePath = getPath(imagePath);
        }

        public Piece(string name, string imagePath, PieceCode code)
        {
            this.name = name;
            this.code = code;
            isWhite = true;
            this.imagePath = getPath(imagePath);
        }

        public Piece(string name, string imagePath, PieceCode code, bool isWhite)
        {
            this.name = name;
            this.code = code;
            this.isWhite = isWhite;
            this.imagePath = getPath(imagePath);
        }

        public Piece(string name, string imagePath, PieceCode code, bool isWhite, int[] location)
        {
            this.name = name;
            this.imagePath = imagePath;
            this.code = code;
            this.isWhite = isWhite;
            this.location = location;
        }

        private string getPath(string end)
        {
            string color = isWhite ? "white" : "black";
            string directory = Directory.GetCurrentDirectory();
            directory = Directory.GetParent(directory).Parent.FullName; // go up 2 levels to get to the root directory
            directory += $"\\pieces\\{end}_{color}.png";
            return directory;
        }

        public static Piece getByCode(PieceCode code)
        {
            switch (code)
            {
                case PieceCode.Pawn:
                    return new Piece("Pawn", "pawn", code);

                default:
                    return new Piece("None", "", code);
            }
        }
    }
}