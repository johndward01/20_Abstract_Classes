using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExcercise
{
    public class Car : Vehicle
    {
        
        public int Wheels { get; set; }
        public int Doors { get; set; }

        public Car()
        {
            Wheels = 4;
            Doors = 4;
        }

        public override void Drive()
        {
            Console.WriteLine($"A car drives with {Wheels} wheels and has {Doors} doors.");
        }

       

    }
}
