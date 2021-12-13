using System;
using System.Collections.Generic;

namespace Chess.Pieces
{
    public class Queen : Piece
    {
        public Queen(PieceColour colour, PieceLocation location) : base(colour, location)
        {
            Symbol = colour == PieceColour.White ? 'Q' : 'q';
        }

        public override PieceType Type => PieceType.Queen;

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