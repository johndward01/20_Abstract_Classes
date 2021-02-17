using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExcercise
{
    public abstract class Vehicle : CarLot
    {
        public string Year { get; set; } = "2000";
        public string Make { get; set; } = "Honda";
        public string Model { get; set; } = "Civic";
        public bool HasTrunk { get; set; }
        public bool HasSideCar { get; set; }
        public int Wheels { get; set; }
        public int Doors { get; set; }

        public abstract void Drive();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("Driving");
        }

        public void Brake()
        {
            Console.WriteLine("Braking");
        }

        public virtual void Shift()
        {
            Console.WriteLine("Automatic shift");
        }

    }
}
