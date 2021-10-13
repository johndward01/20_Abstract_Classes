using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Demo
{
    public class Car : Vehicle
    {
        public override int NumberOfDoors { get; set; }
        public override bool HasWheels { get; set; }
    }
}
