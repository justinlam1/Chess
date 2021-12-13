using System;
using System.Collections.Generic;

namespace Chess
{
    // public interface IChessPiece
    // {
    //     BoardLocation CurrentLocation { get; set; }
    //     PieceType Type { get; }
    //     IEnumerable<Move> GetValidMoves(Board board);
    // }
    //
    // public class BoardLocation
    // {
    //     private const int BoardSize = 8;
    //
    //     private static bool IsInRange(int pos)
    //     {
    //         return pos is >= 1 and <= BoardSize;
    //     }
    //
    //     public BoardLocation(int row, int col)
    //     {
    //         if (!IsInRange(row))
    //         {
    //             throw new ArgumentOutOfRangeException("row");
    //         }
    //         if (!IsInRange(col))
    //         {
    //             throw new ArgumentOutOfRangeException("col");
    //         }
    //         Row = row;
    //         Column = col;
    //     }
    //     public int Row { get; }
    //     public int Column { get; }
    // }

    public class Move
    {
        public Move(Piece piece, PieceLocation endingLocation)
        {
            Piece = piece ?? throw new ArgumentNullException("piece");
            EndingLocation = endingLocation;
        }
        public Piece Piece { get; }
        public PieceLocation EndingLocation { get; }

        public override string ToString()
        {
            return $"({EndingLocation.Column}, {EndingLocation.Row})";
        }
    }
}