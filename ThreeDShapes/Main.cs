using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeDShapes
{

    //

    internal class ThreeDShapeMain
    {
        static void Main(string[] args)
        {
            //ThreeDShape threeDShape = new ThreeDShape(ThreeDShape.ShapeType.prism);
            Sphere[] collectionOfShapes = new Sphere[20];
            // Display the number of command line arguments.
            Console.WriteLine(args.Length);

            //
            Sphere smallSphere = new Sphere(20);
            smallSphere.calVolume();

            for (int i = 0; i < 20; i++)
            {
                Sphere newSphere = new Sphere(i);
                collectionOfShapes[i] = newSphere;
            }

            // prints out string
            foreach (Sphere sphere in collectionOfShapes)
            {
                Console.WriteLine(sphere.ToString());
                Console.WriteLine(sphere.calVolume());

            }

     
        }

    }
}
