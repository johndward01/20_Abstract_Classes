using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Demo
{
    public abstract class Shape 
    {
        public abstract string Name { get; set; }
        public abstract int NumberOfSides { get; set; }
        public abstract bool Is_3Dimensional { get; set; }

        public abstract double Area(double x);
        public abstract double Perimeter(params double[] sides);

        public virtual double Volume(double width, double height, double length)
        {
            return width * length * height;
        }

        public virtual double SurfaceArea(int sideLength)
        {
            return Math.Pow(sideLength, 2);
        }
    }
}
