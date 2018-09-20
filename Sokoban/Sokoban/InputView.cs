using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Sokoban
{
    public class InputView
    {

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
            bool isValid = false;

            while (!isValid)
            {
                var input = Console.ReadKey(false).Key;

                switch (input)
                {
                    case ConsoleKey.S:
                        //return to main menu
                        isValid = true;
                        break;
                    case ConsoleKey.R:
                        //reset game
                        //geen isvalid want de vraag van 'gebruik pijltjestoetsen' moet opnieuw komen
                        break;
                    case ConsoleKey.RightArrow:
                        //move to right
                        isValid = true;
                        break;
                    case ConsoleKey.LeftArrow:
                        //move to left
                        isValid = true;
                        break;
                    case ConsoleKey.UpArrow:
                        //move up
                        isValid = true;
                        break;
                    case ConsoleKey.DownArrow:
                        //move down
                        isValid = true;
                        break;
                    default:
                        //do nothing
                        break;
                }
            }
        }
    }
}