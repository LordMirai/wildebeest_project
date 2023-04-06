using System.ComponentModel;

namespace project
{
    public class Driver
    {
        public static Form1 form;

        public static void cellClicked(int x, int y)
        {
            (x, y) = (y, x);
            
            var selP = form.selectedPiece;
            var cellPiece = form.matrix[x, y];
            
            if (selP != null) // piece is selected, move
            {
                // todo: check if move is legal

                if (cellPiece != null)
                {
                    // capture
                    form.hint.Text = $@"Captured a {cellPiece} with a {selP.name}";
                }
                else
                {
                    // regular move
                    // ! this is extremely broken and i have no idea why.
                    var locStart = form.prettyPosition(selP.location[0], selP.location[1]);
                    var locEnd = form.prettyPosition(y, x);
                    form.hint.Text = $@"Piece moved from {locStart} to {locEnd}. X:{x}, Y:{y}";
                    
                    form.matrix[x, y] = selP;
                    form.matrix[x, y].location = new[] { y, x };
                    
                    form.matrix[selP.location[0], selP.location[1]] = null;
                    
                    form.updateBoard();
                }

                form.selectedPiece = null; // reset selected
            }
            else
            {
                if (cellPiece != null)
                {
                    form.selectedPiece = Piece.getByCode(cellPiece.code);
                    form.selectedPiece.location = new[] { x, y };
                    form.hint.Text = $@"Selected piece: {cellPiece.name}";
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