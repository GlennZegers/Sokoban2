using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.Model
{
    public class Employee : Moveable
    {
        public override Field CurrentField { get; set; }
        private Boolean Asleep { get; set; }
        private int _randomDirection;

        public void Move()
        {
            if (CurrentField == null)
            {
                return;
            }
            if (Asleep)
            {
                if (RandomNumber(10, 20) == 13)
                {
                    Asleep = false;
                }
            }
            else
            {
                if (RandomNumber(10, 15) == 13)
                {
                    Asleep = true;
                }
            }
            _randomDirection = RandomNumber(1, 5);

            if (Asleep)
            {
                return;
            }
            switch (_randomDirection)
            {
                case 1:
                    MoveRight(false);
                    break;
                case 2:
                    MoveLeft(false);
                    break;
                case 3:
                    MoveDown(false);
                    break;
                case 4:
                    MoveUp(false);
                    break;
            }

        }

        public override Boolean MoveRight(Boolean fromEmployee)
        {
            if (!fromEmployee)
            {
                CurrentField.RightField.Move(1, this);
            }
            return false;
        }

        public override Boolean MoveLeft(Boolean fromEmployee)
        {
            if (!fromEmployee)
            {
                CurrentField.LeftField.Move(2, this);
            }
            return false;
        }

        public override Boolean MoveUp(Boolean fromEmployee)
        {
            if (!fromEmployee)
            {
                CurrentField.LowerField.Move(3, this);
            }
            return false;
        }

        public override Boolean MoveDown(Boolean fromEmployee)
        {
            if (!fromEmployee)
            {
                CurrentField.UpperField.Move(4, this);
            }
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

        public override void WakeUp()
        {
            Asleep = false;
        }
    }
}
