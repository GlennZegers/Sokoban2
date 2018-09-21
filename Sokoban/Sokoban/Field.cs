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
            //deze klasse krijgt dan een speler
            //1 van zijn naaste klassen kan een krat krijgen, op basis van een parameter
            //1 van zijn andere naaste klassen wordt dan leeg

            switch (direction)
            {
                case 1:
                    Player = LeftField.Player;
                    if (HasCrate)
                    {
                        RightField.HasCrate = true;
                        HasCrate = false;
                    }
                    LeftField.Player = null;
                    break;

                case 2:
                    Player = RightField.Player;
                    if (HasCrate)
                    {
                        LeftField.HasCrate = true;
                        HasCrate = false;
                    }
                    RightField.Player = null;
                    break;

                case 3:
                    Player = LowerField.Player;
                    if (HasCrate)
                    {
                        LowerField.HasCrate = true;
                        HasCrate = false;
                    }
                    LowerField.Player = null;
                    break;

                case 4:
                    Player = UpperField.Player;
                    if (HasCrate)
                    {
                        UpperField.HasCrate = true;
                        HasCrate = false;
                    }
                    UpperField.Player = null;
                    break;
            }
        }
    }
}
