namespace project
{
    public class Piece
    {
        public string name;
        public string imagePath;
        public PieceCode code;

        public Piece()
        {
        }

        public Piece(string name, string imagePath)
        {
            this.name = name;
            this.imagePath = "pieces/" + imagePath;
        }
        
        public Piece(string name, string imagePath, PieceCode code)
        {
            this.name = name;
            this.imagePath = "pieces/" + imagePath;
            this.code = code;
        }
    }
}