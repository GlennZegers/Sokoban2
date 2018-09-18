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
                Console.Write("> Kies een doolhof (1 - 4), s = stop");
                Console.WriteLine();
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
    }
}