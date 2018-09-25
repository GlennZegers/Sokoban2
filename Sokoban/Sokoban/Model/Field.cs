using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    public class Field
    {
        public Field UpperField { get; set; }
        public Field LowerField { get; set; }
        public Field LeftField { get; set; }
        public Field RightField { get; set; }
        public Player Player {get; set;}
        public Crate Crate
        {
            get;
            set;
        }

        public bool HasCrate { get; set;  }

        //direction 1 = right
        //direction 2 = left
        //direction 3 = up
        //direction 4 = down

        public void Move(int direction)
        {
            switch (direction)
            {
                case 1:
                    Player = LeftField.Player;
                    if (HasCrate)
                    {
                        RightField.HasCrate = true;
                        RightField.Crate = Crate;
                        HasCrate = false;
                        Crate = null;
                    }
                    LeftField.Player = null;
                    break;

                case 2:
                    Player = RightField.Player;
                    if (HasCrate)
                    {
                        LeftField.HasCrate = true;
                        LeftField.Crate = Crate;
                        HasCrate = false;
                        Crate = null;
                    }
                    RightField.Player = null;
                    break;

                case 3:
                    Player = UpperField.Player;
                    if (HasCrate)
                    {
                        LowerField.HasCrate = true;
                        LowerField.Crate = Crate;
                        HasCrate = false;
                        Crate = null;
                    }
                    UpperField.Player = null;
                    break;

                case 4:
                    Player = LowerField.Player;
                    if (HasCrate)
                    {
                        UpperField.HasCrate = true;
                        UpperField.Crate = Crate;
                        HasCrate = false;
                        Crate = null;
                    }
                    LowerField.Player = null;
                    break;
            }
        }
    }
}
