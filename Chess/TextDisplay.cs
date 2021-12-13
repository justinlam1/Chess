using System;
using System.Collections.Generic;

namespace Chess.Pieces
{
    public class TextDisplay
    {
        public void ShowBoard(List<List<Cell>> board)
        {
            for (int i = board.Count - 1; i >= 0; i--)
            {
                for (int j = 0; j < board.Count; j++)
                {
                    Console.Write(board[i][j].GetSymbol().ToString() + " ");
                }
            
                Console.WriteLine();
            }
            
            // for (int i = 0; i < 8; i++)
            // {
            //     for (int j = 0; j < board.Count; j++)
            //     {
            //         Console.Write(board[i][j].GetSymbol().ToString() + " ");
            //     }
            //
            //     Console.WriteLine();
            // }
        }
    }
}