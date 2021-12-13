using System;
using System.Collections.Generic;
using Chess.Pieces;

namespace Chess
{
    public class Controller
    {
        private Board model;
        private TextDisplay view;
        private bool WhiteTurn = true;
        private bool GameIsRunning = true;
        
        public Controller()
        {
            model = new Board();
            view = new TextDisplay();
        }
        
        public void Play()
        {
            while (true)
            {
                Console.WriteLine("Enter a command:");
                var input = Console.ReadLine();
                if (input.Equals("p"))
                {
                    Console.WriteLine("Starting game");
                    model.InitializeBoard();
                    GameLoop();
                }
                else if (input.Equals("q"))
                {
                    return;
                }
            }
        }

        private void GameLoop()
        {
            while (GameIsRunning)
            {
                view.ShowBoard(model.board);
                
                string turn = WhiteTurn ? "White" : "Black";
                Console.WriteLine($"{turn} to move. Syntax: move [from] [to]");
                var input = Console.ReadLine();
                var commandArray = input.Split(" ");
                if (commandArray[0].Equals("move"))
                {
                    
                    model.MovePiece(3, 1, 3, 2);
                    foreach (var test in model.GetValidMovesFor(3, 2))
                    {
                        Console.WriteLine(test);
                    }
                }
                else if (input.Equals("q"))
                {
                    break;
                }
                WhiteTurn = !WhiteTurn;
            }
        }
        
    }
}