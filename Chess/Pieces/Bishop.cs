using System;
using System.Collections.Generic;

namespace Chess.Pieces
{
    public class Bishop : Piece
    {
        public Bishop(PieceColour colour, PieceLocation location) : base(colour, location)
        {
            Symbol = colour == PieceColour.White ? 'B' : 'b';
        }

        public override PieceType Type => PieceType.Bishop;

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