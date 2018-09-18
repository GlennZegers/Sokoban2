using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Control
    {
        public Game Game
        {
            get => default(Game);
            set
            {
            }
        }

        public InputView MenuView
        {
            get => default(InputView);
            set
            {
            }
        }

        public OutputView MazeView
        {
            get => default(OutputView);
            set
            {
            }
        }

        public Parser MazeParse
        {
            get => default(Parser);
            set
            {
            }
        }
    }
}