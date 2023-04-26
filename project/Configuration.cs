namespace project
{
    public class Configuration
    {
        /**
         * <summary>Loads a matrix with a predefined configuration. Should work for table initialization</summary>
         *
         * <param name="matrix">Matrix to populate, bi-dimensional</param>
         * <param name="cfgIn">Config enum value to use</param>
         *
         * <returns>The success in loading the configuration. Invalid values return false</returns>
         */
        public static bool load_configuration(ref Piece[,] matrix, Config cfgIn = Config.Empty)
        {
            switch (cfgIn)
            {
                case Config.Empty:
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 11; j++)
                        {
                            matrix[i, j] = null;
                        }
                    }

                    return true;
                case Config.Default:
                    load_configuration(ref matrix); // init empty first


                    // first the black pieces
                    matrix[0, 0] = Piece.getByCode(PieceCode.Rook, false);
                    matrix[0, 1] = Piece.getByCode(PieceCode.Knight, false);
                    matrix[0, 2] = Piece.getByCode(PieceCode.Camel, false);
                    matrix[0, 3] = Piece.getByCode(PieceCode.Camel, false);
                    matrix[0, 4] = Piece.getByCode(PieceCode.Wildebeest, false);
                    matrix[0, 5] = Piece.getByCode(PieceCode.King, false);
                    matrix[0, 6] = Piece.getByCode(PieceCode.Queen, false);
                    matrix[0, 7] = Piece.getByCode(PieceCode.Bishop, false);
                    matrix[0, 8] = Piece.getByCode(PieceCode.Bishop, false);
                    matrix[0, 9] = Piece.getByCode(PieceCode.Knight, false);
                    matrix[0, 10] = Piece.getByCode(PieceCode.Rook, false);

                    for (int j = 0; j < 11; j++)
                    {
                        matrix[1, j] = Piece.getByCode(PieceCode.Pawn, false); // fill black pawns
                    }

                    // now the white pieces

                    matrix[9, 0] = Piece.getByCode(PieceCode.Rook);
                    matrix[9, 1] = Piece.getByCode(PieceCode.Knight);
                    matrix[9, 2] = Piece.getByCode(PieceCode.Bishop);
                    matrix[9, 3] = Piece.getByCode(PieceCode.Bishop);
                    matrix[9, 4] = Piece.getByCode(PieceCode.Queen);
                    matrix[9, 5] = Piece.getByCode(PieceCode.King);
                    matrix[9, 6] = Piece.getByCode(PieceCode.Wildebeest);
                    matrix[9, 7] = Piece.getByCode(PieceCode.Camel);
                    matrix[9, 8] = Piece.getByCode(PieceCode.Camel);
                    matrix[9, 9] = Piece.getByCode(PieceCode.Knight);
                    matrix[9, 10] = Piece.getByCode(PieceCode.Rook);

                    for (int j = 0; j < 11; j++)
                    {
                        matrix[8, j] = Piece.getByCode(PieceCode.Pawn); // fill white pawns
                    }

                    return true;
                default:
                    return false;
            }
        }
    }
}