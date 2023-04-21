namespace project
{
    public class Driver
    {
        public static Form1 form;

        /**
         * <summary>Processes all behavior on a cell click - move and capture.</summary>
         *
         * <param name="x">X (row) coordinate</param>
         * <param name="y">Y (column) coordinate</param>
         */
        public static void cellClicked(int x, int y)
        {
            (x, y) = (y, x);

            if (x > 9 || x < 0 || y > 10 || y < 0) // ? Out of bounds. ignored.
            {
                return;
            }

            var selP = form.selectedPiece;
            var cellPiece = form.matrix[x, y];

            if (selP != null) // piece is selected, move
            {
                // TODO: check if move is legal

                if (cellPiece != null) // capture
                {
                    if (sameColor(selP, cellPiece))
                    {
                        form.hint.Text = @"That piece is of the same color. Can't capture.";
                    }
                    else
                    {
                        form.hint.Text = $@"Captured a {cellPiece.name} with a {selP.name}";
                        // do things

                        form.matrix[selP.location[0], selP.location[1]] = null;
                        form.matrix[x, y] = selP.clone();

                        form.updateBoard();
                    }
                }
                else // regular move
                {
                    // TODO: check if move is legal

                    // ! this is extremely broken and i have no idea why.
                    var locStart = form.prettyPosition(selP.location[0], selP.location[1]);
                    var locEnd = form.prettyPosition(y, x); // ! question not the inversion, it makes no sense.
                    form.hint.Text =
                        $@"Piece moved from {locStart} to {locEnd}. From {selP.location[0]}, {selP.location[1]} to X:{x}, Y:{y}";

                    form.matrix[selP.location[0], selP.location[1]] = null;

                    selP.location[0] = x;
                    selP.location[1] = y;
                    form.matrix[x, y] = selP.clone();

                    form.updateBoard();
                }

                form.selectedPiece = null; // reset selected
            }
            else
            {
                if (cellPiece != null)
                {
                    form.selectedPiece = cellPiece;
                    form.selectedPiece.location[0] = x;
                    form.selectedPiece.location[1] = y;
                    form.hint.Text = $@"Selected piece: {cellPiece.name}";
                }
                else
                {
                    form.hint.Text = @"There is nothing there";
                }
            }

            // form.hint.Text = $@"Selected cell: [{x}, {y}] - There's a {cellPiece} there";
        }

        /**
         * Checks if pieces' colors coincide (white to white and black to black)
         *
         * <param name="piece1">First piece to check</param>
         * <param name="piece2">Second piece to check</param>
         * 
         * <returns>The coincidence between them</returns>
         */
        private static bool sameColor(Piece piece1, Piece piece2)
        {
            return (piece1.isWhite && piece2.isWhite) || (!piece1.isWhite && !piece2.isWhite);
        }
    }
}