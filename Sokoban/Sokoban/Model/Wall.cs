using Sokoban.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Wall : Field
    {
        public override void Move(int Direction, Moveable moveable)
        {
            return;
        }

        public override String Print()
        {
            return "█";
        }

        public override Boolean TakeInCrate(int direction)
        {
            return false ;
        }
    }
}