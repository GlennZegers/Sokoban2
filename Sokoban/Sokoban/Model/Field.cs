using Sokoban.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    public class Field
    {
        public Game Game { get; set; }
        public Field UpperField { get; set; }
        public Field LowerField { get; set; }
        public Field LeftField { get; set; }
        public Field RightField { get; set; }
        public Moveable Moveable { get; set; }
        public bool HasCrate { get; set; }

        public virtual String Print()
        {
          if(Moveable != null)
            {
                return Moveable.Print();
            }
            return ".";
        }

        //direction 1 = right
        //direction 2 = left
        //direction 3 = up
        //direction 4 = down
        public virtual Boolean TakeInCrate(int direction)
        {
            if (this.Moveable != null)
            {
                return false;
            }
            switch (direction)
            {
                case 1: // right
                    LeftField.Moveable.CurrentField = this;
                    this.Moveable = LeftField.Moveable;
                    LeftField.Moveable = null;
                    break;
                case 2: // left
                    RightField.Moveable.CurrentField = this;
                    this.Moveable = RightField.Moveable;
                    RightField.Moveable = null;
                    break;
                case 3: // up
                    LowerField.Moveable.CurrentField = this;
                    this.Moveable = LowerField.Moveable;
                    LowerField.Moveable = null;

                    break;
                case 4: // down
                    UpperField.Moveable.CurrentField = this;
                    this.Moveable = UpperField.Moveable;
                    UpperField.Moveable = null;
                    break;
            }
            return true;
        }

        public virtual void Move(int direction, Moveable moveable)
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
                    }
                    break;
            }
        }

        public virtual void LowerCounter()
        {
            return;
        }

        public virtual void RaiseCounter()
        {
            return;
        }
    }
}
