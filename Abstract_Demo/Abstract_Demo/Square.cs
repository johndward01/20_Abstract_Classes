using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Demo
{
    public class Square : Shape
    {
        public override string Name { get; set; }
        public override int NumberOfSides { get; set; }
        public override bool Is_3Dimensional { get; set; }

        public override double Area(double x)
        {
            return x * x;
        }

        public override double Perimeter(params double[] sides)
        {
            return 5.25;
        }

        public override double SurfaceArea(int sideLength)
        {
            return Math.Pow(sideLength, 2);
        }

    }
}
