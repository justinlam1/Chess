using System;
using System.Collections.Generic;
using Chess.Pieces;

namespace Chess
{
    public class Board
    {

        public List<List<Cell>> board;
        public int Size { get; set; } = 8;
        public bool WhiteInCheck;
        public bool BlackInCheck;

        public Board()
        {
            board = new List<List<Cell>>();
            for (int i = 0; i < 8; i++)
            {
                board.Add(new List<Cell>());
                for (int j = 0; j < 8; j++)
                {
                    board[i].Add(new Cell());
                }
            }
        }

        public Piece GetPieceAt(int column, int row)
        {
            return board[row][column].GetPiece();
        }
        public void PlacePieceAt(Piece piece, int column, int row)
        {
            piece.CurrentLocation = new PieceLocation(column, row);
            board[row][column].PlacePiece(piece);
        }

        public Piece RemovePieceAt(int column, int row)
        {
            return board[row][column].RemovePiece();
        }

        public void MovePiece(int fromColumn, int fromRow, int toColumn, int toRow)
        {
            PlacePieceAt(RemovePieceAt(fromColumn, fromRow), toColumn, toRow);
        }

        public IEnumerable<Move> GetValidMovesFor(int column, int row)
        {
            return GetPieceAt(column, row).GetValidMoves(this);
        }

        public void InitializeBoard()
        {
            PlacePieceAt(new Rook(PieceColour.White, new PieceLocation(0, 0)), 0, 0);
            PlacePieceAt(new Knight(PieceColour.White, new PieceLocation(1, 0)), 1, 0);
            PlacePieceAt(new Bishop(PieceColour.White, new PieceLocation(2, 0)), 2, 0);
            PlacePieceAt(new Queen(PieceColour.White, new PieceLocation(3, 0)), 3, 0);
            PlacePieceAt(new King(PieceColour.White, new PieceLocation(4, 0)), 4, 0);
            PlacePieceAt(new Bishop(PieceColour.White, new PieceLocation(5, 0)), 5, 0);
            PlacePieceAt(new Knight(PieceColour.White, new PieceLocation(6, 0)), 6, 0);
            PlacePieceAt(new Rook(PieceColour.White, new PieceLocation(7, 0)), 7, 0);
            
            PlacePieceAt(new Rook(PieceColour.Black, new PieceLocation(0, 7)), 0, 7);
            PlacePieceAt(new Knight(PieceColour.Black, new PieceLocation(1, 7)), 1, 7);
            PlacePieceAt(new Bishop(PieceColour.Black, new PieceLocation(2, 7)), 2, 7);
            PlacePieceAt(new Queen(PieceColour.Black, new PieceLocation(3, 7)), 3, 7);
            PlacePieceAt(new King(PieceColour.Black, new PieceLocation(4, 7)), 4, 7);
            PlacePieceAt(new Bishop(PieceColour.Black, new PieceLocation(5, 7)), 5, 7);
            PlacePieceAt(new Knight(PieceColour.Black, new PieceLocation(6, 7)), 6, 7);
            PlacePieceAt(new Rook(PieceColour.Black, new PieceLocation(7, 7)), 7, 7);

            for (int i = 0; i < 8; i++)
            {
                PlacePieceAt(new Pawn(PieceColour.White, new PieceLocation(i, 1)), i, 1);
            }
            
            for (int i = 0; i < 8; i++)
            {
                PlacePieceAt(new Pawn(PieceColour.Black, new PieceLocation(i, 6)), i, 6);
            }
        }
    }
}