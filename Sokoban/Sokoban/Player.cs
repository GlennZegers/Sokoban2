﻿using System;
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
                //CurrentField.MoveRight();    (hierin worden dan de tekens aangepast)
                CurrentField = CurrentField.RightField;
            }
           
        }

        public void MoveLeft()
        {

        }

        public void MoveUp()
        {

        }

        public void MoveDown()
        {

        }

        //kan dat deze ook in 4 verdeeld moet worden, of dat ieder deel in het begin van de methode moet
        public bool CanMove()
        {
            //checks of je de krat kan bewegen de kant die je op wilt
            return true;

            //zo niet
            return false;
        }
    }
}