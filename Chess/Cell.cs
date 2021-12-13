using System;

namespace Chess
{
    public class Cell
    {
        private Piece? piece;


        public bool HasPiece()
        {
            return piece != null;
        }

        public Piece GetPiece()
        {
            if (!HasPiece()) throw new NullReferenceException("No piece in current cell");
            return piece;
        }

        public char GetSymbol()
        {
            // Console.WriteLine($"HasPiece(): {HasPiece()}");
            if (HasPiece())
            {
                return piece.Symbol;
            }
            else
            {
                return '-';
            }
        }
        public void PlacePiece(Piece piece)
        {
            this.piece = piece;
        }

        public Piece RemovePiece()
        {
            var removedPiece = piece;
            piece = null;
            return removedPiece;
        }
    }
}