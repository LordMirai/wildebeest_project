using System.ComponentModel;

namespace project
{
    public class Driver
    {
        public static Form1 form;

        public static void cellClicked(int x, int y)
        {
            (x, y) = (y, x);

            PieceCode cellPiece = form.matrix[x, y];
            if (form.selectedPiece != null) // piece is selected, move
            {
                // todo: check if move is legal

                if (cellPiece != PieceCode.None)
                {
                    // capture
                    form.hint.Text = $@"Captured a {cellPiece} with a {form.selectedPiece}";
                }
                else
                {
                    // ! this is extremely broken and i have no idea why.
                    string locStart =
                        form.prettyPosition(form.selectedPiece.location[0], form.selectedPiece.location[1]);
                    string locEnd =
                        form.prettyPosition(y, x);
                    form.hint.Text = $@"Piece moved from {locStart} to {locEnd}.";
                    form.matrix[x, y] = form.selectedPiece.code;
                }

                form.selectedPiece = null; // reset selected
            }
            else
            {
                if (cellPiece != PieceCode.None)
                {
                    form.selectedPiece = Piece.getByCode(cellPiece);
                    form.selectedPiece.location = new[] { x, y };
                    form.hint.Text = $@"Selected piece: {cellPiece}";
                }
                else
                {
                    form.hint.Text = @"There is nothing there";
                }
            }

            // form.hint.Text = $@"Selected cell: [{x}, {y}] - There's a {cellPiece} there";
        }
    }
}