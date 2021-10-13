using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExcercise
{
    public abstract class Vehicle
    {
        public int NumberOfTires { get; set; } = 1;
        public string Make { get; set; } = "Generic Manufacturer";
        public string Model { get; set; } = "Generic Model";
        public string Year { get; set; } = "2000";


        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("I'm driving my vehicle");
        }

    }
}
