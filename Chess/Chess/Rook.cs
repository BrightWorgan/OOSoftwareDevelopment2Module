using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    abstract class Rook : Base_Piece
    {
        public Rook(Colour _colour, string _name) : base(_colour, _name)
        {
            Colour = _colour;
            Name = _name;
        }


        public override void Move()
        {
            // ?
            // get location in array
            // remove from array
            // add to another position in array
        }
    }
}
