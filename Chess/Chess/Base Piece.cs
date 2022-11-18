using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public enum Colour
    {
        Black,
        White
    }
    public abstract class Base_Piece
    {
        // colour
        public Colour Colour { get; set; }

        // name
        public string Name { get; set; }

        public Base_Piece(Colour _colour, string _name)
        {
            this.Colour = _colour;
            this.Name = _name;
        }


        // move method
        public abstract void Move();

    }
}
