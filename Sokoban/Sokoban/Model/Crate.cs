using Sokoban.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Crate : Moveable
    {
        public override Field CurrentField { get; set ; }

        public override Boolean MoveDown(Boolean fromEmployee)
        {
          if (CurrentField.UpperField.TakeInCrate(3))
          {
                CurrentField.LowerField.LowerCounter();
                CurrentField.RaiseCounter();
                return true;
          }
            return false;
        }

        public override Boolean MoveLeft(Boolean fromEmployee)
        {
           if(CurrentField.LeftField.TakeInCrate(2))
            {
                CurrentField.RightField.LowerCounter();
                CurrentField.RaiseCounter();
                return true;
            }
            return false;
        }

        public override Boolean MoveRight(Boolean fromEmployee)
        {
           if(CurrentField.RightField.TakeInCrate(1))
            {
                CurrentField.LeftField.LowerCounter();
                CurrentField.RaiseCounter();
                return true;
            }
            return false;
        }

        public override Boolean MoveUp(Boolean fromEmployee)
        {
           if (CurrentField.LowerField.TakeInCrate(4))
            {
                CurrentField.UpperField.LowerCounter();
                CurrentField.RaiseCounter();
                return true;
            }
            return false;
        }

        public override string Print()
        {
            return "o";
        }

        public override string PrintOnDesField()
        {
            return "0";
        }

        public override void WakeUp()
        {
            return;
        }
    }

}