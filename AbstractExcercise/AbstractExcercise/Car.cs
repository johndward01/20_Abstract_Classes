using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExcercise
{
    public class Car : Vehicle
    {        
        public double FuelTank { get; set; }
        public int Doors { get; set; }
               

        public override void DriveAbstract()
        {
            Console.WriteLine($"This car's tank holds {FuelTank} gallons and has {Doors} doors.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"I'm driving a {GetType().Name} in a virtual method, it is a {GetType().BaseType.Name}");
        }

    }
}
