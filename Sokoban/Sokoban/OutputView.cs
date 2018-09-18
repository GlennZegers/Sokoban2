using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class OutputView
    {
        public void StartMessage()
        {
            Console.Write("┌────────────────────────────────────────────────────┐");
            Console.WriteLine();
            Console.Write("| Welkom bij Sokoban                                 |");
            Console.WriteLine();
            Console.Write("|                                                    |");
            Console.WriteLine();
            Console.Write("| betekenis van de symbolen   |   doel van het spel  |");
            Console.WriteLine();
            Console.Write("|                             |                      |");
            Console.WriteLine();
            Console.Write("| spatie : outerspace         |   duw met de truck   |");
            Console.WriteLine();
            Console.Write("|      █ : muur               |   de krat(ten)       |");
            Console.WriteLine();
            Console.Write("|      · : vloer              |   naar de bestemming |");
            Console.WriteLine();
            Console.Write("|      O : krat               |                      |");
            Console.WriteLine();
            Console.Write("|      0 : krat op bestemming |                      |");
            Console.WriteLine();
            Console.Write("|      x : bestemming         |                      |");
            Console.WriteLine();
            Console.Write("|      @ : truck              |                      |");
            Console.WriteLine();
            Console.Write("└────────────────────────────────────────────────────┘");
            Console.WriteLine();
        }
    }
}