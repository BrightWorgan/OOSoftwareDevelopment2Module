using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeDShapes;
using static ThreeDShapes.ThreeDShape;


// Lab 1
// X00192313

namespace ThreeDShapes
{
    // Exercise A1
    abstract class ThreeDShape
    {
        //// Exercise A2, Enum to store shape types
        public enum ShapeType
        {
            sphere = 0,
            cylinder = 1,
            cone = 2,
            cube = 3,
            prism = 4
        }
        // type of shape
        private readonly ShapeType _type;

        public ShapeType Type
        {

            // getter method
            get
            {
                return _type;
            }
        }

        // // Exercise A3, constructor 
        public ThreeDShape(ShapeType type)
        {
            _type = type;
        }


        // // Exercise A4, calculate volume function
        public abstract decimal calVolume();

        // Exercise A5 override ?/Unsure
        public override string ToString()
        {
            return "" + _type.ToString();
        }

        // Exercise A6 test the class
        // 
    }


    // Exercise B1, 
    class Sphere : ThreeDShape
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
        public override decimal calVolume()
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
