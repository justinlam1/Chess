using System;
using System.Collections.Generic;

namespace Chess.Pieces
{
    public class Rook : Piece
    {
        public Rook(PieceColour colour, PieceLocation location) : base(colour, location)
        {
            Symbol = colour == PieceColour.White ? 'R' : 'r';
        }

        public override PieceType Type => PieceType.Rook;

        public override IEnumerable<Move> GetValidMoves(Board board)
        {
            throw new NotImplementedException();
        }

        public override bool IsValidMove()
        {
            throw new System.NotImplementedException();
        }

        public override void Move()
        {
            throw new System.NotImplementedException();
        }
    }
}