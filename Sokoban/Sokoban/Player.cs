using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Player
    {
        public Field CurrentField { get; set; }

        public void MoveRight()
        {
            bool CanMove = false;
            if (!(CurrentField.RightField is Wall))
            {
                if (CurrentField.RightField.HasCrate)
                {
                    if (!(CurrentField.RightField.RightField is Wall))
                    {
                        CanMove = true;
                    }
                }
                else 
                {
                    CanMove = true;
                }
            }
            
            if (CanMove)
            {
                CurrentField.RightField.Move(1);    //(hierin worden dan de tekens aangepast)
                CurrentField = CurrentField.RightField;
            }
           
        }

        public void MoveLeft()
        {
            bool CanMove = false;
            if (!(CurrentField.LeftField is Wall))
            {
                if (CurrentField.LeftField.HasCrate)
                {
                    if (!(CurrentField.LeftField.LeftField is Wall))
                    {
                        CanMove = true;
                    }
                }
                else
                {
                    CanMove = true;
                }
            }

            if (CanMove)
            {
                CurrentField.LeftField.Move(2);    //(hierin worden dan de tekens aangepast)
                CurrentField = CurrentField.LeftField;
            }
        }

        public void MoveUp()
        {
            bool CanMove = false;
            if (!(CurrentField.UpperField is Wall))
            {
                if (CurrentField.UpperField.HasCrate)
                {
                    if (!(CurrentField.UpperField.UpperField is Wall))
                    {
                        CanMove = true;
                    }
                }
                else
                {
                    CanMove = true;
                }
            }

            if (CanMove)
            {
                CurrentField.UpperField.Move(3);    //(hierin worden dan de tekens aangepast)
                CurrentField = CurrentField.UpperField;
            }
        }

        public void MoveDown()
        {
            bool CanMove = false;
            if (!(CurrentField.LowerField is Wall))
            {
                if (CurrentField.LowerField.HasCrate)
                {
                    if (!(CurrentField.LowerField.LowerField is Wall))
                    {
                        CanMove = true;
                    }
                }
                else
                {
                    CanMove = true;
                }
            }

            if (CanMove)
            {
                CurrentField.LowerField.Move(4);    //(hierin worden dan de tekens aangepast)
                CurrentField = CurrentField.LowerField;
            }
        }
    }
}