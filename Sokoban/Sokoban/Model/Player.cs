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

        public override Boolean MoveRight(Boolean fromEmployee)
        {
            return CurrentField.RightField.Move(1, this);
        }

        public override Boolean MoveLeft(Boolean fromEmployee)
        {
            return CurrentField.LeftField.Move(2, this);
        }

        public override Boolean MoveUp(Boolean fromEmployee)
        {
            return CurrentField.LowerField.Move(3, this);
        }

        public override Boolean MoveDown(Boolean fromEmployee)
        {
            return CurrentField.UpperField.Move(4, this);
        }

        public override string Print()
        {
            return "@";
        }

        public override string PrintOnDesField()
        {
            return "@";
        }

        public override void WakeUp()
        {
            return;
        }
    }
}