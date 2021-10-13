using System;
using System.Collections.Generic;

namespace Abstract_Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Shape shape1 = new Square();
            shape1.Name = "whatever";
            Shape shape2 = new Circle();
            Shape shape3 = new Triangle();

            Square s1 = new Square();
            Circle c1 = new Circle();
            Triangle t1 = new Triangle();
            
            var shapeList = new List<Shape>();
            shapeList.Add(shape1);
            shapeList.Add(shape2);
            shapeList.Add(shape3);

            foreach (var shape in shapeList)
            {
                Console.WriteLine($"Name: {shape.Name}");
            }

            var squares = new List<Square>();
            var circles = new List<Circle>();
            var triangles = new List<Triangle>();
            squares.Add(s1);
            circles.Add(c1);
            triangles.Add(t1);


            Console.WriteLine();            

        }
    }
}
