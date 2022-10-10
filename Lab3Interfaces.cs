using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Lab 1
// Sarah H. / X00192313

namespace ThreeDShapes
{
    // Exercise A1
    interface IHasVolume
    {
        public decimal Volume();
    }


    // Exercise B1, 
    class Sphere : IHasVolume
    {
        // Exercise B2
        private decimal radius = 0;

        public decimal Radius
        {
            get { return radius; }
            set
            { 
                if (value >= 0)
                {
                    radius = value;
                }
                else
                {
                    throw new Exception("Radius must be a positive decimal");
                }
            }
        }
        // Exercise B3, constructor 
        public Sphere(decimal radius): base(ShapeType.sphere)
        {
            this.radius = radius;
        }

        // Exercise B4, override
        public decimal Volume()
        {
            // vol=4* Math.PI * Math.Pow(r, 3) /3; (using pie and power)
            return (decimal) ((4 * Math.PI * Math.Pow(decimal.ToDouble(radius), 3)) / 3);
        }
        
        // Exercise B5,
        public override string ToString()
        {
            return "This sphere has a radius of " + radius;
        }

    }



}
