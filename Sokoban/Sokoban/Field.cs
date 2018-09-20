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
        public Field LoweField { get; set; }
        public Field LeftField { get; set; }
        public Field RightField { get; set; }
        public Player Player {get; set;}
        public Crate Crate
        {
            get;
            set;
        }
    }
}
