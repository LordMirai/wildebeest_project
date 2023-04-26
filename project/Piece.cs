using System.IO;

namespace project
{
    public class Piece
    {
        public string name;
        public string imagePath;
        public PieceCode code;
        public bool isWhite = true;
        public int[] location = new[] { 0, 0 };

        public Piece()
        {
            name = "Pawn";
        }

        public Piece(string name, string imagePath)
        {
            this.name = name;
            this.imagePath = getPath(imagePath);
        }

        public Piece(string name, string imagePath, PieceCode code)
        {
            this.name = name;
            this.code = code;
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
            this.imagePath = getPath(imagePath);
            this.code = code;
            this.isWhite = isWhite;
            this.location = location;
        }

        public Piece clone()
        {
            return new Piece(name, imagePath, code, isWhite, location);
        }

        /**
         * Returns the image path relative to CWD
         *
         * <param name="end">The actual piece name</param>
         * <example>getPath("queen") => "[...]\pieces\queen_white.png"</example>
         * <returns>image path.</returns>
         */
        private string getPath(string end)
        {
            string color = isWhite ? "white" : "black";
            string directory = Directory.GetCurrentDirectory();
            directory = Directory.GetParent(directory).Parent.FullName; // go up 2 levels to get to the root directory
            directory += $"\\pieces\\{end}_{color}.png";
            return directory;
        }

        /**
         * <summary>A way to quickly get a piece by its code. Does not cover color or location</summary>
         *
         * <param name="code">The piece code to test</param>
         *
         * <example>getByCode(PieceCode.Pawn) => Piece("Pawn","pawn",PieceCode.Pawn)</example>
         */
        public static Piece getByCode(PieceCode code, bool white = true)
        {
            switch (code)
            {
                case PieceCode.Pawn:
                    return new Piece("Pawn", "pawn", code, white);
                case PieceCode.Queen:
                    return new Piece("Queen", "queen", code, white);
                case PieceCode.Bishop:
                    return new Piece("Bishop", "bishop", code, white);
                case PieceCode.Camel:
                    return new Piece("Camel", "camel", code, white);
                case PieceCode.King:
                    return new Piece("King", "king", code, white);
                case PieceCode.Rook:
                    return new Piece("Rook", "rook", code, white);
                case PieceCode.Knight:
                    return new Piece("Knight", "knight", code, white);
                case PieceCode.Wildebeest:
                    return new Piece("Wildebeest", "wildebeest", code, white);
                    


                default:
                    return new Piece("None", "", code, white);
            }
        }
    }
}