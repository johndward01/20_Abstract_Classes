using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace AbstractExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var list = new List<Vehicle>();

            // 1st instance
            Car civic = new Car();
            civic.Make = "Honda";
            civic.Model = "Civic";

            // 2nd instance 
            Motorcycle hayabusa = new Motorcycle()
            {
                Make = "Kawasaki",
                Model = "Hayabusa"
            };

            // 2 instances of Vehicle
            Vehicle ford = new Car()
            {
                Make = "Ford",
                Model = "Focus"
            };

            Vehicle ninja = new Motorcycle()
            {
                Make = "Kawasaki",
                Model = "Ninja"
            };

            


            list.Add(hayabusa);
            list.Add(civic);
            list.Add(ford);
            list.Add(ninja);

            foreach (var vehicle in list)
            {
                Console.WriteLine($"Year: {vehicle.Year}\n" +
                                  $"Make: {vehicle.Make}\n" +
                                  $"Model: {vehicle.Model}");
                Console.WriteLine();
            }

            Console.WriteLine();

            hayabusa.DriveAbstract();
            civic.DriveAbstract();
            civic.DriveVirtual();
            hayabusa.DriveVirtual();


            #region List of TODO's
            /*
            * Create an abstract class called Vehicle
            * The vehicle class shall have three string properties Year, Make, and Model
            * Set the defaults to something generic in the Vehicle class
            * Vehicle shall have an abstract method called DriveAbstract with no implementation
            * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
            */

            /* 
            * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
            * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
            * Provide the implementations for the abstract methods
            * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles


            /*
            * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
            * - new it up as one of each derived class
            * Set the properties with object initializer syntax
            */

            /*
            * Add the 4 vehicles to the list
            * Using a foreach loop iterate over each of the properties
            */

            // Call each of the drive methods for one car and one motorcycle
            #endregion

        }
    }
}

