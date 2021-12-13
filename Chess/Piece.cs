using System;
using System.Collections;
using System.Collections.Generic;

namespace Chess
{
    public abstract class Piece
    {
        public PieceLocation CurrentLocation { get; set; }
        public PieceColour Colour { get; private set; }
        public char Symbol { get; set; }


        protected Piece(PieceColour colour, PieceLocation location)
        {
            this.Colour = colour;
            this.CurrentLocation = location;
        }
        
        public abstract PieceType Type { get; }
        public abstract IEnumerable<Move> GetValidMoves(Board board);
        public abstract bool IsValidMove();
        public abstract void Move();
        
    }
}