using System;
using System.Collections.Generic;

namespace Chess.Pieces
{
    public class Knight : Piece
    {
        public Knight(PieceColour colour, PieceLocation location) : base(colour, location)
        {
            Symbol = colour == PieceColour.White ? 'N' : 'n';
        }

        public override PieceType Type => PieceType.Knight;

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