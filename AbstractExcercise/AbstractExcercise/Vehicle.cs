using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExcercise
{
    public abstract class Vehicle 
    {
        public string Year { get; set; } = "2000";
        public string Make { get; set; } = "Honda";
        public string Model { get; set; } = "Civic";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("Driving");
        }

        

    }
}
