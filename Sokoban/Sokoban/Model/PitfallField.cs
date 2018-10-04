using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.Model
{
    class PitfallField : Field
    {
        public int AmountOfObjects { get; set; }

        public PitfallField()
        {
            AmountOfObjects = 0;
        }

        public override String Print()
        {
            if (Moveable != null)
            {
                return Moveable.Print();
            }

            if (AmountOfObjects >= 3)
            {
                return " ";
            }

            return "~";
        }

        public override void Move(int direction, Moveable moveable)
        {
            Boolean shouldMove = true;
            switch (direction)
            {
                case 1: // right
                    if (this.Moveable != null)
                    {
                        shouldMove = this.Moveable.MoveRight();
                    }
                    if (shouldMove)
                    {
                        this.Moveable = LeftField.Moveable;
                        moveable.CurrentField = this;
                        LeftField.Moveable = null;
                        if (AmountOfObjects < 3)
                        {
                            AmountOfObjects++;
                        }
                    }
                    break;
                case 2: // left
                    if (this.Moveable != null)
                    {
                        shouldMove = this.Moveable.MoveLeft();
                    }
                    if (shouldMove)
                    {
                        this.Moveable = RightField.Moveable;
                        moveable.CurrentField = this;
                        RightField.Moveable = null;
                        if (AmountOfObjects < 3)
                        {
                            AmountOfObjects++;
                        }
                    }

                    break;
                case 3: // up
                    if (this.Moveable != null)
                    {
                        shouldMove = this.Moveable.MoveUp();
                    }
                    if (shouldMove)
                    {
                        this.Moveable = UpperField.Moveable;
                        moveable.CurrentField = this;
                        UpperField.Moveable = null;
                        if (AmountOfObjects < 3)
                        {
                            AmountOfObjects++;
                        }
                    }

                    break;
                case 4: // down
                    if (this.Moveable != null)
                    {
                        shouldMove = this.Moveable.MoveDown();
                    }
                    if (shouldMove)
                    {
                        this.Moveable = LowerField.Moveable;
                        moveable.CurrentField = this;
                        LowerField.Moveable = null;
                        if (AmountOfObjects < 3)
                        {
                            AmountOfObjects++;
                        }
                    }
                    break;
            }
        }

        public override Boolean TakeInCrate(int direction)
        {
            if (this.Moveable != null)
            {
                return false;
            }
            switch (direction)
            {
                case 1: // right
                    LeftField.Moveable.CurrentField = this;
                    if (AmountOfObjects >= 3)
                    {
                        LeftField.Moveable = null;
                        break;
                    }
                    this.Moveable = LeftField.Moveable;
                    LeftField.Moveable = null;
                    AmountOfObjects++;
                    break;
                case 2: // left
                    RightField.Moveable.CurrentField = this;
                    if (AmountOfObjects >= 3)
                    {
                        RightField.Moveable = null;
                        break;
                    }
                    this.Moveable = RightField.Moveable;
                    RightField.Moveable = null;
                    AmountOfObjects++;
                    break;
                case 3: // up
                    LowerField.Moveable.CurrentField = this;
                    if (AmountOfObjects >= 3)
                    {
                        LowerField.Moveable = null;
                        break;
                    }
                    this.Moveable = LowerField.Moveable;
                    LowerField.Moveable = null;
                    AmountOfObjects++;
                    break;
                case 4: // down
                    UpperField.Moveable.CurrentField = this;
                    if (AmountOfObjects >= 3)
                    {
                        UpperField.Moveable = null;
                        break;
                    }
                    this.Moveable = UpperField.Moveable;
                    UpperField.Moveable = null;
                    AmountOfObjects++;
                    break;
            }
            return true;
        }
    }
}
