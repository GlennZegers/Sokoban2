using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.Model
{
    public abstract class Moveable
    {
        public abstract Boolean MoveUp();
        public abstract Boolean MoveDown();
        public abstract Boolean MoveLeft();
        public abstract Boolean MoveRight();
        public abstract String Print();
        public abstract String PrintOnDesField();
        public abstract Field CurrentField { get; set; }
    }
}
