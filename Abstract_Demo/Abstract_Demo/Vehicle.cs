using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Demo
{
    public abstract class Vehicle
    {
        public abstract int NumberOfDoors { get; set; }
        public abstract bool HasWheels { get; set; }
    }
}
