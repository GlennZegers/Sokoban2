using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.Model
{
   public  class Employee : Moveable
    {
        public override Field CurrentField { get; set; }
        public Boolean Asleep { get; set; }
        private int _randomDirection;

        public void Move()
        {
            _randomDirection = RandomNumber(1, 5);
            switch (_randomDirection)
            {   
                case 1:
                    MoveRight();
                    break;
                case 2:
                    MoveLeft();
                    break;
                case 3:
                    MoveDown();
                    break;
                case 4:
                    MoveUp();
                    break;
            }
        }

        public override Boolean MoveRight()
        {
            CurrentField.RightField.Move(1, this);
            return false;
        }

        public override Boolean MoveLeft()
        {
            _randomDirection = RandomNumber(1, 4);
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
            if (Asleep)
            {
                return "Z";
            }
            return "$";
        }

        public override string PrintOnDesField()
        {
            return Print();
        }

        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
