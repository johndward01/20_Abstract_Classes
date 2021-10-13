using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Demo
{
    public class Triangle : Shape
    {
        public override string Name { get; set; }
        public override int NumberOfSides { get; set; }
        public override bool Is_3Dimensional { get; set; }

        public override double Area(double x)
        {
            int b = 10;
            return .5 * b * x;
        }

        public override double Perimeter(params double[] sides)
        {
            throw new NotImplementedException();
        }
    }
}
