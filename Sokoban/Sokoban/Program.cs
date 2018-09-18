using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser p = new Parser();
            p.createMaze(Convert.ToInt32(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}
