using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Sokoban
{
    public class InputView
    {
        public Game game { get; set; }

        public InputView(Game game)
        {
            this.game = game;
        }

        public int ChooseMaze()
        {
            bool isValid = false;
            int MazeNumber = 0;

            while (!isValid)
            {
                Console.WriteLine("> Kies een doolhof (1 - 4), s = stop");
                string input = Console.ReadLine();

                if (input.Equals("s"))
                {
                    isValid = true;
                    Environment.Exit(0);
                    return 0;
                }

                if (Regex.IsMatch(input, @"^\d+$") && Int32.Parse(input) >= 1 && Int32.Parse(input) <= 4)
                {
                    MazeNumber = Int32.Parse(input);
                    isValid = true;
                }
            }
            return MazeNumber;
        }

        public void MakeAMove()
        {
            bool IsValid = false;

            while (!IsValid)
            {
                var Input = Console.ReadKey(false).Key;

                switch (Input)
                {
                    case ConsoleKey.S:
                        game.StartOver();
                        IsValid = true;
                        break;
                    case ConsoleKey.R:
                        game.ResetGame();
                        IsValid = true;
                        break;
                    case ConsoleKey.RightArrow:
                        game.Player.MoveRight();
                        IsValid = true;
                        break;
                    case ConsoleKey.LeftArrow:
                        game.Player.MoveLeft();
                        IsValid = true;
                        break;
                    case ConsoleKey.UpArrow:
                        game.Player.MoveUp();
                        IsValid = true;
                        break;
                    case ConsoleKey.DownArrow:
                        game.Player.MoveDown();
                        IsValid = true;
                        break;
                    default:
                        //do nothing
                        break;
                }
            }
        }
    }
}