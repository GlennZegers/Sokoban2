using Sokoban.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Player : Moveable
    {
        public override Field CurrentField { get; set; }
 

        public override Boolean MoveRight()
        {
            CurrentField.RightField.Move(1, this);
            return false;
        }

        public override Boolean MoveLeft()
        {
            CurrentField.LeftField.Move(2, this);
            return false;
        }

        public override Boolean MoveUp()
        {
            CurrentField.LowerField.Move(3, this);
            return false;
        }

        public override Boolean MoveDown()
        {
            CurrentField.UpperField.Move(4, this);
            return false;
        }

        public override string Print()
        {
            return "@";
        }
        public override string PrintOnDesField()
        {
            return "@";
        }
    }
}