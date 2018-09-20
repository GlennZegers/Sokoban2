using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Game
    {
        public Maze Maze
        {
            get => default(Maze);
            set
            {
            }
        }

        public Player Player
        {
            get => default(Player);
            set
            {
            }
        }

        public void Play()
        {
            //hier is dus al een doolhof gekozen
            //while (!HasNotWon)
            //{
                //OutputView.StandardScreen();
                //InputView.MakeAMove();
                //Check if has won
                //OutputView.StandardScreen();
            //}
        }
    }
}