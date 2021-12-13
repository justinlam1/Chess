using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Chess
{
    public static class ChessUtilities
    {
        private static bool IsValid(Board board, PieceLocation current, int deltaRow, int deltaCol, out PieceLocation location)
        {
            Console.WriteLine(current.Column + " " + current.Row);
            location = new PieceLocation(-1, -1);
            var newRow = current.Row + deltaRow;
            if ((newRow < 0) ||(newRow > board.Size - 1)) return false;

            var newCol = current.Column + deltaCol;
            if ((newCol < 0) || (newCol > board.Size - 1)) return false;

            location = new PieceLocation(newCol, newRow);
            return true;
        }
        
        public static IEnumerable<Move> GetValidMoves(Board board, Piece piece, int range, IEnumerable<int[]> mults)
        {
            if (board == null) throw new ArgumentNullException("board");
            // if (piece == null) throw new ArgumentNullException("piece");
            if (range < 1) throw new ArgumentOutOfRangeException("range");
            if (mults == null || !mults.Any()) throw new ArgumentException("mults");

            // var piece = board.GetPieceAt(currentLocation.Row, currentLocation.Column);
            
            var ValidMoves = new List<Move>();
            
            foreach( var mult in mults)
            {
                for (var radius = 1; radius <= range; radius++)
                {

                    var deltaCol = radius * mult[0];
                    var deltaRow = radius * mult[1];
                    if(IsValid(board, piece.CurrentLocation, deltaRow, deltaCol, out PieceLocation newLocation))
                    {
                        ValidMoves.Add(new Move (piece, newLocation));
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return ValidMoves;
        }
    }
}