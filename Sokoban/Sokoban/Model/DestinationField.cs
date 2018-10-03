using Sokoban.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class DestinationField : Field
    {
     
        public override String Print()
        {
            if (Moveable != null)
            {
                return Moveable.PrintOnDesField();
            }
            return "x";
        }

        public override void LowerCounter()
        {
            Game.WinCounter--;
        }

        public override  void RaiseCounter()
        {
            Game.WinCounter++;
        }

        
    }
}