using System;
using System.Collections.Generic;

namespace Chess.Pieces
{
    public class Pawn : Piece
    {
        private bool IsPromotable = true;
        
        private static readonly int[][] MoveTemplates = new int[][]
        {
            new[] {0, 1},
            new[] {-1, 1},
            new[] {-1, 0},
            new[] {-1, -1},
            new[] {0, -1},
            new[] {1, -1},
            new[] {1, 0},
            new[] {1, 1},

        };
        public Pawn(PieceColour colour, PieceLocation location) : base(colour, location)
        {
            Symbol = colour == PieceColour.White ? 'P' : 'p';
        }

        public override PieceType Type => PieceType.Pawn;

        public override IEnumerable<Move> GetValidMoves(Board board)
        {
            return ChessUtilities.GetValidMoves(board, this, 1, MoveTemplates);
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