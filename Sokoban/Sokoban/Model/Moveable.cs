using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.Model
{
    public abstract class Moveable
    {
        public abstract Boolean MoveUp(Boolean fromEmployee);
        public abstract Boolean MoveDown(Boolean fromEmployee);
        public abstract Boolean MoveLeft(Boolean fromEmployee);
        public abstract Boolean MoveRight(Boolean fromEmployee);
        public abstract String Print();
        public abstract String PrintOnDesField();
        public abstract Field CurrentField { get; set; }
        public abstract void WakeUp();
    }
}
