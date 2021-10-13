using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace AbstractExcercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Car s1 = new Car();
            Vehicle v1 = new Car();
            Vehicle v2 = new Motorcycle();

















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

            var vehicles = new List<Vehicle>();

            Car car1 = new Car { Make = "Honda", Model = "Civic", Year = "2000", FuelTank = 10, Doors = 2 };

            Motorcycle motor1 = new Motorcycle()
            {
                Make = "Kawasaki",
                Model = "Hayabusa",
                Year = "2020",
                Doors = 0,
                Wheels = 2
            };
                        
            Vehicle car2 = new Car()
            {
                Make = "Ford",
                Model = "Focus",
                Year = "1999"
            };

            Vehicle motor2 = new Motorcycle()
            {
                Make = "Kawasaki",
                Model = "Ninja",
                Year = "2014"
            };

            vehicles.Add(car1);
            vehicles.Add(motor1);
            vehicles.Add(car2);
            vehicles.Add(motor2);            

            foreach (var vehicle in vehicles)
            {
                // Show here that only Vehicle members are present
                Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model}");
                AddSpaces(1);
            }

            AddSpaces(3);

            //These methods use the GetType() to stay flexible
            car1.DriveAbstract();
            AddSpaces(1);
            car1.DriveVirtual();
            AddSpaces(1);
            motor1.DriveAbstract();
            AddSpaces(1);
            motor1.DriveVirtual();
            AddSpaces(1);

        }

        public static void AddSpaces(int numberOfSpaces)
        {
            while (numberOfSpaces != 0)
            {
                Console.WriteLine();
                numberOfSpaces--;
            }
        }
    }
}

